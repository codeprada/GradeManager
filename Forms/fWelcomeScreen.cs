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

namespace Grade_Manager
{
    public partial class fWelcomeScreen : Form
    {
        public fWelcomeScreen()
        {
            InitializeComponent();
            

        }

        public static void Run(object state)
        {
            AutoResetEvent a = state as AutoResetEvent;

            fWelcomeScreen f = new fWelcomeScreen();
            f.Show();

            Application.DoEvents(); //process the Show function
            //Processing here
            Thread.Sleep(1000);

            f.Close();
            a.Set();
        }

        public static void VerifyStateOfLicense()
        {
            //Thread.Sleep(2000);
        }
    }
}
