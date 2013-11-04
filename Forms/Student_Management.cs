﻿using System;
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
    public partial class Student_Management : Form
    {
        private SQLiteDataAdapter grid_adapter;
        private DataTable grid_table;
        private StudentManager student_manager;

        public Student_Management()
        {
            InitializeComponent();

            student_manager = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            
            LoadClasses();
            LoadStudentList();
        }

        private void LoadStudentList()
        {
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*Student student = new Student()
            {
                FirstName = firstNameTxt.Text,
                LastName = lastNameTxt.Text,
                MiddleName = midNameTxt.Text,
                DateOfBirth = dobDatePicker.Value,
                Gender = (maleRadioButton.Checked ? "M" : "F")
            };

            int student_id;

            if ((student_id = student_manager.Save(student)) > -1)
            {

                if (!student_manager.AssignToClass(Convert.ToInt32(((ComboItem)classesComboBox.SelectedItem).Id), student_id))
                {
                    MessageBox.Show("Student wasn't assigned to a class");
                }


                firstNameTxt.Clear();
                lastNameTxt.Clear();
                midNameTxt.Clear();
                LoadStudentList();
            }
            else
            {
                MessageBox.Show("There was an error while saving Student.", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private bool CreateOrSaveStudentDetails()
        {
            return false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(studentGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void Student_Management_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadClasses()
        {
            /*ClassManager class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager.LoadToComboBox(classesComboBox);*/
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void Student_Management_Paint(object sender, PaintEventArgs e)
        {
            Form s = sender as Form;

            s.Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, s.Width - 5, s.Height -5, s.Width, s.Height));

        }
    }
}
