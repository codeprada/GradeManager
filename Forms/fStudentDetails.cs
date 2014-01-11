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
    public partial class StudentDetails : Form
    {
        private StudentManager student_manager;
        private ClassManager class_manager;
        private Student CurrentStudent;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public StudentDetails(int student_id = -1)
        {
            InitializeComponent();

            student_manager = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            //class_manager.LoadToComboBox(classesComboBox);

            CurrentStudent = null;

            if (student_id > -1)
                LoadStudent(student_id);
        }

        #region Effects

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                //cp.Style |= 0x40000;
                return cp;
            }
        }

        private void maximizePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void maximizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void maximizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void maximizePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadStudent(int student_id)
        {
            CurrentStudent = student_manager.Get(student_id);
            Class c = class_manager.GetClassOfStudent(CurrentStudent.ID);

            firstNameTxt.Text = CurrentStudent.FirstName;
            lastNameTxt.Text = CurrentStudent.LastName;
            midNameTxt.Text = CurrentStudent.MiddleName;

            //classesComboBox.Text = c.Name;

            dobDatePicker.Value = CurrentStudent.DateOfBirth;

            if (CurrentStudent.Gender.StartsWith("M"))
                maleRadioButton.Checked = true;
            else
                femaleRadioButton.Checked = true;

        }

        private void StudentDetails_Paint(object sender, PaintEventArgs e)
        {
            Form f = sender as Form;
            f.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, f.Width + 1, f.Height + 1, 5, 5));
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void savePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void savePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void savePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip.Text = String.Empty;
            timer1.Enabled = false;
        }

        private void savePictureBox_Click(object sender, EventArgs e)
        {
            if (firstNameTxt.Text != String.Empty && lastNameTxt.Text != String.Empty && (maleRadioButton.Checked || femaleRadioButton.Checked))
            {
                timer1.Enabled = false;
                statusStrip.Text = "";

                if (CurrentStudent == null)
                    CurrentStudent = new Student();


                CurrentStudent.FirstName = firstNameTxt.Text;
                CurrentStudent.LastName = lastNameTxt.Text;
                CurrentStudent.MiddleName = midNameTxt.Text;
                CurrentStudent.Gender = maleRadioButton.Checked ? "M" : "F";
                CurrentStudent.DateOfBirth = dobDatePicker.Value;

                bool completed = false;

                if (CurrentStudent.ID < 0)
                {
                    if ((CurrentStudent.ID = student_manager.Save(CurrentStudent)) > 0)
                        completed = true;
                }
                else
                {
                    completed = student_manager.Update(CurrentStudent);
                }

                //student_manager.AssignToClass((int)((ComboItem)classesComboBox.SelectedItem).Id, CurrentStudent.ID);
                student_manager.AssignToClass(SemesterManager.CurrentSemester.Class, CurrentStudent.ID);

                if (completed)
                {
                    statusStrip.Text = "Updated information saved.";
                    DialogResult = System.Windows.Forms.DialogResult.Yes;

                    firstNameTxt.Text = String.Empty;
                    lastNameTxt.Text = String.Empty;
                    midNameTxt.Text = string.Empty;
                    maleRadioButton.Checked = femaleRadioButton.Checked = false;

                }
                else
                {
                    statusStrip.Text = "There was an error while saving.";
                    DialogResult = System.Windows.Forms.DialogResult.No;
                }

                
            }
            else
            {
                statusStrip.Text = "Fill out the required information before saving";
            }

            timer1.Enabled = true;
        }

        
    }
}
