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
                return cp;
            }
        }

        private void LoadList()
        {
            /*//profileComboList.Items.Clear();
            //treeView1.Nodes.Clear();
            semesterListView.Items.Clear();

            //SELECT [semester_id], [Classes].[class_name], [starting_school_year], 
            //[ending_school_year], [current_term] FROM [Profiles] INNER JOIN [Classes] 
            //ON [Profiles].[class_id] = [Classes].[class_id] WHERE [Profiles].[account_id] = 
            //@account_id ORDER BY [Classes].[class_id] ASC

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_SEMESTERS_TREE;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        //treeView1.Nodes.Add(GenerateTree(reader));
                        ListViewItem item;
                        while (reader.Read())
                        {
                            item = GenerateItem(reader);
                            if (item != null)
                                semesterListView.Items.Add(item);
                        }
                    }
                        

                }
            }*/

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

    }
}
