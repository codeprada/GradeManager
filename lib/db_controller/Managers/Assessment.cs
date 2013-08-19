using System;
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
                    command.Parameters.AddWithValue("@semester_id", ProfileManager.CurrentProfile.Id);
                    command.Parameters.AddWithValue("@date", a.Date);
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
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
