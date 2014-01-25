using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace Grade_Manager_DB_Controller
{
    public partial class NewSubject : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public NewSubject()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //subjectStatusLabel.Text = String.Empty;
            if (subjectTxt.Text != String.Empty)
            {
                statusToolStrip.Text = (CreateSubject(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subjectTxt.Text)));
                subjectTxt.Clear();
                subjectTxt.Focus();
            }
            else
            {
                statusToolStrip.Text = "Fill in the required information";
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

        private string CreateSubject(string subject)
        {
            string status = String.Empty;

            SubjectManager sm = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            try
            {
                if (sm.CreateSubject(subject) > 0)
                    status = subject + " was created successfully.";
            }
            catch (Exception e)
            {
                if (e.Message.Contains("unique"))
                    status = subject + " exists already.";
                else
                    status = "Error adding " + subject;
            }

            return status;
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewSubject_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }

        private void maximizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void maximizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void maximizePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void maximizePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }
    }
}
