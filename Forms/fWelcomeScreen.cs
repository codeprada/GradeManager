using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Grade_Manager_DB_Controller;

namespace Grade_Manager
{
    public partial class fWelcomeScreen : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public fWelcomeScreen()
        {
            InitializeComponent();

            versionLabel.Text = "Pre-Release Version (Beta)\n" + Application.ProductVersion;
        }

        public static void Run(object state)
        {
            AutoResetEvent a = state as AutoResetEvent;

            fWelcomeScreen f = new fWelcomeScreen();
            f.Show();

            Application.DoEvents(); //process the Show function
            //Processing here
            

            f.Close();
            a.Set();
        }

        private void fWelcomeScreen_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            GradeManager_SQLite_DB_Controller gm_db_controller = new GradeManager_SQLite_DB_Controller();

            //Making sure database exists with the needed correct columns
            if (!gm_db_controller.IntegrityTest())
                gm_db_controller.CreateDatabase(); //Creates database

            Thread.Sleep(2000);
            
        }

        private void fWelcomeScreen_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
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
    }
}
