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
        private int assess_type_id;
        private AssessmentTypeManager assess_man;

        public fCreateAssessmentType(int update_assess_type_id = -1)
        {
            assess_type_id = update_assess_type_id;
            
            InitializeComponent();

            assess_man = new AssessmentTypeManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            LoadAssessmentTypes();

            if (assess_type_id > -1)
                LoadDefaultValues();            
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

        private void LoadDefaultValues()
        {
            AssessmentType at = assess_man.GetTypeWeight(assess_type_id, UserManager.CurrentUser.Id);

            assessTypeNameTxt.Text = at.Name;
            yesRadioButton.Checked = at.IsLinked;
            noRadioButton.Checked = !at.IsLinked;
            weightNumericUpDown.Value = at.Weight.Weight < (double)weightNumericUpDown.Minimum ? (decimal)weightNumericUpDown.Minimum : (decimal)at.Weight.Weight;
            linkToComboBox.SelectedItem = linkToComboBox.Items.Cast<ComboItem>().Where(x => (int)x.Id == at.Weight.Type_Relational).Select(x => x).First();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            AssessmentType at = new AssessmentType();
            at.IsLinked = yesRadioButton.Checked;
            at.Name = assessTypeNameTxt.Text;
            at.Weight = new AssessmentWeight();
            at.Weight.Weight = (double)weightNumericUpDown.Value;
            at.Weight.Type_Relational = linkToComboBox.SelectedItem == null || !at.IsLinked ? -1 : (int)((ComboItem)linkToComboBox.SelectedItem).Id;

            bool status;

            //Check whether we are updating or saving
            //if assess_type_id is less than 0 then we are saving a new Assessment Type
            if (assess_type_id > -1)
            {
                at.ID = assess_type_id;
                at.Weight.Type = assess_type_id;
                at.Weight.ID = new WeightManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING, UserManager.CurrentUser.Id)
                    .GetWeight(UserManager.CurrentUser.Id, assess_type_id).ID;
                status = assess_man.Update(at);
            }
            else
            {
                status = assess_man.Save(at);
            }

            if (status)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Unsuccessful");
            
        }

        private bool Save(AssessmentType assess_type)
        {
            return false;
        }

        private bool Update(AssessmentType assess_type)
        {
            return false;
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

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void fCreateAssessmentType_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }


    }
}
