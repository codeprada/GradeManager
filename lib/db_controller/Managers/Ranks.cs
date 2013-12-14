using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class Rank_Item
    {
        public string StuName { get; set; }
        public double Average { get; set; }

        public static implicit operator Rank_Item(SQLiteDataReader reader)
        {
            Rank_Item ri = new Rank_Item();
            ri.StuName = Convert.ToString(reader["student_first_name"]) + " " + Convert.ToString(reader["student_last_name"]);

            try
            {
                ri.Average = Convert.ToDouble(reader["overall"]);
            }
            catch(Exception e)
            {
                ri.Average = 0.0;
            }

            return ri;
        }
    }

    public class Ranks_Manager : BaseManager
    {
        private WeightManager weight_manager;
        private SubjectWeightObjectList swobl;
        private StudentManager student_manager;

        public Ranks_Manager(string connection_string)
            : base(connection_string)
        {
            weight_manager = new WeightManager(connection_string, UserManager.CurrentUser.Id);
            weight_manager.CalculateWeighting();
            swobl = weight_manager.SubjectWeightObjList;
            student_manager = new StudentManager(connection_string);
        }

        public List<Rank_Item> GetRankings(int subject_id = -1)
        {
            List<Rank_Item> rank_items = new List<Rank_Item>();

            StudentSubjectGradeObjectListManager ssgolm = new StudentSubjectGradeObjectListManager(ConnectionString);

            foreach (Student student in student_manager.Get())
            {
                Dictionary<int, double> grade = ssgolm.CalculateOverallAverage(student.ID, swobl, subject_id);
                foreach (KeyValuePair<int, double> kv in grade)
                {
                    Rank_Item r = new Rank_Item();
                    r.StuName = student.ToString();
                    r.Average = kv.Value;

                    rank_items.Add(r);
                }
            }












            //string query = String.Format(GradeManager_SQLite_DB_Controller.DBQ_GET_RANKINGS, (subject_id > -1 ? " AND SJ.subject_id = @subject_id " : ""));

            /*using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    if (subject_id > -1)
                        command.Parameters.AddWithValue("subject_id", subject_id);
                    command.Parameters.AddWithValue("semester_id", SemesterManager.CurrentSemester.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                            rank_items.Add(reader);
                    }
                }
            }*/

            return rank_items;
        }

    }
}
