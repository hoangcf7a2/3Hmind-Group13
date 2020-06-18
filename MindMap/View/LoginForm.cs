using MindMap.Controllers;
using MindMap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindMap.View
{
    public partial class LoginForm : Form
    {
        public bool isSign = false;
        public LoginForm()
        {
            InitializeComponent();
            lbShowCheckComfirm.TextChanged += LbShowCheckComfirm_TextChanged;
            btnSignUp.Enabled = false;
        }

        private void LbShowCheckComfirm_TextChanged(object sender, EventArgs e)
        {
            if(lbShowCheckComfirm.Text != "Password Comfirm Corect")
            {
                btnSignUp.Enabled = false;
            }    
            else
            {
                btnSignUp.Enabled = true;
            }    
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lbSignin_Click(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.FromArgb(250, 250, 251);
            lbSignUp.BackColor = Color.White;
            pnSignIn.BringToFront();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.FromArgb(250, 250, 251);
            lbSignin.BackColor = Color.White;
            pnSignUp.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbSignUp_Click(lbSignUp, new EventArgs());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbSignin_Click(lbSignin, new EventArgs());
        }

        private void tbComfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbComfirmPassword.Text != "")
            {
                if(tbComfirmPassword.Text != tbPasswordSignUp.Text)
                {
                    lbShowCheckComfirm.ForeColor = Color.Red;
                    lbShowCheckComfirm.Text = "Password Comfirm Incorect";
                }
                else
                {
                    lbShowCheckComfirm.ForeColor = Color.Green;
                    lbShowCheckComfirm.Text = "Password Comfirm Corect";
                }    
            }   
            else
                lbShowCheckComfirm.Text = "";
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (lbShowCheckComfirm.Text == "Password Comfirm Corect")
            {
                bool a = UserController.AddUser(new User() { Username = tbUsernameSignUp.Text, Pass = tbPasswordSignUp.Text });
                if (a)
                {
                    MessageBox.Show("Create Account Success");
                }
                else
                {
                    MessageBox.Show("Create Account Failse");
                }
            }
                
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            isSign = UserController.CanSignIn(tbUsername.Text, tbPassword.Text);
            if(isSign)
            {
                
                this.Hide();
                UserController.CurrentUser = this.tbUsername.Text;
                MainPage main = new MainPage();
                main.SetName(this.tbUsername.Text);
                main.Show();
            }   
            else
            {
                MessageBox.Show("Wrong username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainPage main = new MainPage();
            main.SetName("Guest");
            main.Show();
        }
    }
}
