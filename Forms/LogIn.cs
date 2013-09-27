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
using Grade_Manager_DB_Controller;


namespace Grade_Manager
{
    public partial class LogIn : Form
    {

        private UserManager user_manager;

        public LogIn()
        {
            InitializeComponent();

            //initalize usermanager with the connection string in the app.config file
            user_manager = new UserManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);
        }

        /// <summary>
        /// Verifies with the UserManager class 
        /// if the user credentials are valid
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private int CheckCredentials(string username, string password)
        {
            return user_manager.IsValidUserCredentials(username, password);
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            loginStatusLabel.Visible = false;
            int id;
            //verify that the username and password is valid
            if ((id = CheckCredentials(usernameTxtBox.Text, passwordTxtBox.Text)) >= 0)
            {
                User usr = new User();
                usr.Id = id;
                //should be hashed
                //usr.Password = passwordTxtBox.Text; //shouldn't have stored the password here
                usr.Name = usernameTxtBox.Text;

                passwordTxtBox.Clear();

                //Store the current user within this static variable
                UserManager.CurrentUser = usr;
                
                //Profile_Form p_form = new Profile_Form();

                

                //p_form.ShowDialog();

               

                this.Close();
                
            }
            else
            {
                //incorrect user credentials
                loginStatusLabel.Visible = true;
                //usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createUsrBtn_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.StartPosition = FormStartPosition.CenterParent;
            nu.ShowDialog();
          
        }
    }
}
