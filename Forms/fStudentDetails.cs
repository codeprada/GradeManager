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

        public StudentDetails(int student_id = -1)
        {
            InitializeComponent();

            student_manager = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            class_manager.LoadToComboBox(classesComboBox);

            CurrentStudent = null;

            if (student_id > -1)
                LoadStudent(student_id);
        }

        #region Effects
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

            classesComboBox.Text = c.Name;

            dobDatePicker.Value = CurrentStudent.DateOfBirth;

            if (CurrentStudent.Gender.StartsWith("M"))
                maleRadioButton.Checked = true;
            else
                femaleRadioButton.Checked = true;

        }

        private void StudentDetails_Paint(object sender, PaintEventArgs e)
        {
            Form f = sender as Form;
            f.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, f.Width, f.Height, 5, 5));
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void savePictureBox_MouseClick(object sender, MouseEventArgs e)
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
            student_manager.AssignToClass((int)((ComboItem)classesComboBox.SelectedItem).Id, CurrentStudent.ID);

            if (completed)
            {
                statusStrip.Text = "Updated information saved.";
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                statusStrip.Text = "There was an error while saving.";
                DialogResult = System.Windows.Forms.DialogResult.No;
            }

            timer1.Enabled = true;
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

        
    }
}
