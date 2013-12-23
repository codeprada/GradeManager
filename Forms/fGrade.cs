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

namespace Grade_Manager_DB_Controller
{
    public partial class Grade_Main_Form : Form
    {
        private SubjectManager subject_manager;
        private Grade_Manager grade_manager;
        private int class_id = -1;

        public Grade_Main_Form()
        {
            InitializeComponent();

            subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            grade_manager = new Grade_Manager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            assessmentComboBox.ValueMember = "Id";
            assessmentComboBox.DisplayMember = "Text";

            LoadDefaultValues();
            LoadSubjects();
        }

        //Prepare Subject combo box as well as the Assignment combo box
        //They must be intelligent and be able to work together
        /* Just to save them
         * --SELECT assess_id ID, assess_date [Date], assess_name [Name], subject_name [Subject], class_name [Class], current_term [Semester], (starting_school_year || '/' || ending_school_year) [Year]  FROM [Assessments] A INNER JOIN [Subjects] S ON A.subject_id = S.subject_id INNER JOIN [Semester] P ON p.semester_id = A.semester_id INNER JOIN [Classes] C ON P.class_id = C.class_id INNER JOIN [Assessment_Type] AT ON a.assess_type_id = AT.assess_type_id WHERE A.semester_id = 1 ORDER BY starting_school_year, Semester, Date
--SELECT * FROM [Assessments] A LEFT JOIN [Grades] G ON A.assess_id = G.assess_id INNER JOIN [Semester] S ON A.semester_id = S.semester_id INNER JOIN [Students] ST ON G.student_id = ST.student_id;
SELECT DISTINCT [class_name], [starting_school_year], [ending_school_year], [current_term] FROM [Assessments] A LEFT JOIN [Grades] G ON A.assess_id = G.assess_id INNER JOIN [Semester] S ON A.semester_id = S.semester_id INNER JOIN [Students] ST ON G.student_id = ST.student_id INNER JOIN Classes C ON C.class_id = S.class_id WHERE S.semester_id = 1;
--SELECT assess_id, assess_name FROM [Assessments] A WHERE [semester_id] = 1 AND [subject_id] = 3
--SELECT DISTINCT S.subject_id, S.subject_name FROM [Assessments] A INNER JOIN [Subjects] S ON A.subject_id = S.subject_id WHERE semester_id = 1
[grade_mark], [student_first_name], [student_last_name], assess_name, A.assess_id FROM [Assessments] A LEFT JOIN [Grades] G ON A.assess_id = G.assess_id INNER JOIN [Semester] S ON A.semester_id = S.semester_id INNER JOIN [Students] ST ON G.student_id = ST.student_id INNER JOIN Classes C ON C.class_id = S.class_id
         * 
         * 
         */

        public void LoadDefaultValues()
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_SELECT_DEFAULT_VALUES_GRADES, connection))
                {
                    command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SemesterTextBox.Text = Convert.ToString(reader["current_term"]);
                            classTextBox.Text = Convert.ToString(reader["class_name"]);
                            yearTextBox.Text = Convert.ToString(reader["starting_school_year"]) + "/" + Convert.ToString(reader["ending_school_year"]);
                            class_id = Convert.ToInt32(reader["class_id"]);
                        }
                    }
                }
            }
        }

        public void LoadSubjects()
        {
            subject_manager.LoadToComboBox(subjectComboBox, SemesterManager.CurrentSemester);     
        }

        private void assessmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)(((ComboItem)assessmentComboBox.SelectedItem).Id);
            LoadStudents(id);
            
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssessments((int)((ComboItem)subjectComboBox.SelectedItem).Id);
            studentGradeDataViewGrid.DataSource = null; //clear the students and their grades
        }

        public void LoadAssessments(int subject_id)
        {
            assessmentComboBox.Items.Clear();

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENT_FROM_SUBJECT, connection))
                {
                    command.Parameters.AddWithValue("@subject_id", subject_id);
                    command.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            //Create assessments combobox items
                            assessmentComboBox.Items.Add(new ComboItem() { Id = Convert.ToInt32(reader["assess_id"]), Text = reader["assess_name"] });
                        }
                    }
                }
            }
        }

        public void LoadStudents(int assess_id)
        {
            studentGradeDataViewGrid.DataSource = null;

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var adapter = new SQLiteDataAdapter(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENT_STUDENT, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@assess_id", assess_id);

                    connection.Open();

                    using (var grid_table = new DataTable())
                    {
                        adapter.Fill(grid_table);
                        studentGradeDataViewGrid.DataSource = grid_table;
                        studentGradeDataViewGrid.Columns["ID"].Visible = false;
                        //studentGradeDataViewGrid.Columns["A_ID"].Visible = false;

                        foreach (DataGridViewColumn column in studentGradeDataViewGrid.Columns)
                        {
                            column.ReadOnly = true;
                        }
                        studentGradeDataViewGrid.Columns["Grade"].ReadOnly = false;
                        
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.LightYellow;
                        style.ForeColor = Color.Red;
                        style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        style.DataSourceNullValue = 0;

                        studentGradeDataViewGrid.Columns["Grade"].DefaultCellStyle = style;
                    }
                }
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in studentGradeDataViewGrid.Rows)
            {
                if (row.Cells["Grade"].Value == DBNull.Value)
                    row.Cells["Grade"].Value = 0;

                grade_manager.Save(
                    Convert.ToInt32(row.Cells["ID"].Value),
                    (int)(((ComboItem)assessmentComboBox.SelectedItem).Id),
                    Convert.ToDouble(row.Cells["Grade"].Value)
                );

            }
                
        }

        private void studentGradeDataViewGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentGradeDataViewGrid.Columns["Grade"].Index)
            {
                if (studentGradeDataViewGrid.Rows[e.RowIndex].Cells["Grade"].Value == DBNull.Value)
                    studentGradeDataViewGrid.Rows[e.RowIndex].Cells["Grade"].Value = 0;

                grade_manager.Save(
                    Convert.ToInt32(studentGradeDataViewGrid.Rows[e.RowIndex].Cells["ID"].Value),
                    (int)(((ComboItem)assessmentComboBox.SelectedItem).Id),
                    Convert.ToDouble(studentGradeDataViewGrid.Rows[e.RowIndex].Cells["Grade"].Value)
                );
                statusLabel.Text = "Grade saved.";
                statusTimer.Enabled = true;
            }
            
        }

        private void closePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
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

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
            statusTimer.Enabled = false;
        }

        private void Grade_Main_Form_Paint(object sender, PaintEventArgs e)
        {
            Form f = sender as Form;

            f.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, f.Width + 1, f.Height + 1, 5, 5));
        }

        private void studentGradeDataViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            studentGradeDataViewGrid.CurrentCell = studentGradeDataViewGrid.Rows[e.RowIndex].Cells["Grade"];
            studentGradeDataViewGrid.BeginEdit(true);
            
        }

        private void studentGradeDataViewGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            Styles.Button_MouseEnter(sender, e);
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            Styles.Button_MouseLeave(sender, e);
        }

    }
}
