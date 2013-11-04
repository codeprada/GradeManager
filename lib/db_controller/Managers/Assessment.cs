﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Grade_Manager_DB_Controller
{
    public enum DB_Object { TYPE };

    public class Assessment : Database_Object
    {
        public Assessment()
            : base()
        {

        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; } //Date Test Was Taken
        public int Type { get; set; }
        public int Subject { get; set; }

        public static implicit operator Assessment(SQLiteDataReader reader)
        {
            Assessment a = new Assessment();

            a.ID = Convert.ToInt32(reader["assess_id"]);
            a.Name = Convert.ToString(reader["assess_name"]);
            a.Subject = Convert.ToInt32(reader["subject_id"]);
            a.Date = Convert.ToString(reader["assess_date"]);
            a.Type = Convert.ToInt32(reader["assess_type_id"]);
            a.Subject = Convert.ToInt32(reader["subject_id"]);

            return a;
        }
    }

    public class Assessment_Type : Database_Object
    {
        public Assessment_Type()
            : base()
        {

        }

        public int ID { get; set; }
        public string Name { get; set; }

        public static implicit operator Assessment_Type(SQLiteDataReader reader)
        {
            Assessment_Type a_type = new Assessment_Type();

            a_type.ID = Convert.ToInt32(reader["assess_type_id"]);
            a_type.Name = Convert.ToString(reader["assess_type"]);

            return a_type;
        }
    }

    public class Assessment_Manager : BaseManager
    {
        public Assessment_Manager(string connection_string) : base(connection_string)
        {

        }

        public void Save(Assessment a)
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_ASSESSMENT, connection))
                {
                    command.Parameters.AddWithValue("@assess_type_id", a.Type);
                    command.Parameters.AddWithValue("@subject_id", a.Subject);
                    command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);
                    command.Parameters.AddWithValue("@date", a.Date);
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Save(List<Assessment> l)
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_ASSESSMENT, connection))
                {
                    connection.Open();

                    foreach (Assessment a in l)
                    {
                        command.Parameters.AddWithValue("@assess_type_id", a.Type);
                        command.Parameters.AddWithValue("@subject_id", a.Subject);
                        command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);
                        command.Parameters.AddWithValue("@date", a.Date);


                        command.ExecuteNonQuery();
                    }
                }
            }  
        }

        public List<Assessment> GetAssessments()
        {
            List<Assessment> assessments = new List<Assessment>();

            using (var connection = GradeManager_SQLite_DB_Controller.GetConnection())
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENTS, connection))
                {
                    command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                            assessments.Add(reader);
                    }
                }
            }

            return assessments;
        }

        public List<object> GetAssessments(int subject_id, int assess_type, string from, string to)
        {
            bool subject = (subject_id > -1),
                assess = (assess_type > -1),
                date = (from != null && to != null && from != String.Empty && to != String.Empty);

            string query = GetAssessmentQuery(
                subject,
                assess,
                date
            );

            List<object> results = new List<object>();

            using (var connection = GradeManager_SQLite_DB_Controller.GetConnection())
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);

                    if (subject)
                        command.Parameters.AddWithValue("@subject_id", subject_id);
                    if (assess)
                        command.Parameters.AddWithValue("@assess_type", assess_type);
                    if (date)
                    {
                        command.Parameters.AddWithValue("@from", from);
                        command.Parameters.AddWithValue("@to", to);
                    }


                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                            results.Add( //"ID", "Date", "Name", "Subject", "Class", "Semester"
                                new
                                {
                                    ID = reader["ID"],
                                    Date = reader["Date"],
                                    Name = reader["Name"],
                                    Subject = reader["Subject"],
                                    Class = reader["Class"],
                                    Semester = reader["Semester"]
                                }
                            );
                    }
                }
            }

            return results;
        }

        

        private string GetAssessmentQuery(bool subject_id, bool assess_type, bool date)
        {

            string subject_query = " AND [A].subject_id = @subject_id ",
                   assess_type_query = " AND [A].assess_type_id = @assess_type ",
                   date_range = " AND [A].assess_date BETWEEN @from AND @to ",
                   query = String.Empty;

            if (subject_id)
                query += subject_query;

            if (assess_type)
                query += assess_type_query;

            //if(from != null && to != null && from != String.Empty && to != String.Empty)
            if (date)
                query += date_range;


            return String.Format("SELECT *, assess_id ID, assess_date [Date], assess_name [Name], subject_name [Subject], class_name [Class], current_term [Semester] FROM [Assessments] A INNER JOIN [Subjects] S ON A.subject_id = S.subject_id INNER JOIN [Semester] P ON p.semester_id = A.semester_id INNER JOIN [Classes] C ON P.class_id = C.class_id INNER JOIN [Assessment_Type] AT ON a.assess_type_id = AT.assess_type_id WHERE A.semester_id = @semester_id {0} ORDER BY starting_school_year, Semester, Date", query);
        }

        public Assessment GetAssessments(int id)
        {
            Assessment assessment = null;

            using (var connection = GradeManager_SQLite_DB_Controller.GetConnection())
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENTS_WHERE, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@assess_id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            assessment = reader;
                    }
                }
            }

            return assessment;
        }

        public List<Assessment_Type> GetTypes()
        {
            List<Assessment_Type> types = new List<Assessment_Type>();

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENT_TYPE, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            types.Add(reader);
                        }
                    }
                }
            }

            return types;
        }



        public void LoadToComboBox(ComboBox comboBox, DB_Object db_obj)
        {
            comboBox.Items.Clear();

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";

            if (db_obj == DB_Object.TYPE)
            {
                foreach (Assessment_Type type in GetTypes())
                    comboBox.Items.Add(new ComboItem() { Id = type.ID, Text = type.Name }); 
            }
        }
    }
}
