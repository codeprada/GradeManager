using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grade_Manager
{
    /// <summary>
    /// Holds all queries for the database in one location
    /// </summary>
    class Database_Constants
    {
        //Constants that hold the queries used around the application
        public const string DBQ_LOG_IN = "SELECT [account_id] FROM [Accounts] WHERE [account_name] = @name AND [account_password] = @password",
                            DBQ_GET_PROFILE_NAME = "SELECT * FROM [Profiles] WHERE [profile_name] = @name",
                            DBQ_GET_PROFILE_ID = "SELECT * FROM [Profiles] WHERE [profile_id] = @id",
                            DBQ_INSERT_PROFILE = "INSERT INTO [Profiles] (school_year, account_id, current_term, profile_description, profile_name) VALUES (@schoolyear, @account_id, @term, @descrip, @name)";

        public static string DB_CONNECTION_STRING = Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"), "\\Grade Manager\\", "gm_storage.db");

        private Database_Constants() { }

    }
}
