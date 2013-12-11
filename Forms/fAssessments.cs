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
    public partial class Assessments : Form
    {
        private SQLiteDataAdapter grid_adapter;
        private DataTable grid_table;
        private AssessmentManager assessment_manager;

        public Assessments()
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
            subject_manager.LoadToComboBox(subjectComboBox, SemesterManager.CurrentSemester.Id);
            subject_manager.LoadToComboBox(filterSubjectCombo, SemesterManager.CurrentSemester.Id);
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
            fAssessmentType cat = new fAssessmentType();

            cat.ShowDialog();
        }
    }
}
