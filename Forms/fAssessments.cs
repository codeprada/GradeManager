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
using FastMember;

namespace Grade_Manager_DB_Controller
{
    public partial class fAssessments : Form
    {
        private SQLiteDataAdapter grid_adapter;
        private DataTable grid_table;
        private AssessmentManager assessment_manager;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public fAssessments()
        {
            InitializeComponent();

            assessment_manager = new AssessmentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            LoadAssessments();
            LoadAssessment_Types();
            LoadSubjects();
        }

        private void LoadAssessments()
        {
            assessmentDataGridView.DataSource = null;

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (grid_adapter = new SQLiteDataAdapter(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENTS_SUBJECTS, connection))
                {

                    grid_adapter.SelectCommand.Parameters.AddWithValue("@semester_id", SemesterManager.CurrentSemester.Id);

                    connection.Open();

                    using (grid_table = new DataTable())
                    {

                        grid_adapter.Fill(grid_table);
                        assessmentDataGridView.DataSource = grid_table;
                        assessmentDataGridView.Columns[0].Visible = false;
                    }


                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                cp.Style |= 0x40000;
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

        private void LoadAssessmentsWithFilter()
        {
            List<object> list = assessment_manager.GetAssessments(
                (filterSubject.Checked ? (int)((ComboItem)filterSubjectCombo.SelectedItem).Id : -1),
                (filterTypeCheckbox.Checked ? (int)((ComboItem)filterTypeCombo.SelectedItem).Id : -1),
                (filterTimePeriod.Checked ? filterDateFrom.Value.ToString("yyyy-MM-dd") : null),
                (filterTimePeriod.Checked ? filterDateTo.Value.ToString("yyyy-MM-dd") : null)
            );

            
            assessmentDataGridView.DataSource = list;
            //making sure we have data in our list
            if(assessmentDataGridView.Columns.Count > 0)
                assessmentDataGridView.Columns[0].Visible = false;
                
            
        }

        private void LoadAssessment_Types()
        {
            assessment_manager.LoadToComboBox(assessTypeComboBox, DB_Object.TYPE);
            assessment_manager.LoadToComboBox(filterTypeCombo, DB_Object.TYPE);
        }

        private void LoadSubjects()
        {
            SubjectManager subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            subject_manager.LoadToComboBox(subjectComboBox, SemesterManager.CurrentSemester);
            subject_manager.LoadToComboBox(filterSubjectCombo, SemesterManager.CurrentSemester);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveAssessment();
            LoadAssessments();
        }

        private void SaveAssessment()
        {
            Assessment a = new Assessment()
            {
                Date = assessDatePicker.Value.ToString("yyyy-MM-dd"),
                Type = Convert.ToInt32(((ComboItem)assessTypeComboBox.SelectedItem).Id),
                Subject = Convert.ToInt32(((ComboItem)subjectComboBox.SelectedItem).Id),
            };

            assessment_manager.Save(a);
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            LoadAssessmentsWithFilter();
        }

        private void clearFilterBtn_Click(object sender, EventArgs e)
        {
            LoadAssessments();
        }

        private void filterTypeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            filterTypeCombo.Enabled = filterTypeCheckbox.Checked;
        }

        private void filterTimePeriod_CheckedChanged(object sender, EventArgs e)
        {
            filterDateFrom.Enabled =
                filterDateTo.Enabled =
                filterTimePeriod.Checked;
        }

        private void filterSubject_CheckedChanged(object sender, EventArgs e)
        {
            filterSubjectCombo.Enabled = filterSubject.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel p = ((Panel)Parent);
            fAssessmentType cat = new fAssessmentType();
            cat.TopLevel = false;
            p.Controls.Add(cat);
            cat.Location = new Point((p.Width - cat.Width) / 2, (p.Height - cat.Height) / 2);
            cat.Show();
            cat.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel p = ((Panel)Parent);
            fAssessmentType cat = new fAssessmentType();
            cat.TopLevel = false;
            p.Controls.Add(cat);
            cat.Location = new Point((p.Width - cat.Width) / 2, (p.Height - cat.Height) / 2);
            cat.Show();
            cat.BringToFront();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            Styles.Button_MouseEnter(sender, e);
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            Styles.Button_MouseLeave(sender, e);
        }

        private void FormDrag_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void fAssessments_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));

        }
    }
}
