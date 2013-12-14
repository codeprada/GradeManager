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
    public partial class fAssessmentType : Form
    {
        public fAssessmentType()
        {
            InitializeComponent();

            LoadAssessmentTypes();
        }

        public void LoadAssessmentTypes()
        {
            assessmentDataGridView.DataSource = null;
            assessmentDataGridView.Rows.Clear();
            assessmentDataGridView.Columns.Clear();

            assessmentDataGridView.Columns.Add("ID", "ID");
            assessmentDataGridView.Columns.Add("Assessment", "Assessment");
            assessmentDataGridView.Columns.Add("Link", "Linked To");
            assessmentDataGridView.Columns.Add("Weight", "Weight");
            

            AssessmentTypeManager atm = new AssessmentTypeManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            AssessmentTypeObjectList atol = atm.GetTypesWeights(UserManager.CurrentUser.Id);
            

            foreach (AssessmentType at in atol)
            {

                assessmentDataGridView.Rows.Add(
                    new object[] { 
                        at.ID,
                        at.Name,
                        at.IsLinked && at.Weight.Type_Relational > -1 ? ((AssessmentType)atol[at.Weight.Type_Relational]).Name : "N/A",
                        !at.IsLinked && at.Weight.Weight > 0 ? at.Weight.Weight.ToString() : "N/A"
                    }
                );
            }
            
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fCreateAssessmentType fcat = new fCreateAssessmentType();
            fcat.StartPosition = FormStartPosition.CenterParent;
            this.Visible = false;
            fcat.ShowDialog(this);
            this.Visible = true;

            LoadAssessmentTypes();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssessmentTypeManager atm = new AssessmentTypeManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            atm.Delete(Int32.Parse(assessmentDataGridView.SelectedRows[0].Cells[0].Value.ToString()));

            LoadAssessmentTypes();
        }
    }
}
