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
    public partial class CreateAssessmentType : Form
    {
        public CreateAssessmentType()
        {
            InitializeComponent();

            LoadAssessmentTypes();
        }

        public void LoadAssessmentTypes()
        {
            assessmentDataGridView.DataSource = null;

            assessmentDataGridView.Columns.Add("ID", "ID");
            assessmentDataGridView.Columns.Add("Assessment", "Assessment");
            assessmentDataGridView.Columns.Add("IsLinked", "Is Linked?");
            assessmentDataGridView.Columns.Add("Link", "Link");
            assessmentDataGridView.Columns.Add("Weight", "Weight");
            assessmentDataGridView.Columns.Add("LinkAmount", "Link Amount");

            AssessmentTypeManager atm = new AssessmentTypeManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            AssessmentTypeObjectList atol = atm.GetTypesWeights(UserManager.CurrentUser.Id);


            foreach (AssessmentType at in atol)
            {
                //Is Linked DataGridViewComboBoxColumn
                DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
                combobox.ValueType = typeof(int);
                combobox.ValueMember = "Value";
                combobox.DisplayMember = "ID";

                using (var data = new DataTable())
                {
                    data.Columns.Add(new DataColumn("Value", typeof(int)));
                    data.Columns.Add(new DataColumn("ID", typeof(string)));
                    data.Rows.Add(1, "Yes");
                    data.Rows.Add(0, "No"); //column showing text of datagridviewcomboboxcolumn

                    combobox.DataSource = data;
                }

                

                assessmentDataGridView.Rows.Add(new object[] { at.ID, at.Name, combobox, at.Weight.Type_Relational, at.Weight.Weight});
            }
            
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
