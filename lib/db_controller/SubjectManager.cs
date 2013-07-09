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
    public class Subject
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

        public List<Subject> GetAllSubjects()
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
        
    }
}
