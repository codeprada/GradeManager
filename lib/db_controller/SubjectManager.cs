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
    }

    public class SubjectManager : BaseManager
    {
        public SubjectManager(string connection_string)
            : base(connection_string)
        {

        }

        public List<Subject> GetAllSubjects()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_SUBJECTS, connection))
                {

                }
            }
        }
        
    }
}
