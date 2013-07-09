using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Manager_DB_Controller
{
    public partial class Subjects_Form : Form
    {
        private SubjectManager subject_manager;

        public Subjects_Form()
        {
            InitializeComponent();

            

            subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            LoadList();
        }

        private void Subjects_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadList()
        {
            foreach (Subject subject in subject_manager.GetAllSubjects())
            {
                subjectCheckListBox.Items.Add(subject);
            }
        }
    }
}
