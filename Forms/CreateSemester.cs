using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grade_Manager_DB_Controller;
using System.Data.SQLite;

namespace Grade_Manager
{
    public partial class CreateSemester : Form
    {
        private ProfileManager profile_manager;

        public CreateSemester()
        {
            InitializeComponent();
            //Set UP CLASSES!!!
            profile_manager = new ProfileManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING); 

            LoadClasses();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            Semester profile = new Semester()
            {
                Description = profileDescriptionTxt.Text,
                OwnerId = UserManager.CurrentUser.Id,
                StartingSchoolYear = (int)startingSchoolYearNumeric.Value,
                EndingSchoolYear = (int)endingSchoolYearNumeric.Value,
                Term = (int)currentTermNumeric.Value,
                Class = Convert.ToInt32(((ComboItem)classesComboBox.SelectedItem).Id)
            };
            
            //verify that this is complete

            if (profile_manager.CreateProfile(profile))
                statusLabel.Text = "Semester successfully created.";
            else
                statusLabel.Text = "There was an error creating profile.";
            
            
        }

        private void LoadClasses()
        {
            ClassManager class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager.LoadToComboBox(classesComboBox);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void newClassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewClass class_form = new NewClass();
            class_form.StartPosition = FormStartPosition.CenterParent;
            class_form.ShowDialog();
            LoadClasses();
        }
    }
}
