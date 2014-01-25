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
    public partial class Rank : Form
    {
        private SubjectManager subject_manager;
        private Ranks_Manager rank_manager;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public Rank()
        {
            InitializeComponent();

            subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            subject_manager.LoadToComboBox(subjectComboBox, SemesterManager.CurrentSemester);

            subjectComboBox.Items.Insert(0, new ComboItem() { Id = -1, Text = "Overall" });

            rank_manager = new Ranks_Manager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
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

        private void generateBtn_Click(object sender, EventArgs e)
        {
            rankDataGridView.Rows.Clear();
            rankDataGridView.Columns.Clear();

            rankDataGridView.Columns.Add("rank", "No.");
            rankDataGridView.Columns.Add("student", "Student Name");
            rankDataGridView.Columns.Add("grade", "Grade");

            int subject_id = -1;
            if (subjectComboBox.SelectedItem != null)
                subject_id = (int)((ComboItem)subjectComboBox.SelectedItem).Id;

            IEnumerable<Rank_Item> rank_items = rank_manager.GetRankings(subject_id).OrderByDescending(x => x.Average);

            int count = 0, track = 0;
            double last = -0.0, current;

            foreach (Rank_Item ri in rank_items)
            {
                track++;
                current = roundedRB.Checked ? Math.Round(ri.Average, 2) : ri.Average;
                if (last != current) count = track;

                rankDataGridView.Rows.Add(new object[] { count, ri.StuName, current });

                last = current;
                
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
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

        private void closePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void generateBtn_MouseEnter(object sender, EventArgs e)
        {
            Styles.Button_MouseEnter(sender, e);
        }

        private void generateBtn_MouseLeave(object sender, EventArgs e)
        {
            Styles.Button_MouseLeave(sender, e);
        }

        private void Rank_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }
    }
}
