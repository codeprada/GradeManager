using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Manager_DB_Controller
{
    public partial class fHelp : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        private List<string> help_content;

        public fHelp()
        {
            InitializeComponent();

            help_content = new List<string>();

            Initialize();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                cp.Style |= 0x40000;
                return cp;
            }
        }

        private void Initialize()
        {
            topicTreeView.Nodes.Clear();

            int counter = 0;

            var xml_doc = XDocument.Load("Resources\\help.xml");

            var topics = from t in xml_doc.Descendants("topic")
                         select new
                         {
                             Title = (string)t.Attribute("title"),
                             Sections = from s in t.Descendants("section")
                                        select new
                                        {
                                            Title = (string)s.Attribute("title"),
                                            Body = s.Value
                                        }
                         };

            foreach (var t in topics)
            {
                TreeNode topic_node = topicTreeView.Nodes.Add(t.Title);

                foreach (var s in t.Sections)
                {
                    TreeNode section_node = topic_node.Nodes.Add(s.Title);
                    section_node.Tag = s.Body;
                    //help_content.Add(s.Body);
                }
            }
        }

        private void topicTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                articleRichTextBox.Text = (string)e.Node.Tag;
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fHelp_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
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
    }
}
