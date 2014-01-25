using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Grade_Manager_DB_Controller
{
    public class Subject : Database_Object
    {
        public Subject()
        {
            Weights = new WeightObjectList();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public WeightObjectList Weights
        {
            get;
            set;
        }

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
                    command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);
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

        public List<Subject> GetSubjects(Semester semester)
        {
            List<Subject> subjects = new List<Subject>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_SUBJECT_CURRENT_SEMESTER, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@class_id", semester.Class);
                    command.Parameters.AddWithValue("@semester_id", semester.Id);

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


        public void LoadToComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";

            foreach (Subject s in GetSubjects())
            {
                if (s.Id >= 0)
                    comboBox.Items.Add(new ComboItem() { Id = s.Id, Text = s.Name });
            }

        }

        public void LoadToComboBox(ComboBox comboBox, Semester semester)
        {
            comboBox.Items.Clear();

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";

            foreach (Subject s in GetSubjects(semester))
            {
                if(s.Id >= 0)
                    comboBox.Items.Add(new ComboItem() { Id = s.Id, Text = s.Name });
            }
        }

        

        public bool DeleteClassSubject(int subject, Semester semester)
        {
            bool ok = false;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_CLEAR_SUBJECT_ON_CLASS, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@semester_id", semester.Id);
                        command.Parameters.AddWithValue("@class_id", semester.Class);
                        command.Parameters.AddWithValue("@subject_id", subject);

                        connection.Open();
                        if (command.ExecuteNonQuery() > 0)
                            ok = true;
                    }
                }
            }
            catch (SQLiteException e)
            {
                ok = false;
            }
            catch (Exception)
            {

            }

            return ok;
        }

        public int CreateSubject(Subject subject)
        {
            return CreateSubject(subject.Name);
        }

        public int CreateSubject(string subject)
        {
            int row = -1;

            if (subject != String.Empty)
            {
                subject = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subject.ToLower());

                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_SUBJECT, connection))
                    {
                        command.Parameters.AddWithValue("@subject_name", subject);
                        command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);

                        connection.Open();
                        
                        if (command.ExecuteNonQuery() > 0)
                            row = Convert.ToInt32(GradeManager_SQLite_DB_Controller.GetLastRowInserted(connection));
                        
                    }
                }
            }
            

            return row;

        }

        public bool SaveOrUpdateSubjectClass(Subject subject, Semester semester)
        {
            bool eval = false;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_SUBJECT_ON_CLASS, connection))
                    {
                        command.CommandType = CommandType.Text;
                        
                        command.Parameters.AddWithValue("@subject_id", subject.Id);
                        command.Parameters.AddWithValue("@semester_id", semester.Id);
                        command.Parameters.AddWithValue("@class_id", semester.Class);

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
