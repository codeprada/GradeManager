using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Grade_Manager_DB_Controller
{
    

    public partial class LineGraph : Form
    {
        StatsManager statistics_manager;

        public LineGraph()
        {
            InitializeComponent();

            LoadStudents();
            LoadSubjects();
            LoadAssessment_Types();

            statistics_manager = new StatsManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            //chartPanel.Controls.Add(GenerateChart(new StatisticsDataObject[] { statistics_manager.Get(1, 2, 2) }, chartPanel.Width, chartPanel.Height));
        }

        private Chart GenerateChart(StatisticsDataObject[] series_data, int width, int height)
        {
            Chart chart = new Chart()
            {
                Width = width,
                Height = height
            };
            ChartArea chartArea = new ChartArea("ChartArea");
            chart.Dock = DockStyle.Fill;
            //chartArea.AlignmentOrientation = AreaAlignmentOrientations.Horizontal;
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisY.MajorGrid.LineWidth = 0;

            chart.ChartAreas.Add(chartArea);
            chart.ChartAreas[0].AxisY.Maximum = 100;
            chart.ChartAreas[0].AxisY.Minimum = 0;

            Series series;
            int count = 0;

            foreach (StatisticsDataObject sdo in series_data)
            {
                if ((series = chart.Series.FindByName(sdo.Name)) == null)
                {
                    series = chart.Series.Add(sdo.Name);
                    series.ChartType = SeriesChartType.Line;
                }
                foreach (KeyValuePair<string, double> value in sdo.Assessments)
                {
                    series.Points.Add(
                        new DataPoint()
                        {
                            AxisLabel = value.Key,
                            YValues = new double[] { value.Value }
                        }
                    );
                    
                }

                count++;
            }

            //Legend legend = new Legend("Legend");




            return chart;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem != null && subjectComboBox.SelectedItem != null)
            {
                List<StatisticsDataObject> sdo_buffer = new List<StatisticsDataObject>();

                foreach (object items in studentCheckedListBox.CheckedItems)
                {
                    //((Student)items)
                    //Convert.ToInt32(((ComboItem)subjectComboBox.SelectedItem).Id)
                    sdo_buffer.Add(statistics_manager.Get(
                        ((Student)items).ID,
                        Convert.ToInt32(((ComboItem)subjectComboBox.SelectedItem).Id),
                        Convert.ToInt32(((ComboItem)typeComboBox.SelectedItem).Id)
                    ));
                }

                if(chartPanel.Controls.Count > 0)
                    chartPanel.Controls.RemoveAt(0);

                chartPanel.Controls.Add(GenerateChart(sdo_buffer.ToArray(), chartPanel.Width, chartPanel.Height));
            }
            else
                MessageBox.Show("Selected a subject and type of assignment first");
        }

        private void LoadSubjects()
        {
            SubjectManager subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            subject_manager.LoadToComboBox(subjectComboBox, SemesterManager.CurrentSemester.Id);
        }

        private void LoadAssessment_Types()
        {
            Assessment_Manager assessment_manager = new Assessment_Manager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            assessment_manager.LoadToComboBox(typeComboBox, DB_Object.TYPE);
        }

        private void LoadStudents()
        {

            Student[] students = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING).Get();

            studentCheckedListBox.Items.AddRange(students);
        }

    }
}
