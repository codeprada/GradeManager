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
            if (usernameTxt.Text != String.Empty && pass2Txt.Text != String.Empty && pass1Txt.Text != String.Empty && firstTxt.Text != String.Empty && lastTxt.Text != String.Empty)
            {
                if (pass1Txt.Text == pass2Txt.Text)
                {
                    UserManager usr_man = new UserManager(GradeManager_SQLite_DB_Controller.CONNECTION_STRING);

                    if (usr_man.CreateUser(new User()
                    {
                        Name = usernameTxt.Text,
                        Password = pass1Txt.Text,
                        FirstName = firstTxt.Text,
                        LastName = lastTxt.Text
                    }) == 1)
                    {
                        newUserStatusLabel.Text = "Account successfully created!";
                        Close();
                    }
                    else
                        newUserStatusLabel.Text = "Oops! There was an error while creating your account.";
                }
                else
                    newUserStatusLabel.Text = "Passwords do not match! Please enter them again.";
            }
            else
                newUserStatusLabel.Text = "Fill out the entire form before attempting to create account";
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseDown(sender, e);
        }

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseEnter(sender, e);
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Styles.PictureBox_MouseLeave(sender, e);
        }

        private void closePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Styles.PictureBox_MouseUp(sender, e);
        }

        private void NewUser_Paint(object sender, PaintEventArgs e)
        {
            Control s = sender as Form;

            s.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, s.Width + 1, s.Height + 1, 4, 4));
        }
    }
}
