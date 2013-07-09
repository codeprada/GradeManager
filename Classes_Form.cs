using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public partial class Classes_Form : Form
    {
        public Classes_Form()
        {
            InitializeComponent();


            //LoadClasses();

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_CLASS, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);
                    command.Parameters.AddWithValue("@class_name", classTxt.Text);

                    connection.Open();

                    MessageBox.Show("Class Creation: " + ((command.ExecuteNonQuery() > 0) ? "Successful" : "Unsuccessful"));


                }
            }
        }

        
        private void LoadClasses()
        {
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

                            //classesComboBox.Items.Add(new ComboItem() { Text = reader["class_name"], Id = reader["class_id"] });
                        }
                    }
                }
            }
        }
    }
}
