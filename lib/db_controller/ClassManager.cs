using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Grade_Manager_DB_Controller
{
    public class Class : Database_Object
    {
        public Class() : base() { }

        public int Id { get; set; }
        public string Name { get; set; }

        public static implicit operator Class(SQLiteDataReader reader)
        {
            Class c = new Class();

            c.Id = Convert.ToInt32(reader["class_id"]);
            c.Name = Convert.ToString(reader["class_name"]);

            return c;
        }
    }

    public class ClassManager : BaseManager
    {
        public ClassManager(string connection_string)
            : base(connection_string)
        {

        }

        public List<Class> GetAllClasses()
        {
            List<Class> classes = new List<Class>();

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_CLASSES;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(reader);
                        }
                    }
                }
            }

            return classes;
        }

        public void LoadToComboBox(ComboBox comboBox)
        {
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";

            

            foreach (Class c in GetAllClasses())
                comboBox.Items.Add(new ComboItem() { Text = c.Name, Id = c.Id });
        }
    }
}
