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

                this.Text += " - User: " + UserManager.CurrentUser.FirstName + " " + UserManager.CurrentUser.LastName;
                ShowControls(true);
                //ShowProfileForm();

            }
        }

        private void ShowControls(bool state)
        {

            logoutRibbonBtn.Enabled =
                //assignmentManagementRibbonBtn.Enabled =
                //subjectsManagementRibbonBtn.Enabled =
                semesterManagementRibbonBtn.Enabled = state;
            //reportsManagementRibbonBtn.Enabled =
            //studentManagementRibbonBtn.Enabled = state;

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

        private void semesterMangementBtn_Click(object sender, EventArgs e)
        {
            ShowProfileForm();
        }

        private void ShowProfileForm()
        {
            Semester_Form semester_fm = new Semester_Form();
            semester_fm.StartPosition = FormStartPosition.CenterParent;

            ////Verify if the user selected a semester
            if (semester_fm.ShowDialog() == System.Windows.Forms.DialogResult.OK && SemesterManager.CurrentSemester != null)
            {
                this.Text += String.Format(" - Semester Year: {0}/{1}",
                    SemesterManager.CurrentSemester.StartingSchoolYear,
                    SemesterManager.CurrentSemester.EndingSchoolYear
                );

                //enable the other controls now that the user has selected a semester
                assignmentManagementRibbonBtn.Enabled =
                subjectsManagementRibbonBtn.Enabled =
                reportsManagementRibbonBtn.Enabled =
                studentManagementRibbonBtn.Enabled =
                gradesManagementRibbonBtn.Enabled =
                reportsManagementRibbonBtn.Enabled =
                statisticsRibbonButton.Enabled = true;

            }
        }

        private void subjectManagementBtn_Click(object sender, EventArgs e)
        {
            Subjects_Form s_form = new Subjects_Form();
            s_form.TopLevel = false;
            panel1.Controls.Add(s_form);
            s_form.Location = new Point((panel1.Width - s_form.Width) / 2, (panel1.Height - s_form.Height) / 2);
            s_form.Show();
            s_form.BringToFront();
        }

        private void studentManagementBtn_Click(object sender, EventArgs e)
        {
            Student_Management student_management_form = new Student_Management();
            student_management_form.TopLevel = false;
            panel1.Controls.Add(student_management_form);
            student_management_form.Location = new Point((panel1.Width - student_management_form.Width) / 2, (panel1.Height - student_management_form.Height) / 2);
            student_management_form.Show();
            student_management_form.BringToFront();
        }

        private void assignmentManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Assessments assess_form = new Assessments();
            assess_form.TopLevel = false;
            panel1.Controls.Add(assess_form);
            assess_form.Location = new Point((panel1.Width - assess_form.Width) / 2, (panel1.Height - assess_form.Height) / 2);
            assess_form.Show();
            assess_form.BringToFront();
        }

        private void gradesManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Grade_Main_Form grade_form = new Grade_Main_Form();
            grade_form.TopLevel = false;
            panel1.Controls.Add(grade_form);
            grade_form.Location = new Point((panel1.Width - grade_form.Width) / 2, (panel1.Height - grade_form.Height) / 2);
            grade_form.Show();
            grade_form.BringToFront();
        }

        private void reportsManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Report report_form = new Report();
            report_form.TopLevel = false;
            panel1.Controls.Add(report_form);
            report_form.Location = new Point((panel1.Width - report_form.Width) / 2, (panel1.Height - report_form.Height) / 2);
            report_form.Show();
            report_form.BringToFront();
        }

        private void statisticsRibbonButton_Click(object sender, EventArgs e)
        {
            Statistics stats_form = new Statistics();
            stats_form.TopLevel = false;
            panel1.Controls.Add(stats_form);
            stats_form.Location = new Point((panel1.Width - stats_form.Width) / 2, (panel1.Height - stats_form.Height) / 2);
            stats_form.Show();
            stats_form.BringToFront();
        }

        private void rankingRButton_Click(object sender, EventArgs e)
        {
            Rank rank_form = new Rank();
            rank_form.TopLevel = false;
            panel1.Controls.Add(rank_form);
            rank_form.Location = new Point((panel1.Width - rank_form.Width) / 2, (panel1.Height - rank_form.Height) / 2);
            rank_form.Show();
            rank_form.BringToFront();
        }
    }
}
