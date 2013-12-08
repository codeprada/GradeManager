using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace Grade_Manager_DB_Controller
{
    public partial class StudentManagementForm : Form
    {
        private SQLiteDataAdapter grid_adapter;
        private DataTable grid_table;
        private StudentManager student_manager;

        public StudentManagementForm()
        {
            InitializeComponent();

            student_manager = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            
            LoadClasses();
            LoadStudentList();
        }

        private void LoadStudentList()
        {
            studentGridView.DataSource = null;

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (grid_adapter = new SQLiteDataAdapter(GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_STUDENTS_TIDY, connection))
                {

                    grid_adapter.SelectCommand.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);

                    connection.Open();

                    using (grid_table = new DataTable())
                    {
                        
                        grid_adapter.Fill(grid_table);
                        studentGridView.DataSource = grid_table;
                        studentGridView.Columns[0].Visible = false;
                    }

                    
                }
            }
        }


        private bool CreateOrSaveStudentDetails()
        {
            return false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails(Int32.Parse(studentGridView.SelectedRows[0].Cells[0].Value.ToString()));
            sd.StartPosition = FormStartPosition.CenterParent;
            Visible = false;
            sd.ShowDialog();
            LoadStudentList();
            Visible = true;
        }

        private void LoadClasses()
        {
            /*ClassManager class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager.LoadToComboBox(classesComboBox);*/
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this student?\n\nN.B. Please note that delete a student will remove all graded assignments attached to student.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                if (student_manager.Delete(Int32.Parse(studentGridView.SelectedRows[0].Cells[0].Value.ToString())))
                {
                    LoadStudentList();
                    //MessageBox.Show("Student deleted");
                }
                else
                {
                    MessageBox.Show("Could not delete student list.");
                }
            }

        }

        

        private void Student_Management_Paint(object sender, PaintEventArgs e)
        {
            Form s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width, s.Height, 4, 4));

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
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

        private void studentGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            studentGridView.CurrentCell = studentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void addNewStudentPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            StudentDetails sd_form = new StudentDetails();
            this.Visible = false;
            sd_form.StartPosition = FormStartPosition.CenterParent;

            if(sd_form.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                LoadStudentList();

            this.Visible = true;
        }

        private void addNewStudentPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void addNewStudentPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void addNewStudentPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void addNewStudentPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }
    }
}
