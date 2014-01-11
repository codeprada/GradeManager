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
        private ReportsManager report_manager;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public Report()
        {
            InitializeComponent();

            LoadStudents();
        }

        private void LoadStudents()
        {
            StudentManager student_manager = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            foreach (Student s in student_manager.Get())
            {
                studentExcludeListCheckBox.Items.Add(new ComboItem() { Id = s.ID, Text = s.LastName + " " + s.FirstName });
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
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
            mem.Position = 0;
            
            return mem;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                report_manager = new ReportsManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

                Dictionary<string, Stream> images = new Dictionary<string, Stream>();
                images["logo"] = ConvertToStream(Grade_Manager_DB_Controller.Properties.Resources.logo);

                report_manager.SaveAs = saveFileDialog1.FileName;
                report_manager.ReportHandler = ReportHandler;
                report_manager.Images = images;

                report_manager.GenerateReport(SemesterManager.CurrentSemester.Id, studentExcludeListCheckBox.CheckedItems.Cast<ComboItem>().Select(x => (int)x.Id).ToArray());
            }
        }

        private void generateButton_MouseEnter(object sender, EventArgs e)
        {
            Styles.Button_MouseEnter(sender, e);
        }

        private void generateButton_MouseLeave(object sender, EventArgs e)
        {
            Styles.Button_MouseLeave(sender, e);
        }

        private void Report_Paint(object sender, PaintEventArgs e)
        {
            Form s = sender as Form;

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
                cp.Style |= 0x40000;
                return cp;
            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox ckbx in studentExcludeListCheckBox.Items)
            {
                ckbx.Checked = selectAllCheckBox.Checked;
            }

        }
    }
}
