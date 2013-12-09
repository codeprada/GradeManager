using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grade_Manager_DB_Controller
{
    public partial class Report : Form
    {
        ReportsManager report_manager;

        public Report()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            report_manager = new ReportsManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            //Dictionary<string, Stream> images = new Dictionary<string, Stream>();
            //images["logo"] = ConvertToStream(Grade_Manager_DB_Controller.Properties.Resources.logo);

            report_manager.SaveAs = saveFileTxtBox.Text;
            report_manager.ReportHandler = ReportHandler;
            //report_manager.Images = images;

            report_manager.GenerateReport(SemesterManager.CurrentSemester.Id);
        }

        private void browseSaveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveFileTxtBox.Text = saveFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Handles the reporting events
        /// </summary>
        /// <param name="e"></param>
        private void ReportHandler(ReportEventArgs e)
        {
            if (!InvokeRequired)
            {
                if (reportsProgressBar.Maximum != e.Total)
                    reportsProgressBar.Maximum = e.Total;

                reportsProgressBar.Value = e.Counter;

                if (e.Counter == e.Total)
                    reportsProgressBar.Value = 0;
            }
            else
            {
                Invoke(report_manager.ReportHandler, new object[] { e });
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convert Image to a Stream
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private Stream ConvertToStream(Bitmap bitmap)
        {
            MemoryStream mem = new MemoryStream();
            bitmap.Save(mem, ImageFormat.Png);
            
            return mem;
        }
    }
}
