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

        public Rank()
        {
            InitializeComponent();

            subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            subject_manager.LoadToComboBox(subjectComboBox);

            subjectComboBox.Items.Insert(0, new ComboItem() { Id = -1, Text = "None" });

            rank_manager = new Ranks_Manager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
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
    }
}
