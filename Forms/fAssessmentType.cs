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

        }
    }
}
