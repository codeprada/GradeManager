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
using System.Resources;
using System.Runtime.InteropServices;
using Grade_Manager_DB_Controller;

namespace Grade_Manager
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Bitmap> icons;

        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Rectangle working_area = Screen.GetWorkingArea(this);
            this.Width = working_area.Width;
            this.Height = working_area.Height;
            this.Location = working_area.Location;

            icons = new Dictionary<string, Bitmap>();

            //ShowWelcomeScreen();
            CenterTitle();

            //Add icons to dictionary. Prevents new handles from being created when calling from ResourceManager
            icons.Add("login", Grade_Manager_DB_Controller.Properties.Resources.login);
            icons.Add("login_over", Grade_Manager_DB_Controller.Properties.Resources.login_over);
            icons.Add("assignments", Grade_Manager_DB_Controller.Properties.Resources.assignment);
            icons.Add("assignments_over", Grade_Manager_DB_Controller.Properties.Resources.assignment_over);
            icons.Add("close", Grade_Manager_DB_Controller.Properties.Resources.close_window);
            icons.Add("close_over", Grade_Manager_DB_Controller.Properties.Resources.close_window_over);
            icons.Add("grades", Grade_Manager_DB_Controller.Properties.Resources.grades);
            icons.Add("grades_over", Grade_Manager_DB_Controller.Properties.Resources.grades_over);
            icons.Add("help", Grade_Manager_DB_Controller.Properties.Resources.help);
            icons.Add("help_over", Grade_Manager_DB_Controller.Properties.Resources.help_over);
            icons.Add("logout", Grade_Manager_DB_Controller.Properties.Resources.logout);
            icons.Add("logout_over", Grade_Manager_DB_Controller.Properties.Resources.logout_over);
            icons.Add("maximize", Grade_Manager_DB_Controller.Properties.Resources.maximize_window);
            icons.Add("maximize_over", Grade_Manager_DB_Controller.Properties.Resources.maximize_window_over);
            icons.Add("minimize", Grade_Manager_DB_Controller.Properties.Resources.minimize_window);
            icons.Add("minimize_over", Grade_Manager_DB_Controller.Properties.Resources.minimize_window_over);
            icons.Add("ratings", Grade_Manager_DB_Controller.Properties.Resources.rating);
            icons.Add("ratings_over", Grade_Manager_DB_Controller.Properties.Resources.rating_over);
            icons.Add("reports", Grade_Manager_DB_Controller.Properties.Resources.reports);
            icons.Add("reports_over", Grade_Manager_DB_Controller.Properties.Resources.reports_over);
            icons.Add("semester", Grade_Manager_DB_Controller.Properties.Resources.semester);
            icons.Add("semester_over", Grade_Manager_DB_Controller.Properties.Resources.semester_over);
            icons.Add("statistics", Grade_Manager_DB_Controller.Properties.Resources.statistics);
            icons.Add("statistics_over", Grade_Manager_DB_Controller.Properties.Resources.statistics_over);
            icons.Add("students", Grade_Manager_DB_Controller.Properties.Resources.students);
            icons.Add("students_over", Grade_Manager_DB_Controller.Properties.Resources.students_over);
            icons.Add("subjects", Grade_Manager_DB_Controller.Properties.Resources.subjects);
            icons.Add("subjects_over", Grade_Manager_DB_Controller.Properties.Resources.subjects_over);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            /*login_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(login_form);
            login_form.Location = new Point((splitContainer1.Panel2.Width - login_form.Width) / 2, (splitContainer1.Panel2.Height - login_form.Height) / 2);
            login_form.BringToFront();*/
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
            semesterPictureBox.Visible =
            studentsPictureBox.Visible =
            subjectsPictureBox.Visible =
            assignmentsPictureBox.Visible =     
            gradesPictureBox.Visible =
            reportsPictureBox.Visible =
            ratingsPictureBox.Visible = 
            statisticsPictureBox.Visible =
            logoutPictureBox.Visible =
                                                state; //State of Pictureboxes


            loginPictureBox.Visible = !state;
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
            
        }

        private void semesterMangementBtn_Click(object sender, EventArgs e)
        {
            ShowSemesterForm();
        }

        private void ShowSemesterForm()
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

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.BackgroundImage = icons[pb.Tag.ToString()];
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.BackgroundImage = icons[pb.Tag.ToString()];
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.BackgroundImage = icons[pb.Tag.ToString() + "_over"];
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.BackgroundImage = icons[pb.Tag.ToString() + "_over"];
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterTitle();
        }

        private void CenterTitle()
        {
            titleLabel.Location = new Point((this.Size.Width / 2) - (titleLabel.Size.Width / 2), titleLabel.Location.Y);
        }

        private void loginPictureBox_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void semesterPictureBox_Click(object sender, EventArgs e)
        {
            ShowSemesterForm();
        }

        private void studentsPictureBox_Click(object sender, EventArgs e)
        {
            Student_Management student_management_form = new Student_Management();
            student_management_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(student_management_form);
            student_management_form.Location = new Point((splitContainer1.Panel2.Width - student_management_form.Width) / 2, (splitContainer1.Panel2.Height - student_management_form.Height) / 2);
            student_management_form.Show();
            student_management_form.BringToFront();
        }

        private void subjectsPictureBox_Click(object sender, EventArgs e)
        {
            Subjects_Form s_form = new Subjects_Form();
            s_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(s_form);
            s_form.Location = new Point((splitContainer1.Panel2.Width - s_form.Width) / 2, (splitContainer1.Panel2.Height - s_form.Height) / 2);
            s_form.Show();
            s_form.BringToFront();
        }

        private void assignmentsPictureBox_Click(object sender, EventArgs e)
        {
            Assessments assess_form = new Assessments();
            assess_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(assess_form);
            assess_form.Location = new Point((splitContainer1.Panel2.Width - assess_form.Width) / 2, (splitContainer1.Panel2.Height - assess_form.Height) / 2);
            assess_form.Show();
            assess_form.BringToFront();
        }

        private void gradesPictureBox_Click(object sender, EventArgs e)
        {
            Grade_Main_Form grade_form = new Grade_Main_Form();
            grade_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(grade_form);
            grade_form.Location = new Point((splitContainer1.Panel2.Width - grade_form.Width) / 2, (splitContainer1.Panel2.Height - grade_form.Height) / 2);
            grade_form.Show();
            grade_form.BringToFront();
        }

        private void ratingsPictureBox_Click(object sender, EventArgs e)
        {
            Rank rank_form = new Rank();
            rank_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(rank_form);
            rank_form.Location = new Point((splitContainer1.Panel2.Width - rank_form.Width) / 2, (splitContainer1.Panel2.Height - rank_form.Height) / 2);
            rank_form.Show();
            rank_form.BringToFront();
        }

        private void reportsPictureBox_Click(object sender, EventArgs e)
        {
            Report report_form = new Report();
            report_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(report_form);
            report_form.Location = new Point((splitContainer1.Panel2.Width - report_form.Width) / 2, (splitContainer1.Panel2.Height - report_form.Height) / 2);
            report_form.Show();
            report_form.BringToFront();
        }

        private void statisticsPictureBox_Click(object sender, EventArgs e)
        {
            Statistics stats_form = new Statistics();
            stats_form.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(stats_form);
            stats_form.Location = new Point((splitContainer1.Panel2.Width - stats_form.Width) / 2, (splitContainer1.Panel2.Height - stats_form.Height) / 2);
            stats_form.Show();
            stats_form.BringToFront();
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            UserManager.CurrentUser = null;

            this.Text = "Grade Manager";

            ShowControls(false);
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
