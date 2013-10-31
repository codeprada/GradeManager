﻿//db_password: 756d3f188244c06453f219162bfb3f0908a57ba4
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

            Rectangle working_area = Screen.GetWorkingArea(this);
            this.Width = working_area.Width;
            this.Height = working_area.Height;
            this.Location = working_area.Location;

            //ShowWelcomeScreen();
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
            login_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(login_form);
            login_form.Location = new Point((splitContainer1.Panel2.Width - login_form.Width) / 2, (splitContainer1.Panel2.Height - login_form.Height) / 2);
            login_form.BringToFront();
            login_form.ShowDialog();
            
            if (UserManager.CurrentUser != null && UserManager.CurrentUser.Name.Length > 0)
            {
                //User has been logged in

                mainStatusLabel.Text = "Hello " + UserManager.CurrentUser.FirstName + " " + UserManager.CurrentUser.LastName;
                ShowControls(true);
                //ShowProfileForm();

            }
        }

        private void ShowControls(bool state)
        {

            /*logoutRibbonBtn.Enabled =
                //assignmentManagementRibbonBtn.Enabled =
                //subjectsManagementRibbonBtn.Enabled =
                semesterManagementRibbonBtn.Enabled = state;
            //reportsManagementRibbonBtn.Enabled =
            //studentManagementRibbonBtn.Enabled = state;

            logInRibBtn.Enabled = !state;*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GradeManager_SQLite_DB_Controller gm_db_controller = new GradeManager_SQLite_DB_Controller();

            //Making sure database exists with the needed correct columns
            if (!gm_db_controller.IntegrityTest())
                gm_db_controller.CreateDatabase(); //Creates database


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
                mainStatusLabel.Text += String.Format(" - Semester Year: {0}/{1}",
                    SemesterManager.CurrentSemester.StartingSchoolYear,
                    SemesterManager.CurrentSemester.EndingSchoolYear
                );

                //enable the other controls now that the user has selected a semester
                /*assignmentManagementRibbonBtn.Enabled =
                subjectsManagementRibbonBtn.Enabled =
                reportsManagementRibbonBtn.Enabled =
                studentManagementRibbonBtn.Enabled =
                gradesManagementRibbonBtn.Enabled =
                reportsManagementRibbonBtn.Enabled =
                statisticsRibbonButton.Enabled = 
                rankingRButton.Enabled = 
                logoutRibbonBtn.Enabled = true;
                 * */

            }
        }

        private void ShowWelcomeScreen()
        {
            WelcomeScreen welcome_screen = new WelcomeScreen();
            welcome_screen.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(welcome_screen);
            welcome_screen.Location = new Point((splitContainer1.Panel2.Width - welcome_screen.Width) / 2, (splitContainer1.Panel2.Height - welcome_screen.Height) / 2);
            welcome_screen.Show();
            welcome_screen.BringToFront();
        }

        private void subjectManagementBtn_Click(object sender, EventArgs e)
        {
            Subjects_Form s_form = new Subjects_Form();
            s_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(s_form);
            s_form.Location = new Point((splitContainer1.Panel2.Width - s_form.Width) / 2, (splitContainer1.Panel2.Height - s_form.Height) / 2);
            s_form.Show();
            s_form.BringToFront();
        }

        private void studentManagementBtn_Click(object sender, EventArgs e)
        {
            Student_Management student_management_form = new Student_Management();
            student_management_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(student_management_form);
            student_management_form.Location = new Point((splitContainer1.Panel2.Width - student_management_form.Width) / 2, (splitContainer1.Panel2.Height - student_management_form.Height) / 2);
            student_management_form.Show();
            student_management_form.BringToFront();
        }

        private void assignmentManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Assessments assess_form = new Assessments();
            assess_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(assess_form);
            assess_form.Location = new Point((splitContainer1.Panel2.Width - assess_form.Width) / 2, (splitContainer1.Panel2.Height - assess_form.Height) / 2);
            assess_form.Show();
            assess_form.BringToFront();
        }

        private void gradesManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Grade_Main_Form grade_form = new Grade_Main_Form();
            grade_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(grade_form);
            grade_form.Location = new Point((splitContainer1.Panel2.Width - grade_form.Width) / 2, (splitContainer1.Panel2.Height - grade_form.Height) / 2);
            grade_form.Show();
            grade_form.BringToFront();
        }

        private void reportsManagementRibbonBtn_Click(object sender, EventArgs e)
        {
            Report report_form = new Report();
            report_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(report_form);
            report_form.Location = new Point((splitContainer1.Panel2.Width - report_form.Width) / 2, (splitContainer1.Panel2.Height - report_form.Height) / 2);
            report_form.Show();
            report_form.BringToFront();
        }

        private void statisticsRibbonButton_Click(object sender, EventArgs e)
        {
            Statistics stats_form = new Statistics();
            stats_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(stats_form);
            stats_form.Location = new Point((splitContainer1.Panel2.Width - stats_form.Width) / 2, (splitContainer1.Panel2.Height - stats_form.Height) / 2);
            stats_form.Show();
            stats_form.BringToFront();
        }

        private void rankingRButton_Click(object sender, EventArgs e)
        {
            Rank rank_form = new Rank();
            rank_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(rank_form);
            rank_form.Location = new Point((splitContainer1.Panel2.Width - rank_form.Width) / 2, (splitContainer1.Panel2.Height - rank_form.Height) / 2);
            rank_form.Show();
            rank_form.BringToFront();
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).BackgroundImage = Grade_Manager_DB_Controller.Properties.Resources.login_32;
        }

        private void loginPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)(sender)).BackgroundImage = Grade_Manager_DB_Controller.Properties.Resources.login_32;
        }

        private void loginPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)(sender)).BackgroundImage = Grade_Manager_DB_Controller.Properties.Resources.login_32_over;
        }

        private void loginPictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).BackgroundImage = Grade_Manager_DB_Controller.Properties.Resources.login_32_over;
        }

        private void loginPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Login();
        }
    }
}
