using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SQLite;

namespace Grade_Manager
{
    class UserManager : BaseManager
    {
        public UserManager(string connection_string) : base(connection_string)
        {
            
        }

        public static User CurrentUser
        {
            get;
            set;
        }

        public int IsValidUserCredentials(string username, string password)
        {
            

            /*int id = -1;
            //create our login query here
            //parameters are used to prevent SQL injections
            string log_in_query = Database_Constants.DBQ_LOG_IN;

            //reading connection string from App.Config file
            using (var sql_connection = new SqlCeConnection(ConnectionString))
            using (var command = new SqlCeCommand(log_in_query, sql_connection))
            {

                //addding parameters here
                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@password", password);

                sql_connection.Open();

                //execute query
                SqlCeDataReader reader = command.ExecuteReader();

                //if rows are returned then the credentials exist
                if (reader.Read())
                    id = (int)reader[0];
            }

            return id;*/
        } 
    }
}
