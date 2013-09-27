using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class StatisticsDataObject
    {
        public string Name { get; private set; }
        public Dictionary<string, double> Assessments { get; private set; }

        public StatisticsDataObject(string name)
        {
            Assessments = new Dictionary<string, double>();
            Name = name;
        }

        public void Append(DataTable dt)
        {
            foreach (DataColumn dc in dt.Columns)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Assessments.Add(dc.ColumnName, Convert.ToDouble(dr[dc]));
                }
            }
        }

        public void Append(string name, object value)
        {
            Assessments.Add(name, Convert.ToDouble(value));
        }
    }

    public class StatsManager : BaseManager
    {
        public StatsManager(string connection_string)
            : base(connection_string)
        {

        }

        public StatisticsDataObject Get(int student_id, int subject_id, int assess_type)
        {
            StatisticsDataObject sdo;
            Student student = new StudentManager(ConnectionString).Get(student_id);

            sdo = new StatisticsDataObject(student.FirstName + " " + student.LastName);

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_STATS, connection))
                {
                    command.Parameters.AddWithValue("@student_id", student_id);
                    command.Parameters.AddWithValue("@subject_id", subject_id);
                    command.Parameters.AddWithValue("@assess_type_id", assess_type);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sdo.Append(reader["Name"].ToString(), reader["Grade"]);
                        }
                    }

                }
            }

            return sdo;
        }
    }
}
