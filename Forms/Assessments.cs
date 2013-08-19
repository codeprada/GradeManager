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
    public partial class Assessments : Form
    {
        private SQLiteDataAdapter grid_adapter;
        private DataTable grid_table;
        private Assessment_Manager assessment_manager;

        public Assessments()
        {
            InitializeComponent();

            assessment_manager = new Assessment_Manager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            LoadAssessments();
            LoadAssessment_Types();
            LoadSubjects();
        }

        private void LoadAssessments()
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (grid_adapter = new SQLiteDataAdapter(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSSMENTS, connection))
                {

                    grid_adapter.SelectCommand.Parameters.AddWithValue("@profile_id", ProfileManager.CurrentProfile.Id);

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

        private void LoadAssessment_Types()
        {
            assessment_manager.LoadToComboBox(assessTypeComboBox, DB_Object.TYPE);
        }

        private void LoadSubjects()
        {
            SubjectManager subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            subject_manager.LoadToComboBox(subjectComboBox);
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
    }
}
