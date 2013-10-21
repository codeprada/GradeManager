using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Drawing;

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

        private const int BUFFER_NUMBER = 6;

        public ReportsManager(string connection)
            : base(connection)
        {

        }

        public void GenerateReport(int semester_id, string saveas)
        {

            //Does all the calculations
            List<Reports> reports = FetchData(semester_id);

            using (var document_report = DocX.Create(saveas))
            {
                //Size of a legal size paper
                document_report.PageHeight = 1344.0f;
                document_report.PageWidth = 816.0f;

                foreach (var id in reports.Select(x => x._Student.ID).Distinct())
                {
                    var data = reports
                        .Where(x => x._Student.ID == id)
                        .Select(
                            x => x
                        )
                        .Distinct();

                    var g = reports
                        .Where(x => x._Student.ID == id)
                        .Distinct()
                        .Join(
                            reports,
                            x => x._Subject.Id,
                            y => y._Subject.Id,
                            (x, y) =>
                                new
                                {
                                    SubjectName = x._Subject.Name,
                                    Grade = Grade_Manager.GetLetter(x.Average)
                                })
                        .Distinct();

                    //HEADING
                    Formatting heading_format = new Formatting()
                    {
                        Bold = true,
                        FontFamily = new FontFamily("Century Schoolbook"),
                        Size = 36.0
                    };

                    Paragraph heading = document_report.InsertParagraph("ACADEMIC REPORT\n", false, heading_format);
                    heading.Alignment = Alignment.center;
                    heading.SpacingAfter(3.0);
                    heading.SpacingBefore(12.0);

                    Formatting times_new_roman_18 = new Formatting()
                    {
                        Bold = true,
                        FontFamily = new FontFamily("Times New Roman"),
                        Size = 18.0
                    };

                    Paragraph sub_heading = document_report.InsertParagraph("Baptist Academy of Antigua\n", false, times_new_roman_18);
                    sub_heading.Alignment = Alignment.center;
                    //sub_heading.SpacingAfter(3.0);
                    //sub_heading.SpacingBefore(12.0);
                    sub_heading.LineSpacingAfter = 3.0F;
                    sub_heading.LineSpacingBefore = 12.0F;
                    ///////////////////////////////////////

                    //Details
                    Formatting details_formatted = new Formatting()
                    {
                        Bold = true,
                        FontFamily = new FontFamily("Times New Roman"),
                        Size = 9.0
                    };
                    document_report.InsertParagraph("Dr. H.W.C. Jonas, B.A., M.A., D.P.Th., D.Min.\t\t\tTelephone\t(268) 462-2894", false, details_formatted);
                    document_report.InsertParagraph("Principal\t\t\t\t\t\t\tFacsimile\t(268) 462-6029", false, details_formatted);
                    document_report.InsertParagraph("P.O. Box 2678, Radio Range\t\t\t\tE-mail\t\tecbm@yahoo.com", false, details_formatted);
                    document_report.InsertParagraph("St. John’s, Antigua & Barbuda\t\t\t\tWebsite\t\twww.baptistantigua.org", false, details_formatted).SpacingAfter(25.0f);
                    ///////////////////////////////////////

                    Formatting line_format = new Formatting()
                    {
                        Bold = true,
                        UnderlineStyle = UnderlineStyle.singleLine,
                        FontFamily = new FontFamily("Times New Roman"),
                        Size = 12.0
                    };

                    Formatting line_format_nu = new Formatting()
                    {
                        Bold = true,
                        FontFamily = new FontFamily("Times New Roman"),
                        Size = 12.0
                    };

                    string line = "___________________________________________________________________________";

                    document_report.InsertParagraph(line, false, line_format);

                    Formatting student_details = new Formatting()
                    {
                        Bold = true,
                        FontFamily = new FontFamily("Times New Roman"),
                        Size = 11.0
                    };

                    string name = ("STUDENT: " + data.Select(x => x._Student.LastName).First() + ", " + data.Select(x => x._Student.FirstName).First()).ToUpper();
                    name = ApplyBuffer(name, BUFFER_NUMBER);
                    string class_name = "CLASS: " + data.Select(x => x._Class.Name).First().ToUpper();
                    //class_name = ApplyBuffer(class_name, BUFFER_NUMBER);

                    document_report.InsertParagraph(String.Format("{0}{1}{2}", name, new String('\t', CalculateTabs(name, 7)), class_name), false, student_details);

                    string dob = ("DATE OF BIRTH: " + data.Select(x => x._Student.DateOfBirth.ToString("d, MMM., yyyy")).First()).ToUpper();
                    //dob = ApplyBuffer(dob, BUFFER_NUMBER + 1);
                    string semester = "SEMESTER: " + data.Select(x => x._Semester.Term).First().ToString().ToUpper();
                    //semester = ApplyBuffer(semester, BUFFER_NUMBER);

                    document_report.InsertParagraph(String.Format("{0}{1}{2}", dob, new String('\t', CalculateTabs(dob, 7)), semester), false, student_details);

                    string year = "YEAR: " + data.Select(x => x._Semester.StartingSchoolYear.ToString() + "/" + x._Semester.EndingSchoolYear.ToString()).First().ToString().ToUpper();
                    //year = ApplyBuffer(year, BUFFER_NUMBER + 1);
                    string attendance = "LATE: 0\tABSENCE: 0\n";
                    //attendance = ApplyBuffer(attendance, BUFFER_NUMBER);

                    document_report.InsertParagraph(String.Format("{0}{1}{2}", year, new String('\t', CalculateTabs(year, 7)), attendance), false, student_details);

                    Formatting underlined_heading = new Formatting()
                    {
                        Size = 10,
                        FontFamily = new FontFamily("Times New Roman"),
                        UnderlineStyle = UnderlineStyle.singleLine,
                        Bold = true
                    };

                    document_report.InsertParagraph("GRADING KEY", false, underlined_heading);

                    Formatting grade_legend = new Formatting()
                    {
                        Bold = true,
                        FontFamily = new FontFamily("Times New Roman"),
                        Size = 10.0
                    };

                    document_report.InsertParagraph("A+ 100\t\tB 89-85\t\tC 79-75\t\tD 69-65\t\tE 59-55\t\tF 49-0", false, grade_legend);
                    document_report.InsertParagraph("A 99-95\t\tB- 84-80\t\tC- 74-70\tD- 64-60\tE- 54-50", false, grade_legend);
                    document_report.InsertParagraph("A- 94-90", false, grade_legend);

                    document_report.InsertParagraph(line, false, line_format);
                    document_report.InsertParagraph("SUBJECT\t\t\t\t\t\t\t\t\tGRADE", false, new Formatting() { Size = 12, FontFamily = new FontFamily("Times New Roman"), Bold = true });
                    document_report.InsertParagraph(line, false, line_format);

                    int count = 1;
                    string buffer;
                    var last = g.Last();
                    foreach (var g_pair in g)
                    {
                        buffer = ("     " + count++ + ". " + g_pair.SubjectName).ToUpper();
                        buffer = ApplyBuffer(buffer, BUFFER_NUMBER);

                        document_report.InsertParagraph(String.Format("{0}{1}{2}", buffer, new String('\t', CalculateTabs(buffer, 11)), g_pair.Grade), false, grade_legend);
                        document_report.InsertParagraph(line, false, (g_pair.SubjectName != last.SubjectName ? line_format_nu : line_format));
                    }

                    document_report.InsertParagraph("GENERAL REMARKS:", false, new Formatting() { Size = 12, FontFamily = new FontFamily("Times New Roman"), Bold = true });
                    document_report.InsertParagraph("\n\n", false, new Formatting() { Size = 12, FontFamily = new FontFamily("Times New Roman") });

                    Novacode.Image img = document_report.AddImage("baptistacademylogo.png");

                    Picture pic = img.CreatePicture();
                    pic.Height = (int)(pic.Height * .7);
                    pic.Width = (int)(pic.Width * .66);

                    document_report.InsertParagraph("________________________\nTEACHER\n\t\t\t\t\t\t\t\t", false, new Formatting() { Size = 12, FontFamily = new FontFamily("Times New Roman"), Bold = true })
                        .AppendPicture(pic);

                    document_report.InsertParagraph("________________________\nADMINISTRATOR", false, new Formatting() { Size = 12, FontFamily = new FontFamily("Times New Roman"), Bold = true });

                    document_report.InsertSectionPageBreak();
                }

                document_report.AddFooters();
                Paragraph footer = document_report.Footers.odd.InsertParagraph();

                footer.Append("“Academic Excellence with Biblical Values”")
                    .Bold()
                    .FontSize(14.0)
                    .Font(new FontFamily("Times New Roman"))
                    .Alignment = Alignment.center;

                document_report.Footers.odd.Paragraphs.Add(footer);

                document_report.PageHeight = 1344.0f;
                document_report.PageWidth = 816.0f;
                
                

                document_report.Save();
            }

        }

        private int CalculateTabs(string text, int tabs, int space_per_tab = BUFFER_NUMBER)
        {
            int remaining_space = ((tabs * space_per_tab) - text.Length);
            int tabs_count = (int)((remaining_space / space_per_tab) + ((remaining_space % space_per_tab) > 0 ? 1 : 0));

            return tabs_count;
        }

        private string ApplyBuffer(string s, int n)
        {
            return s += new String(' ', s.Length % n);
        }

        public List<Reports> FetchData(int semester_id)
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
