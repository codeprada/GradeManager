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
using System.Globalization;

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
            subjectStatusLabel.Text = String.Empty;
            subjectStatusLabel.Text = CreateSubject(subjectTxt.Text);
            subjectTxt.Clear();
        }

        private string CreateSubject(string subject)
        {
            string status = String.Empty;

            if (subject != String.Empty)
            {
                subject = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subject.ToLower());

                using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
                {
                    using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_SUBJECT, connection))
                    {
                        command.Parameters.AddWithValue("@subject_name", subject);

                        connection.Open();
                        try
                        {
                            if (command.ExecuteNonQuery() > 0)
                                status = subject + " added.";
                        }
                        catch (Exception e)
                        {
                            if (e.Message.Contains("unique"))
                                status = subject + " exists already.";
                            else
                                status = "Error adding " + subject;
                        }
                    }
                }
            }
            else
            {
                status = "No subject_id";
            }

            return status;

        }
    }
}
