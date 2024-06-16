using BusinessLayer;
using ModleLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siu_Gass_DataBaseSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(IsValidated()) {

                try {

                    UserClass1 user = UserDetails();
                    user = UaerBusiness.GetUserVerifiedBusiness(user);

                    if (user.uname && user.upass) {
                        this.Hide();
                        Form1 Mainapp = new Form1();
                        Mainapp.ShowDialog();

                    }
                    else {
                        if (user.uname == false)
                        {
                            MessageBox.Show("please enter the correct name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Pass.Clear();
                            User.Clear();
                            User.Focus();
                        }
                        if (user.upass == false) {
                            MessageBox.Show("please enter the correct password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Pass.Clear();
                            Pass.Focus();
                        }

                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool IsValidated()
        {

            if (User.Text.Trim() == string.Empty)
            {

                MessageBox.Show("please enter the user name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                User.Clear();
                User.Focus();
                return false;

            }


            if (User.Text.Trim() == string.Empty)
            {

                MessageBox.Show("please enter the password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                User.Clear();
                User.Focus();
                return false;

            }
            return true;

          
        }
        private UserClass1 UserDetails() 
        {

            UserClass1 user = new UserClass1()
            {
                user = User.Text,
                pass = Pass.Text,
                uname = false,
                upass = false


            };
            return user;
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
 
 