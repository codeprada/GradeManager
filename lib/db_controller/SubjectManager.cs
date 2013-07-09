using System;
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
    public class Subject : Database_Object
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static implicit operator Subject(SQLiteDataReader reader)
        {
            Subject subject = new Subject();

            subject.Id = Convert.ToInt32(reader["subject_id"]);
            subject.Name = Convert.ToString(reader["subject_name"]);

            return subject;
        }
    }

    public class SubjectManager : BaseManager
    {
        public SubjectManager(string connection_string)
            : base(connection_string)
        {

        }

        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_SUBJECTS, connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //implicit operator does the conversion
                        subjects.Add(reader);
                    }
                }
            }

            return subjects;
        }

        public List<Subject> GetSubjects(int class_id)
        {
            List<Subject> subjects = new List<Subject>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_SUBJECT_WHERE, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@class_id", class_id);
                    command.Parameters.AddWithValue("@profile_id", ProfileManager.CurrentProfile.Id);

                    connection.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //implicit operator does the conversion
                        subjects.Add(reader);
                    }
                }
            }

            return subjects;
        }

        public void ClearClassSubjects(int class_id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_CLEAR_SUBJECTS_ON_CLASS, connection))
                    {
                        command.CommandType = CommandType.Text;
                        //DELETE FROM [SubjectProfile] WHERE [profile_id] = @profile_id
                        command.Parameters.AddWithValue("@profile_id", ProfileManager.CurrentProfile.Id);
                        command.Parameters.AddWithValue("@class_id", class_id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public bool SaveSubjectToClass(Subject subject, int class_id)
        {
            bool eval = false;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_SUBJECT_ON_CLASS, connection))
                    {
                        command.CommandType = CommandType.Text;
                        //INSERT INTO [SubjectProfile] ([subject_id], [class_id]) VALUES (@subject_id, @class_id)
                        command.Parameters.AddWithValue("@subject_id", subject.Id);
                        command.Parameters.AddWithValue("@profile_id", ProfileManager.CurrentProfile.Id);
                        command.Parameters.AddWithValue("@class_id", class_id);

                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                            eval = true;
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return eval;

        }
        
    }
}
