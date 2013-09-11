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

            report_manager.GenerateReport(templateFileTxtBox.Text, SemesterManager.CurrentSemester.Id, saveFileTxtBox.Text);
        }

        private void browseTemplateBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                templateFileTxtBox.Text = openFileDialog1.FileName;
            }
        }

        private void browseSaveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveFileTxtBox.Text = saveFileDialog1.FileName;
            }
        }
    }
}
