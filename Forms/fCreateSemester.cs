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
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        private SemesterManager profile_manager;

        public CreateSemester()
        {
            InitializeComponent();
            //Set UP CLASSES!!!
            profile_manager = new SemesterManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            Initialize();

            LoadClasses();
        }

        private void Initialize()
        {
            int year;
            if(DateTime.Now.Month > 6)
                year = DateTime.Now.Year;
            else
                year = DateTime.Now.Year - 1;

            startingSchoolYearNumeric.Value = year;
            endingSchoolYearNumeric.Value = year + 1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                //cp.Style |= 0x40000; //RESIZING
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (classesComboBox.SelectedItem != null)
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

                if (profile_manager.CreateSemester(profile))
                {
                    statusLabel.Text = "Semester successfully created.";
                    Close();
                }
                else
                    statusLabel.Text = "There was an error creating semester.";
            }
            else
            {
                statusLabel.Text = "Fill in the required information.";
            }
            
        }

        private void LoadClasses()
        {
            ClassManager class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager.LoadToComboBox(classesComboBox);
        }

        private void newClassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opacity = 0.20;
            //Application.DoEvents();
            NewClass class_form = new NewClass();
            class_form.StartPosition = FormStartPosition.CenterParent;
            class_form.ShowDialog();
            LoadClasses();
            Opacity = 1;
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateSemester_Paint(object sender, PaintEventArgs e)
        {
            Form s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void closePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }

        private void closePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void startingSchoolYearNumeric_ValueChanged(object sender, EventArgs e)
        {
            endingSchoolYearNumeric.Value = startingSchoolYearNumeric.Value + 1;
        }
    }
}
