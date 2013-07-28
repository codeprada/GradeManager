using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{

    public class User : Database_Object
    {
        public User() : base() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Profile { get; set; }

        public static implicit operator int(User usr)
        {
            return usr.Id;
        }
    }

    public class UserManager : BaseManager
    {
        public UserManager(string connection_string)
            : base(connection_string)
        {

        }

        public static User CurrentUser
        {
            get;
            set;
        }

        public int IsValidUserCredentials(string username, string password)
        {


            int id = -1;
            //create our login query here
            //parameters are used to prevent SQL injections
            string log_in_query = GradeManager_SQLite_DB_Controller.DBQ_LOG_IN;

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
                        command.CommandText = "INSERT INTO Accounts (account_name, account_password) VALUES (@name, @password)";
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("name", usr.Name);
                        command.Parameters.AddWithValue("password", usr.Password);

                        connection.Open();

                        rows = command.ExecuteNonQuery();
                    }
                }
            }

            return rows;
        }


    }
}
