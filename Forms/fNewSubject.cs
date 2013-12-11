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

            SubjectManager sm = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            try
            {
                sm.CreateSubject(subject);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("unique"))
                    status = subject + " exists already.";
                else
                    status = "Error adding " + subject;
            }

            return status;
        }
    }
}
