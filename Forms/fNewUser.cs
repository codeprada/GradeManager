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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            UserManager usr_man = new UserManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

            if (usr_man.CreateUser(new User()
            {
                Name = usernameTxt.Text,
                Password = pass1Txt.Text,
                FirstName = firstTxt.Text,
                LastName = lastTxt.Text
            }) == 1)
                newUserStatusLabel.Text = "Account successfully created!";
            else
                newUserStatusLabel.Text = "Oops! There was an error while creating your account.";
        }
    }
}
