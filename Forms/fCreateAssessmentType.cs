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
    public partial class fCreateAssessmentType : Form
    {
        public fCreateAssessmentType()
        {
            InitializeComponent();

            LoadAssessmentTypes();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAssessmentTypes()
        {
            AssessmentManager assessment_manager = new AssessmentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            assessment_manager.LoadToComboBox(linkToComboBox, DB_Object.TYPE);
            linkToComboBox.Items.Insert(0, new ComboItem() { Id = -1, Text = "None" });
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            AssessmentTypeManager assess_man = new AssessmentTypeManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            


            AssessmentType at = new AssessmentType();
            at.IsLinked = yesRadioButton.Checked;
            at.Name = assessTypeNameTxt.Text;
            at.Weight = new AssessmentWeight();
            at.Weight.Weight = (double)weightNumericUpDown.Value;
            at.Weight.Type_Relational = linkToComboBox.SelectedItem == null ? -1 : (int)((ComboItem)linkToComboBox.SelectedItem).Id;

            if (assess_man.Save(at))
                MessageBox.Show("Saved");
            else
                MessageBox.Show("Unsuccessful");
            
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
            {
                linkedToGroupBox.Visible = true;
                weightingGroupBox.Visible = true;
            }
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noRadioButton.Checked)
            {
                linkedToGroupBox.Visible = false;
                weightingGroupBox.Visible = true;
            }
        }


    }
}
