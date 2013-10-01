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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void lineGraphBtn_Click(object sender, EventArgs e)
        {
            LineGraph lg = new LineGraph();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.WindowState = FormWindowState.Maximized;
            lg.ShowDialog();
        }
    }
}
