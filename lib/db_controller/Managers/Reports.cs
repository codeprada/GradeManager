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
        public Subject _Subject { get; set; }
        public Class _Class { get; set; }
        public double Average { get; set; }

        public static implicit operator Reports(SQLiteDataReader reader)
        {
            Reports report = new Reports()
            {
                _Assessment = reader,
                _Semester = reader,
                _Student = reader,
                _Subject = reader,
                _Class = reader,
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

        public void GenerateReport(string template, int semester_id, string saveas)
        {
            //Dictionary<string, char> grades = new Dictionary<string, char>();

            List<Reports> reports = FetchData(semester_id);   

            using (var document_report = DocX.Create(saveas))
            {

                foreach (var id in reports.Select(x => x._Student.ID))
                {
                    var data = reports
                        .Where(x => x._Student.ID == id)
                        .Select(
                            x => x
                        )
                        .Distinct();

                    var g = reports
                        .Where(x => x._Student.ID == id)
                        .Join(
                            reports,
                            x => x._Subject.Id,
                            y => y._Subject.Id,
                            (x, y) =>
                                new
                                {
                                    SubjectName = x._Subject.Name,
                                    Average = x.Average
                                })
                        .Distinct();




                    using (var document_template = DocX.Load(template))
                    {
                        document_template.ReplaceText("[LNAME]", data.Select(x => x._Student.LastName).First());
                        document_template.ReplaceText("[FNAME]", data.Select(x => x._Student.FirstName).First());
                        document_template.ReplaceText("[CLASS]", data.Select(x => x._Class.Name).First());
                        document_template.ReplaceText("[DOB]", data.Select(x => x._Student.DateOfBirth.ToString()).First());
                        document_template.ReplaceText("[YEAR]", data.Select(x => x._Semester.StartingSchoolYear.ToString() + "/" + x._Semester.EndingSchoolYear.ToString()).First());
                        document_template.ReplaceText("[SEMESTER]", data.Select(x => x._Semester.Term.ToString()).First());

                        string buffer, grade_text = String.Empty;
                        int count = 1, space_length;

                        //Indent: 4 spaces
                        //Tab: 14 spaces
                        //Tabs From Start: 10
                        string results = document_template.FindUniqueByPattern(@"\[SUBJECT\].+\[GRADE\]", System.Text.RegularExpressions.RegexOptions.Multiline)[0];
                        int length = results.Replace("[GRADE]", String.Empty).Length;

                        foreach (var gr in g)
                        {
                            buffer = String.Format("      {0}. {1}", count++, gr.SubjectName);
                            space_length = (length - buffer.Length);
                            buffer += String.Format("{0}{1}", new String(' ', space_length), gr.Average);

                            grade_text += buffer + Environment.NewLine + new String('_', 93) + Environment.NewLine;
                        }

                        document_template.ReplaceText("[GRADE]", String.Empty);
                        document_template.ReplaceText("[SUBJECT]", grade_text);

                        document_report.InsertSectionPageBreak();
                        document_report.InsertDocument(document_template);
                    }
                }
                document_report.Save();
            }
            
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
                        {
                            reports.Add(reader);
                        }
                    }
                }
            }


            return reports;
        }
    }
}
