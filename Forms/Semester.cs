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
        public Semester_Form()
        {
            InitializeComponent();

            LoadList();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id;
                if (Int32.TryParse(listView1.SelectedItems[0].Text, out id))
                {
                    SemesterManager profile_manager = new SemesterManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

                    //MessageBox.Show((string)treeView1.SelectedNode.Name);
                    SemesterManager.CurrentSemester = profile_manager.GetSemester(id);
                    this.Close();

                    
                }
                else
                {
                    MessageBox.Show("Select a semester from the list before trying to load.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        private void LoadList()
        {
            //profileComboList.Items.Clear();
            //treeView1.Nodes.Clear();
            listView1.Items.Clear();

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
                                listView1.Items.Add(item);
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


        private void createNewBtn_Click(object sender, EventArgs e)
        {
            CreateSemester c_form = new CreateSemester();
            c_form.StartPosition = FormStartPosition.CenterParent;
            //this.Close();
            c_form.ShowDialog();
            LoadList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
