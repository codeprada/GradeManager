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
        //Dictionary<string, Color> names_to_colors;
        //KnownColor[] allColors;

        public LineGraph()
        {
            InitializeComponent();

            LoadStudents();
            LoadSubjects();
            LoadAssessment_Types();

            //names_to_colors = new Dictionary<string, Color>();

            //System.Array colorsArray = Enum.GetValues(typeof(KnownColor));
            //allColors = new KnownColor[colorsArray.Length];

            //Array.Copy(colorsArray, allColors, colorsArray.Length);

            statistics_manager = new StatsManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            //chartPanel.Controls.Add(GenerateChart(new StatisticsDataObject[] { statistics_manager.Get(1, 2, 2) }, chartPanel.Width, chartPanel.Height));
        }

        private Chart GenerateChart(StatisticsDataObject[] series_data, int width, int height)
        {
            /*Color color_buffer;
            Random r_color = new Random(DateTime.Now.Millisecond);

            foreach (StatisticsDataObject s in series_data)
            {
                if (!names_to_colors.ContainsKey(s.Name))
                {
                    do
                    {
                        color_buffer = ControlPaint.Dark(Color.FromName(allColors[r_color.Next(0, allColors.Length - 1)].ToString()));
                        //color_buffer = Color.FromArgb(color_buffer.R / 2, color_buffer.G / 2, color_buffer.B / 2);
                    } while (names_to_colors.ContainsValue(color_buffer));
                    names_to_colors.Add(s.Name, color_buffer);
                }
            }*/
            
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
            chartArea.AxisY.Interval = 5;
            chartArea.AxisY.Title = "Grades";
            chartArea.AxisY.MajorGrid.Enabled = chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineWidth = chartArea.AxisX.MajorGrid.LineWidth = 1;
            chartArea.AxisY.MajorGrid.LineColor = chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;

            chart.ChartAreas.Add(chartArea);
            chart.ChartAreas[0].AxisY.Maximum = 100;
            chart.ChartAreas[0].AxisY.Minimum = 0;

            Legend legend = new Legend("Grades");
            legend.Docking = Docking.Right;
            legend.Title = "Students";

            chart.Legends.Add(legend);

            Series series;
            int count = 0;

            double minimum = 100;

            foreach (StatisticsDataObject sdo in series_data)
            {
                if ((series = chart.Series.FindByName(sdo.Name)) == null)
                {
                    series = chart.Series.Add(sdo.Name);
                    if (sdo.Name == "AVERAGE")
                    {
                        series.BorderDashStyle = ChartDashStyle.Dot;
                        series.Color = Color.Blue;
                        
                    }
                    //series.Color = names_to_colors[sdo.Name];
                    series.ChartType = SeriesChartType.Line;
                    series.Legend = "Grades";
                    series.BorderWidth = 3;
                    
                }
                foreach (KeyValuePair<string, double> value in sdo.Assessments)
                {
                    series.Points.Add(
                        new DataPoint()
                        {
                            AxisLabel = value.Key.Replace("Quiz ", "").Replace("Test ", "").Replace("Exam ", ""),
                            YValues = new double[] { value.Value },
                            
                        }
                    );
                    if (value.Value < minimum)
                        minimum = value.Value;
                    
                }

                count++;
            }

            //Legend legend = new Legend("Legend");

            //chart.ChartAreas[0].AxisY.Minimum = minimum - (minimum % 5);


            return chart;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem != null && subjectComboBox.SelectedItem != null)
            {
                List<StatisticsDataObject> sdo_buffer = new List<StatisticsDataObject>();

                //Grade of each assessment
                sdo_buffer.Add(statistics_manager.Get(
                    Convert.ToInt32(((ComboItem)subjectComboBox.SelectedItem).Id),
                    Convert.ToInt32(((ComboItem)typeComboBox.SelectedItem).Id)
                ));

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
            AssessmentManager assessment_manager = new AssessmentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            assessment_manager.LoadToComboBox(typeComboBox, DB_Object.TYPE);
        }

        private void LoadStudents()
        {

            Student[] students = new StudentManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING).Get();

            studentCheckedListBox.Items.AddRange(students);
        }

    }
}
