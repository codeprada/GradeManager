using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grade_Manager_DB_Controller;
using System.Data.SQLite;

namespace Grade_Manager
{
    public partial class Semester_Form : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;

        public Semester_Form()
        {
            InitializeComponent();

            LoadList();
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

        private void LoadList()
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var adapter = new SQLiteDataAdapter(GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_SEMESTERS_TREE, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);
                    connection.Open();

                    using (var grid_table = new DataTable())
                    {
                        adapter.Fill(grid_table);
                        semesterGridView.DataSource = grid_table;
                        semesterGridView.Columns["ID"].Visible = false;
                        foreach (DataGridViewColumn column in semesterGridView.Columns)
                        {
                            column.ReadOnly = true;
                        }
                    }
                }
            }

            if (semesterGridView.Rows.Count == 0)
                newSemesterLabel.Visible = true;
            else
                newSemesterLabel.Visible = false;
        }

        private TreeNode GenerateTree(IDataReader reader)
        {
            TreeNode parent = new TreeNode("Select A Semester");
            TreeNode buffer;
            TreeNode yearNode;

            while (reader.Read())
            {
                string class_name = (string)reader["class_name"];
                string year = (Convert.ToString(reader["starting_school_year"])) + " - " + (Convert.ToString(reader["ending_school_year"]));
                string term = String.Format("Term #{0}", Convert.ToString(reader["current_term"]));
                string id = reader["semester_id"].ToString();

                

                if (!parent.Nodes.ContainsKey(class_name))
                    buffer = parent.Nodes[parent.Nodes.Add(new TreeNode(class_name))];
                else
                    buffer = parent.Nodes[parent.Nodes.IndexOfKey(class_name)];
                

                if (!buffer.Nodes.ContainsKey(year))
                    yearNode = buffer.Nodes[buffer.Nodes.Add(new TreeNode(year))];
                else
                    yearNode = buffer.Nodes[buffer.Nodes.IndexOfKey(year)];


                if (!yearNode.Nodes.ContainsKey(term))
                {
                    TreeNode termNode = yearNode.Nodes[yearNode.Nodes.Add(new TreeNode(term))];
                    termNode.Name = id;//Convert.ToInt32((reader["semester_id"])).ToString();                    
                }
                


            }

            return parent;
        }

        private ListViewItem GenerateItem(IDataReader reader)
        {
            ListViewItem item = null;
            
            string class_name = (string)reader["class_name"];
            string start_year = (Convert.ToString(reader["starting_school_year"]));
            string end_year = (Convert.ToString(reader["ending_school_year"]));
            string term = Convert.ToString(reader["current_term"]);
            string id = Convert.ToString(reader["semester_id"]);

            item = new ListViewItem(id);
            item.SubItems.Add(class_name);
            item.SubItems.Add(term);
            item.SubItems.Add(start_year);
            item.SubItems.Add(end_year);
            

            return item;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateSemester c_form = new CreateSemester();
            c_form.StartPosition = FormStartPosition.CenterParent;
            c_form.Parent = this.Parent;
            //this.Close();
            Opacity = 10;
            c_form.ShowDialog();
            Opacity = 100;
            LoadList();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (semesterGridView.SelectedRows.Count > 0)
            {
                int id;
                if (Int32.TryParse(semesterGridView.SelectedRows[0].Cells["ID"].Value.ToString(), out id))
                {
                    SemesterManager profile_manager = new SemesterManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

                    //MessageBox.Show((string)treeView1.SelectedNode.Name);
                    SemesterManager.CurrentSemester = profile_manager.GetSemester(id);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Select a semester from the list before trying to load.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loadBtn_MouseEnter(object sender, EventArgs e)
        {
            Styles.Button_MouseEnter(sender, e);
        }

        private void loadBtn_MouseLeave(object sender, EventArgs e)
        {
            Styles.Button_MouseLeave(sender, e);
        }

        private void semesterGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            loadBtn_Click(sender, e);
        }

        private void Semester_Form_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));

        }

        private void semesterGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            semesterGridView.CurrentCell = semesterGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (semesterGridView.SelectedRows.Count > 0)
            {
                int id;
                if (Int32.TryParse(semesterGridView.SelectedRows[0].Cells["ID"].Value.ToString(), out id))
                {
                    

                    if (MessageBox.Show("WARNING!\n\nNote that deleting a semester will also delete all the grades associated with it. Do you want to proceed with deletion?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        SemesterManager semester_manager = new SemesterManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
                        if (semester_manager.DeleteSemester(id, UserManager.CurrentUser.Id))
                            LoadList();
                    }
                }
            }

            
        }

    }
}
