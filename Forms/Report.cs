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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            ReportsManager report_manager = new ReportsManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            List<Reports> reports = report_manager.GenerateReport(SemesterManager.CurrentSemester.Id);
        }
    }
}
