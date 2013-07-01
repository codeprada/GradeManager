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
    public partial class Profile_Form : Form
    {
        public Profile_Form()
        {
            InitializeComponent();

            LoadList();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((string)treeView1.SelectedNode.Name);
        }

        private void LoadList()
        {
            //profileComboList.Items.Clear();
            treeView1.Nodes.Clear();

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_PROFILES_TREE;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        treeView1.Nodes.Add(GenerateTree(reader));
                    }
                        

                }
            }
        }

        private TreeNode GenerateTree(IDataReader reader)
        {
            TreeNode parent = new TreeNode("Select A Profile");

            while (reader.Read())
            {
                string class_name = (string)reader["class_name"];
                string year = (Convert.ToString(reader["starting_school_year"])) + " - " + (Convert.ToString(reader["ending_school_year"]));
                string term = String.Format("Term #{0}", Convert.ToString(reader["current_term"]));

                TreeNode buffer;

                if (!parent.Nodes.ContainsKey(class_name))
                    buffer = parent.Nodes[parent.Nodes.Add(new TreeNode(class_name))];
                else
                    buffer = parent.Nodes[parent.Nodes.IndexOfKey(class_name)];
                

                TreeNode yearNode;

                if (!buffer.Nodes.ContainsKey(year))
                    yearNode = buffer.Nodes[buffer.Nodes.Add(new TreeNode(year))];
                else
                    yearNode = buffer.Nodes[buffer.Nodes.IndexOfKey(year)];


                if (!yearNode.Nodes.ContainsKey(term))
                {
                    yearNode.Nodes.Add(new TreeNode(term));
                    yearNode.Name = Convert.ToInt32((reader["profile_id"])).ToString();
                }
                


            }

            return parent;
        }

        private void createNewBtn_Click(object sender, EventArgs e)
        {
            CreateProfile c_form = new CreateProfile();
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
