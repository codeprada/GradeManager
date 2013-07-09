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

    /// <summary>
    /// Represents a Profile
    /// </summary>
    public class Profile
    {
        public Profile() { }

        public int Id { get; set; }
        public int Class { get; set; }
        public int OwnerId { get; set; }
        public int StartingSchoolYear { get; set; }
        public int EndingSchoolYear { get; set; }
        public int Term { get; set; }
        public string Description { get; set; }

        public static bool operator ==(Profile a, Profile b)
        {
            //Checking for NULL types here
            if (object.ReferenceEquals(null, a) && object.ReferenceEquals(null, b))
                return true;
            if ((object.ReferenceEquals(null, a) && !object.ReferenceEquals(null, b)) ||
                (object.ReferenceEquals(null, b) && !object.ReferenceEquals(null, a)))
                return false;

            
            return (a.OwnerId == b.OwnerId &&
                a.Class == b.Class &&
                a.StartingSchoolYear == b.StartingSchoolYear &&
                a.EndingSchoolYear == b.EndingSchoolYear &&
                a.Term == b.Term &&
                a.Description == b.Description);
            
        }

        public static bool operator !=(Profile a, Profile b)
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
        /// Assign values from SqlCeDataReader directly to properties of Profile
        /// Please Note that the SqlCeDataReader.Read() method must be called externally
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator Profile(SQLiteDataReader reader)
        {
            Profile pd = new Profile();
            pd.Id = Convert.ToInt32(reader["profile_id"]);
            pd.StartingSchoolYear = Convert.ToInt32(reader["starting_school_year"]);
            pd.EndingSchoolYear = Convert.ToInt32(reader["ending_school_year"]);
            pd.OwnerId = Convert.ToInt32(reader["account_id"]);
            pd.Term = Convert.ToInt32(reader["current_term"]);
            pd.Description = (string)reader["profile_description"];
            pd.Class = Convert.ToInt32(reader["class_id"]);

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

        public static Profile CurrentProfile
        {
            get;
            set;
        }

        public Profile GetProfile(int id)
        {
            Profile db_profile = new Profile();

            //fetch profile according to profile_name
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_PROFILE, connection))
            {
                command.Parameters.AddWithValue("@id", id);

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

        public bool CreateProfile(Profile profile)
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
