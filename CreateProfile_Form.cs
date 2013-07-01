using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grade_Manager_DB_Controller;
using System.Data.SQLite;

namespace Grade_Manager
{
    public partial class CreateProfile : Form
    {
        private ProfileManager profile_manager;

        public CreateProfile()
        {
            InitializeComponent();
            //Set UP CLASSES!!!
            profile_manager = new ProfileManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            classesComboBox.DisplayMember = "Text";
            classesComboBox.ValueMember = "Id";

            LoadClasses();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            ProfileData profile = new ProfileData()
            {
                Description = profileDescriptionTxt.Text,
                OwnerId = UserManager.CurrentUser.Id,
                StartingSchoolYear = (int)startingSchoolYearNumeric.Value,
                EndingSchoolYear = (int)endingSchoolYearNumeric.Value,
                Term = (int)currentTermNumeric.Value,
                Class = Convert.ToInt32(((ComboItem)classesComboBox.SelectedItem).Id)
            };
            
            //verify that this is complete

            if (profile_manager.CreateProfile(profile))
                statusLabel.Text = "Profile successfully created.";
            else
                statusLabel.Text = "There was an error creating profile.";
            
            
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

                            classesComboBox.Items.Add(new ComboItem() { Text = reader["class_name"], Id = reader["class_id"] });
                        }
                    }
                }
            }
        }

        private void CreateProfile_UD(ProfileData pd)
        {

        }
    }
}
