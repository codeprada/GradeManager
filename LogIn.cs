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
using System.Security;

namespace Grade_Manager
{
    public partial class LogIn : Form
    {

        private UserManager user_manager;

        public LogIn()
        {
            InitializeComponent();

            //initalize usermanager with the connection string in the app.config file
            user_manager = new UserManager(Database_Constants.DB_CONNECTION_STRING);
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

        unsafe private void logInBtn_Click(object sender, EventArgs e)
        {
            loginStatusLabel.Visible = false;
            int id;
            //verify that the username and password is valid
            if ((id = CheckCredentials(usernameTxtBox.Text, passwordTxtBox.Text)) >= 0)
            {
                User usr = new User();

                //Create the SecureString object
                SecureString secure_string;

                char[] secure_pass_char = passwordTxtBox.Text.ToCharArray();
                passwordTxtBox.Clear();
                //must be in an unsafe environment to create pointers
                fixed (char* secure_pointer = secure_pass_char)
                {
                    //Initialize SecureString
                    secure_string = new SecureString(secure_pointer, secure_pass_char.Length);
                    //string cannot be changed now
                    secure_string.MakeReadOnly();
                }

                usr.Id = id;
                usr.Password = secure_string;
                usr.Name = usernameTxtBox.Text;

                //Store the current user within this static variable
                UserManager.CurrentUser = usr;

                /*Profile profile_form = new Profile();
                
                profile_form.MdiParent = this.Owner;
                profile_form.Show();*/

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
    }
}
