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
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

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

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                //cp.Style |= 0x40000;
                return cp;
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
            //this.Visible = false;
            fcat.ShowDialog(this.Parent);
            //this.Visible = true;

            LoadAssessmentTypes();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssessmentTypeManager atm = new AssessmentTypeManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            atm.Delete(Int32.Parse(assessmentDataGridView.SelectedRows[0].Cells[0].Value.ToString()));

            LoadAssessmentTypes();
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCreateAssessmentType fcat = new fCreateAssessmentType(Int32.Parse(assessmentDataGridView.SelectedRows[0].Cells[0].Value.ToString()));
            fcat.StartPosition = FormStartPosition.CenterParent;
            //this.Visible = false;
            fcat.ShowDialog(this.Parent);
            //this.Visible = true;

            LoadAssessmentTypes();
        }

        private void closePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void closePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }

        private void menuPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void fAssessmentType_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }

        private void assessmentDataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            assessmentDataGridView.CurrentCell = assessmentDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }
}
