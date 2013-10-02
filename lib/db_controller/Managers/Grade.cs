using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    class Grade
    {
        public string Letter { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }

    class Grade_Manager
    {
        private static List<Grade> grades = new List<Grade>();

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

            return grades.Where(x => x.Max >= grade && x.Min <= grade).Select(x => x.Letter).First();
        }
    }
}
