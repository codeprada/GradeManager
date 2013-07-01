using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Data;
using System.Data.SQLite;


namespace Grade_Manager_DB_Controller
{
    public class Profile
    {
        public Profile()
        {

        }
    }


    /// <summary>
    /// Represents a Profile
    /// </summary>
    public class ProfileData
    {
        public ProfileData() { }

        public int Id { get; set; }
        public int Class { get; set; }
        public int OwnerId { get; set; }
        public int StartingSchoolYear { get; set; }
        public int EndingSchoolYear { get; set; }
        public int Term { get; set; }
        public string Description { get; set; }

        public static bool operator ==(ProfileData a, ProfileData b)
        {
            return (a.OwnerId == b.OwnerId &&
                a.Class == b.Class &&
                a.StartingSchoolYear == b.StartingSchoolYear &&
                a.EndingSchoolYear == b.EndingSchoolYear &&
                a.Term == b.Term &&
                a.Description == b.Description);
        }

        public static bool operator !=(ProfileData a, ProfileData b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Assign values from SqlCeDataReader directly to properties of ProfileData
        /// Please Note that the SqlCeDataReader.Read() method must be called externally
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator ProfileData(SQLiteDataReader reader)
        {
            ProfileData pd = new ProfileData();
            pd.Id = (int)reader["profile_id"];
            pd.StartingSchoolYear = (int)reader["starting_school_year"];
            pd.EndingSchoolYear = (int)reader["ending_school_year"];
            pd.OwnerId = (int)reader["account_id"];
            pd.Term = (int)reader["current_term"];
            pd.Description = (string)reader["profile_description"];
            pd.Class = (int)reader["class_id"];

            return pd;
        }
    }

    
    /// <summary>
    /// Manages Profiles
    /// Does communication with the database
    /// </summary>
    public class ProfileManager : BaseManager
    {
        public ProfileManager(string connection_string)
            : base(connection_string)
        {

        }

        public ProfileData GetProfile(string name)
        {
            ProfileData db_profile = new ProfileData();

            //fetch profile according to profile_name
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_PROFILE_NAME, connection))
            {
                command.Parameters.AddWithValue("@name", name);

                connection.Open();
                //execute query
                SQLiteDataReader reader = command.ExecuteReader();

                //if rows are returned then the credentials exist
                if (reader.Read())
                {
                    db_profile = reader;
                }
            }

            return db_profile;
        }

        public bool CreateProfile(ProfileData profile)
        {
            //value of ID not being passed
            bool result = false;
            
            try
            {

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_PROFILE, connection))
                {
                    ///INSERT INTO [Profiles] VALUES (@endingschoolyear, @startingschoolyear, @account_id, @term, @descrip, @name)
                    command.Parameters.AddWithValue("@startingschoolyear", profile.StartingSchoolYear);
                    command.Parameters.AddWithValue("@endingschoolyear", profile.EndingSchoolYear);
                    command.Parameters.AddWithValue("@account_id", profile.OwnerId);
                    command.Parameters.AddWithValue("@term", profile.Term);
                    command.Parameters.AddWithValue("@descrip", profile.Description);
                    command.Parameters.AddWithValue("@class", profile.Class);

                    connection.Open();

                    if ((command.ExecuteNonQuery()) > 0)
                        result = true;
                }
            }
            catch (Exception)
            {
                
            }

            return result;
        }
        
    }
}
