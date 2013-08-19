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
    public partial class NewSubject : Form
    {
        public NewSubject()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateSubject(subjectTxt.Text);
            subjectTxt.Clear();
            MessageBox.Show("Subject Added");
        }

        private void CreateSubject(string subject)
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_SUBJECT, connection))
                {
                    command.Parameters.AddWithValue("@subject_name", subject);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
