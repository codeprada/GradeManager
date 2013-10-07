using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class Grade
    {
        public string Letter { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public class Grade_Manager : BaseManager
    {
        private static List<Grade> grades = new List<Grade>();

        public Grade_Manager(string connection_string) : base(connection_string)
        {

        }

        private static void SetLetters()
        {
            grades.Add(
                new Grade()
                {
                    Letter = "A+",
                    Max = 100,
                    Min = 100
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "A",
                    Max = 99,
                    Min = 95
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "A-",
                    Max = 94,
                    Min = 90
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "B",
                    Max = 89,
                    Min = 85
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "B-",
                    Max = 84,
                    Min = 80
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "C",
                    Max = 79,
                    Min = 75
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "C-",
                    Max = 74,
                    Min = 70
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "D",
                    Max = 69,
                    Min = 65
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "D-",
                    Max = 64,
                    Min = 60
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "E",
                    Max = 59,
                    Min = 55
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "E-",
                    Max = 54,
                    Min = 50
                }
            );
            grades.Add(
                new Grade()
                {
                    Letter = "F",
                    Max = 49,
                    Min = 0
                }
            );
        }

        public static string GetLetter(double grade)
        {
            if (grades.Count == 0)
                SetLetters();
            grade = Math.Round(grade);

            return grades.Where(x => x.Max >= grade && x.Min <= grade).Select(x => x.Letter).First();
        }

        public void Save(int student, int assessment, double grade)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_GRADE, connection))
                {
                    connection.Open();


                    
                    command.Parameters.AddWithValue("@student_id", student);
                    command.Parameters.AddWithValue("@assess_id", assessment);
                    command.Parameters.AddWithValue("@grade", grade);

                    command.ExecuteNonQuery();
                    
                }
            }
        }
    }
}
