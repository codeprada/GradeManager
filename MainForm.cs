//db_password: 756d3f188244c06453f219162bfb3f0908a57ba4
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Grade_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login_form = new LogIn();
            login_form.ShowDialog(this);
        }
    }
}
