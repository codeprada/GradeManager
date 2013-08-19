//db_password: 756d3f188244c06453f219162bfb3f0908a57ba4
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Grade_Manager_DB_Controller;

namespace Grade_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            LogIn login_form = new LogIn();
            //login_form.MdiParent = this;
            login_form.StartPosition = FormStartPosition.CenterParent;
            login_form.ShowDialog();
            
            if (UserManager.CurrentUser != null && UserManager.CurrentUser.Name.Length > 0)
            {
                //User has been logged in
                
                this.Text += " - User: " + UserManager.CurrentUser.Name;
                ShowControls(true);
                //ShowProfileForm();
                
            }
        }

        private void ShowControls(bool state)
        {
            /*loginBtn.Visible = !state;

            gradeManagementBtn.Visible =
                classManagementBtn.Visible =
                subjectManagementBtn.Visible =
                profileMangementBtn.Visible =
                logoutBtn.Visible =
                reportBtn.Visible =
                studentManagementBtn.Visible = state; */

            logoutRibbonBtn.Enabled =
                assignmentManagementRibbonBtn.Enabled =
                subjectsManagementRibbonBtn.Enabled =
                profilesManagementRibbonBtn.Enabled =
                //reportsManagementRibbonBtn.Enabled =
                studentManagementRibbonBtn.Enabled = state;

            logInRibBtn.Enabled = !state;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GradeManager_SQLite_DB_Controller gm_db_controller = new GradeManager_SQLite_DB_Controller();

            //Making sure database exists with the needed correct columns
            if (!gm_db_controller.IntegrityTest())
                gm_db_controller.CreateDatabase(); //Creates database

            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserManager.CurrentUser = null;

            this.Text = "Grade Manager";

            ShowControls(false);
        }

        private void profileMangementBtn_Click(object sender, EventArgs e)
        {
            ShowProfileForm();
        }

        private void ShowProfileForm()
        {
            Profile_Form profile_fm = new Profile_Form();
            profile_fm.StartPosition = FormStartPosition.CenterParent;

            ////Verify if the user selected a profile
            if (profile_fm.ShowDialog() == System.Windows.Forms.DialogResult.OK && ProfileManager.CurrentProfile != null)
            {
                this.Text += String.Format(" - Profile Year: {0}/{1}",
                    ProfileManager.CurrentProfile.StartingSchoolYear,
                    ProfileManager.CurrentProfile.EndingSchoolYear
                );

                //enable the other controls now that the user has selected a profile
                gradesManagementRibbonBtn.Enabled =
                    reportsManagementRibbonBtn.Enabled = true;

            }
        }

        private void subjectManagementBtn_Click(object sender, EventArgs e)
        {
            Subjects_Form s_form = new Subjects_Form();
            s_form.StartPosition = FormStartPosition.CenterParent;
            //s_form.MdiParent = this;
            s_form.TopLevel = false;
            panel1.Controls.Add(s_form);
            s_form.Show();
        }

        private void studentManagementBtn_Click(object sender, EventArgs e)
        {
            Student_Management student_management_form = new Student_Management();
            student_management_form.StartPosition = FormStartPosition.CenterScreen;
            //student_management_form.MdiParent = this;
            student_management_form.TopLevel = false;
            panel1.Controls.Add(student_management_form);
            student_management_form.Show();
        }

        private void assignmentManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Assessments assess_form = new Assessments();
            assess_form.StartPosition = FormStartPosition.CenterParent;
            assess_form.TopLevel = false;
            panel1.Controls.Add(assess_form);
            assess_form.Show();
        }
    }
}
