using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;


namespace Grade_Manager
{
    /// <summary>
    /// Represents a Profile
    /// </summary>
    class ProfileData
    {
        public ProfileData() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public int SchoolYear { get; set; }
        public int Term { get; set; }
        public string Description { get; set; }

        public static bool operator ==(ProfileData a, ProfileData b)
        {
            return (a.OwnerId == b.OwnerId &&
                a.Name == b.Name &&
                a.SchoolYear == b.SchoolYear &&
                a.Term == b.Term &&
                a.Description == b.Description);
        }

        public static bool operator !=(ProfileData a, ProfileData b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Assign values from SqlCeDataReader directly to properties of ProfileData
        /// Please Note that the SqlCeDataReader.Read() method must be called externally
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator ProfileData(SqlCeDataReader reader)
        {
            ProfileData pd = new ProfileData();
            pd.Id = (int)reader["profile_id"];
            pd.SchoolYear = (int)reader["school_year"];
            pd.OwnerId = (int)reader["account_id"];
            pd.Term = (int)reader["current_term"];
            pd.Description = (string)reader["profile_description"];
            pd.Name = (string)reader["profile_name"];

            return pd;
        }
    }

    
    /// <summary>
    /// Manages Profiles
    /// Does communication with the database
    /// </summary>
    class ProfileManager : BaseManager
    {
        public ProfileManager(string connection_string)
            : base(connection_string)
        {

        }

        public ProfileData GetProfile(string name)
        {
            ProfileData db_profile = new ProfileData();

            //fetch profile according to profile_name
            using (SqlCeConnection connection = new SqlCeConnection(ConnectionString))
            using (SqlCeCommand command = new SqlCeCommand(Database_Constants.DBQ_GET_PROFILE_NAME, connection))
            {
                command.Parameters.AddWithValue("@name", name);

                connection.Open();
                //execute query
                SqlCeDataReader reader = command.ExecuteReader();

                //if rows are returned then the credentials exist
                if (reader.Read())
                {
                    db_profile = reader;
                }
            }

            return db_profile;
        }

        public bool CreateProfile(Profiles profile)
        {
            //value of ID not being passed
            bool result = false;
            GradeManager_EMO gm_emo = new GradeManager_EMO(ConnectionString);
            try
            {
                gm_emo.Profiles.InsertOnSubmit(profile);
                //gm_emo.Profiles.Su
            }
            catch (Exception e)
            {

            }
            /*try
            {
                profileListDataSourceTableAdapters.ProfilesTableAdapter profile_dset = new profileListDataSourceTableAdapters.ProfilesTableAdapter();
                if (profile_dset.Insert(
                        profile.SchoolYear,
                        profile.OwnerId,
                        profile.Term,
                        profile.Description,
                        profile.Name) > 0)
                    result = true;
                /*using (SqlCeConnection connection = new SqlCeConnection(ConnectionString))
                using (SqlCeCommand command = new SqlCeCommand(Database_Constants.DBQ_INSERT_PROFILE, connection))
                {
                    ///INSERT INTO [Profiles] VALUES (@schoolyear, @account_id, @term, @descrip, @name)
                    command.Parameters.Add("@schoolyear", System.Data.SqlDbType.Int).Value = profile.SchoolYear;
                    command.Parameters.Add("@account_id", System.Data.SqlDbType.Int).Value = profile.OwnerId;
                    command.Parameters.Add("@term", System.Data.SqlDbType.Int).Value = profile.Term;
                    command.Parameters.Add("@descrip", System.Data.SqlDbType.NChar).Value = profile.Description;
                    command.Parameters.Add("@name", System.Data.SqlDbType.NChar).Value = profile.Name;

                    connection.Open();

                    if ((command.ExecuteNonQuery()) > 0)
                        result = true;
                }
            }
            catch (Exception e)
            {
                
            }*/

            return result;
        }
        
    }
}
