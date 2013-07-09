﻿using System;
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
            //Fast way to load a checklist
            //To String method in Subject object will be used as the checkboxitem's text
            subjectCheckListBox.Items.AddRange(subject_manager.GetAllSubjects().ToArray());

            ClassManager class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager.LoadToComboBox(classComboBox);
            
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Clear all subjects associated with Profile in order to update new list
            subject_manager.ClearProfileSubjects();
            int count = 0;
            foreach (Subject subject in subjectCheckListBox.CheckedItems)
            {
                if (subject_manager.SaveSubjectToClass(subject, Convert.ToInt32(((ComboItem)classComboBox.SelectedItem).Id)))
                    count++;
            }

            MessageBox.Show(String.Format("Selected {0} subjects for your profile", count), "Subject Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((ComboItem)classComboBox.SelectedItem).Text.ToString());
        }
    }
}
