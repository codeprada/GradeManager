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
    public partial class Subjects_Form : Form
    {
        private SubjectManager subject_manager;
        private ClassManager class_manager;

        public Subjects_Form()
        {
            InitializeComponent();

            

            subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            LoadList();
        }

        private void Subjects_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadList()
        {
            //Fast way to load a checklist
            //To String method in Subject object will be used as the checkboxitem's text
            subjectCheckListBox.Items.Clear();
            subjectCheckListBox.Items.AddRange(subject_manager.GetSubjects().ToArray());

            classComboBox.Items.Clear();
            class_manager.LoadToComboBox(classComboBox);
            
        }

        private void LoadSubjectsToList()
        {
            //MessageBox.Show(((ComboItem)classComboBox.SelectedItem).Text.ToString());
            if (SemesterManager.CurrentSemester == null)
            {
                MessageBox.Show("Please select a semester before attempting this action.");
            }
            else
            {
                if (classComboBox.SelectedItem != null)
                {
                    int class_id = Convert.ToInt32(((ComboItem)classComboBox.SelectedItem).Id);
                    List<Subject> subject_list = subject_manager.GetSubjects(SemesterManager.CurrentSemester.Id);

                    for (int i = 0; i < subjectCheckListBox.Items.Count; i++)
                    {
                        if ((subject_list.Count(x => x.Id == ((Subject)subjectCheckListBox.Items[i]).Id)) > 0)
                        {
                            subjectCheckListBox.SetItemChecked(i, true);
                        }
                        else
                        {
                            subjectCheckListBox.SetItemChecked(i, false);
                        }
                    }
                }
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Clear all subjects associated with Semester and Class in order to update new list
            subject_manager.ClearClassSubjects(Convert.ToInt32(((ComboItem)classComboBox.SelectedItem).Id));
            int count = 0;
            foreach (Subject subject in subjectCheckListBox.CheckedItems)
            {
                if (subject_manager.SaveSubjectToClass(subject, Convert.ToInt32(((ComboItem)classComboBox.SelectedItem).Id)))
                    count++;
            }

            MessageBox.Show(String.Format("Selected {0} subjects for your class", count), "Subject Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjectsToList();
        }

        private void addNewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewSubject new_subject_form = new NewSubject();
            new_subject_form.StartPosition = FormStartPosition.CenterParent;
            new_subject_form.ShowDialog();
            LoadList();
            LoadSubjectsToList();
        }

        private void Subjects_Form_Paint(object sender, PaintEventArgs e)
        {
            Form sf = sender as Form;

            sf.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, sf.Width, sf.Height, 5, 5));
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
