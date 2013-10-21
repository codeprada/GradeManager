using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Security;
using System.Security.Cryptography;

namespace Grade_Manager_DB_Controller
{

    public class User : Database_Object
    {
        public User() : base() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Profile { get; set; }

        public static implicit operator int(User usr)
        {
            return usr.Id;
        }

        public static implicit operator User(SQLiteDataReader reader)
        {
            User usr = new User();

            usr.FirstName = Convert.ToString(reader["account_first_name"]);
            usr.LastName = Convert.ToString(reader["account_last_name"]);
            usr.Id = Convert.ToInt32(reader["account_id"]);
            usr.Name = Convert.ToString(reader["account_name"]);
            usr.Password = "***********************";

            return usr;
        }
    }

    public class UserManager : BaseManager
    {
        private string key = "hjH&*Y&*TgfRTD$%%EETUYggdu573562..8**!$";
        private const string SALT = "..tyeh!$!$io0911$$$%^";
        private HMACSHA512 hmac_sha512;

        public UserManager(string connection_string)
            : base(connection_string)
        {
            hmac_sha512 = new HMACSHA512(ASCIIEncoding.ASCII.GetBytes(key).Take(128).ToArray());
        }

        public static User CurrentUser
        {
            get;
            set;
        }

        private string ByteToString(byte[] buff)
        {
            string sbinary = "";

            for (int i = 0; i < buff.Length; i++)
            {
                sbinary += buff[i].ToString("X2"); // hex format
            }
            return (sbinary);
        }

        private string GenerateHash(string s)
        {
            return
                ByteToString(
                    hmac_sha512.ComputeHash(
                        ASCIIEncoding.ASCII.GetBytes(s + SALT)
                    )
                );
        }

        public int IsValidUserCredentials(string username, string password)
        {
            password = GenerateHash(password);

            int id = -1;
            //create our login query here
            //parameters are used to prevent SQL injections
            string log_in_query = GradeManager_SQLite_DB_Controller.DBQ_GET_ACCOUNT_DETAILS_LOG_IN;

            //reading connection string from App.Config file
            using (var sql_connection = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(log_in_query, sql_connection))
            {

                //addding parameters here
                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@password", password);

                sql_connection.Open();

                //execute query
                SQLiteDataReader reader = command.ExecuteReader();

                //if rows are returned then the credentials exist
                if (reader.Read())
                    id = Int32.Parse(reader[0].ToString());
            }

            return id;
        }

        public int CreateUser(User usr)
        {
            int rows = 0;

            if (usr.isFilled())
            {

                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = "INSERT INTO Accounts (account_name, account_password, account_first_name, account_last_name) VALUES (@name, @password, @first, @last)";
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("name", usr.Name);
                        command.Parameters.AddWithValue("password", GenerateHash(usr.Password));
                        command.Parameters.AddWithValue("@first", usr.FirstName);
                        command.Parameters.AddWithValue("@last", usr.LastName);

                        connection.Open();

                        rows = command.ExecuteNonQuery();
                    }
                }
            }

            return rows;
        }

        public User GetUser(int id)
        {
            User usr = null;

            using (var connection = GradeManager_SQLite_DB_Controller.GetConnection())
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ACCOUNT_DETAILS_ID, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            usr = reader;
                    }
                }
            }

            return usr;
        }


    }
}
