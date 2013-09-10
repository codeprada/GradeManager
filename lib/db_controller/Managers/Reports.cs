using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

using Novacode;

namespace Grade_Manager_DB_Controller
{

    public class Reports : Database_Object
    {
        public Student _Student { get; set; }
        public Assessment _Assessment { get; set; }
        public Semester _Semester { get; set; }
        public double Average { get; set; }

        public static implicit operator Reports(SQLiteDataReader reader)
        {
            Reports report = new Reports()
            {
                _Assessment = reader,
                _Semester = reader,
                _Student = reader,
                Average = Convert.ToDouble(reader["average"])
            };

            return report;
        }
    }

    public class ReportsManager : BaseManager
    {
        public enum REPORT_TYPE { DOCUMENT, CHART }

        public ReportsManager(string connection)
            : base(connection)
        {

        }

        public DocX GenerateReport(string template, int semester_id, string saveas)
        {
            DocX doc = null;

            using (doc = DocX.Load(template))
            using (DocX save = DocX.Create(saveas))
            {
                doc.G
            }
                
            



            return doc;
        }

        public string GenerateReport(string template, int semester_id)
        {
            return String.Empty;
        }

        private List<Reports> FetchData(int semester_id)
        {
            List<Reports> reports = new List<Reports>();

            using (var connection = GradeManager_SQLite_DB_Controller.GetConnection())
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GENERATE_REPORT, connection))
                {
                    command.Parameters.AddWithValue("@semester_id", semester_id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            reports.Add(reader);
                    }
                }
            }


            return reports;
        }
    }
}
