using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Manager
{
    public partial class CreateProfile : Form
    {
        private ProfileManager profile_manager;

        public CreateProfile()
        {
            InitializeComponent();

            profile_manager = new ProfileManager(Database_Constants.DB_CONNECTION_STRING);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Profiles profile_data = new Profiles()
            {
                Current_term = (int)currentTermNumeric.Value,
                
            };
            
            
            //verify that this is complete

            if (profile_manager.CreateProfile(profile_data))
            {
                statusLabel.Text = "Profile successfully created.";
            }
            else
            {
                statusLabel.Text = "There was an error creating profile.";
            }
        }
    }
}
