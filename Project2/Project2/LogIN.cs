using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Project2
{
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }

       
        string[,] login = new string[2, 2];
        int loginCount = 0;
        ToolTip tt = new ToolTip();



        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (loginCount == 0)
            {
                login[0, 0] = username;
                login[0, 1] = password;
            }
            else
            {
                login[1, 0] = username;
                login[1, 1] = password;
            }
            LoginHandler loginHandler = new LoginHandler();
            if (loginHandler.Validate(username, password) == true) 
            {


                if ((login[0, 0] == login[1, 0]) && (login[0, 1] == login[1, 1]))
                {
                    MessageBox.Show("User Exists");
                }
                else
                {
                    MessageBox.Show("Logged in successfully!","Loged in",MessageBoxButtons.OK);
                    txtUserName.Text = "Username";
                    txtPassword.Text = "Password";
                    PlaneSelect planeSelect = new PlaneSelect();
                    planeSelect.Show();
                    this.Hide();
                }
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = Interaction.InputBox("Choose an username", " ").ToString();
            string password = Interaction.InputBox("Choose a password", " ").ToString();

            LoginHandler handler = new LoginHandler();
            LoginFileHandler loginFile = new LoginFileHandler();
            if (handler.checkNull(username, password) == true) 
            {
                if (handler.registervalidation(username)==true)
                {
                    MessageBox.Show("User exist, try an other name");
                }
                else
                {
                    handler.sendEvent += loginFile.register;
                    handler.loginEvent(username, password);
                    MessageBox.Show("User have been added");
                    PlaneSelect planeSelect = new PlaneSelect();
                    planeSelect.Show();
                    this.Hide();
                }
            }

        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            if (lblUsername.Text == "") 
            {
                tt.Show("Jack", txtUserName);
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (lblPassword.Text=="")
            {
                tt.Show("98", txtPassword);
            }
        }

        private void LogIN_Shown(object sender, EventArgs e)
        {
            txtUserName.Text = "Jack";
            txtPassword.Text = "98";
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            tt.Hide(txtUserName);
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            tt.Hide(txtPassword);
        }

       

        private void linkRegister_MouseHover(object sender, EventArgs e)
        {
            linkRegister.BackColor = Color.White;
            
        }

        private void linkRegister_MouseLeave(object sender, EventArgs e)
        {
            linkRegister.BackColor = Color.Transparent;
        }
    }
}
