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
    public partial class fSubjects : Form
    {
        private SubjectManager subject_manager;
        private ClassManager class_manager;

        public fSubjects()
        {
            InitializeComponent();
            
            subject_manager = new SubjectManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
            class_manager = new ClassManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            LoadList();
            LoadSubjectsToList();
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

            //classComboBox.Items.Clear();
            //class_manager.LoadToComboBox(classComboBox);
            
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
                
                //int class_id = Convert.ToInt32(((ComboItem)classComboBox.SelectedItem).Id);
                List<Subject> subject_list = subject_manager.GetSubjects(SemesterManager.CurrentSemester);

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

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Clear all subjects associated with Semester and Class in order to update new list
            /***** DANGEROUS *****/
            //subject_manager.ClearClassSubjects(Convert.ToInt32(((ComboItem)classComboBox.SelectedItem).Id));

            int count = 0;
            foreach (Subject subject in subjectCheckListBox.CheckedItems)
            {
                if (subject_manager.SaveOrUpdateSubjectClass(subject, SemesterManager.CurrentSemester))
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
            Opacity = .10;
            new_subject_form.ShowDialog();
            LoadList();
            Opacity = 100;
            LoadSubjectsToList();
        }

        private void Subjects_Form_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void subjectCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject subject = ((Subject)subjectCheckListBox.SelectedItem);

            if (subjectCheckListBox.GetItemChecked(subjectCheckListBox.SelectedIndices[0]))
                subject_manager.SaveOrUpdateSubjectClass(subject, SemesterManager.CurrentSemester);
            else
            {
                //delete subject from subjectclass
                subject_manager.DeleteClassSubject(subject.Id, SemesterManager.CurrentSemester);
            }
        }
    }
}
