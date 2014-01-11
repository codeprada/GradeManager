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
    /// Represents a Semester
    /// </summary>
    public class Semester : Database_Object
    {
        public Semester() { }

        public int Id { get; set; }
        public int Class { get; set; }
        public int OwnerId { get; set; }
        public int StartingSchoolYear { get; set; }
        public int EndingSchoolYear { get; set; }
        public int Term { get; set; }
        public string Description { get; set; }

        public static bool operator ==(Semester a, Semester b)
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

        public static bool operator !=(Semester a, Semester b)
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
        /// Assign values from SqlCeDataReader directly to properties of Semester
        /// Please Note that the SqlCeDataReader.Read() method must be called externally
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator Semester(SQLiteDataReader reader)
        {
            Semester sm = new Semester();
            sm.Id = Convert.ToInt32(reader["semester_id"]);
            sm.StartingSchoolYear = Convert.ToInt32(reader["starting_school_year"]);
            sm.EndingSchoolYear = Convert.ToInt32(reader["ending_school_year"]);
            sm.OwnerId = Convert.ToInt32(reader["account_id"]);
            sm.Term = Convert.ToInt32(reader["current_term"]);
            sm.Description = (reader["semester_description"] == null ? "" : Convert.ToString(reader["semester_description"]));
            sm.Class = Convert.ToInt32(reader["class_id"]);

            return sm;
        }
    }

    
    /// <summary>
    /// Manages Semesters
    /// Does communication with the database
    /// </summary>
    public class SemesterManager : BaseManager
    {

        public SemesterManager(string connection_string)
            : base(connection_string)
        {

        }

        public static Semester CurrentSemester
        {
            get;
            set;
        }

        public Semester GetSemester(int id)
        {
            Semester db_semester = new Semester();

            //fetch semester according to profile_name
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_SEMESTER, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                //execute query
                SQLiteDataReader reader = command.ExecuteReader();

                //if rows are returned then the credentials exist
                if (reader.Read())
                {
                    db_semester = reader;
                }
            }

            return db_semester;
        }

        public bool CreateSemester(Semester semester)
        {
            //value of ID not being passed
            bool result = false;
            
            try
            {

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_SEMESTER, connection))
                {
                    ///INSERT INTO [Profiles] VALUES (@endingschoolyear, @startingschoolyear, @account_id, @term, @descrip, @name)
                    command.Parameters.AddWithValue("@startingschoolyear", semester.StartingSchoolYear);
                    command.Parameters.AddWithValue("@endingschoolyear", semester.EndingSchoolYear);
                    command.Parameters.AddWithValue("@account_id", semester.OwnerId);
                    command.Parameters.AddWithValue("@term", semester.Term);
                    command.Parameters.AddWithValue("@descrip", semester.Description);
                    command.Parameters.AddWithValue("@class", semester.Class);

                    connection.Open();

                    if ((command.ExecuteNonQuery()) > 0)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return result;
        }

        public bool DeleteSemester(Semester semester)
        {
            return DeleteSemester(semester.Id, semester.OwnerId);   
        }

        public bool DeleteSemester(int semester, int account)
        {
            bool result = false;

            try
            {
                using (SQLiteConnection connection = GradeManager_SQLite_DB_Controller.GetConnection())
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_DELETE_SEMESTER, connection))
                {
                    command.Parameters.AddWithValue("@semester_id", semester);
                    command.Parameters.AddWithValue("@account_id", account);

                    connection.Open();

                    if ((command.ExecuteNonQuery()) > 0)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception)
            {

            }

            return result;
        }
        
    }
}
