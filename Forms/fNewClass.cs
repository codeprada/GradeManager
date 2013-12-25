using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{

    public partial class NewClass : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public NewClass()
        {
            InitializeComponent();


            //LoadClasses();

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            ClassManager cm = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            
            statusToolStrip.Text = ("Class Creation: " + ((cm.CreateClass(classTxt.Text) > -1) ? "Successful" : "Unsuccessful"));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            classTxt.Clear();
            Close();
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

        
        private void LoadClasses()
        {
            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_CLASSES;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            //classesComboBox.Items.Add(new ComboItem() { Text = reader["class_name"], Id = reader["class_id"] });
                        }
                    }
                }
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_MouseEnter(object sender, EventArgs e)
        {
            Styles.Button_MouseEnter(sender, e);
        }

        private void createBtn_MouseLeave(object sender, EventArgs e)
        {
            Styles.Button_MouseLeave(sender, e);
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.MouseDown_Drag(this, e);
        }

        private void NewClass_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }
    }
}
