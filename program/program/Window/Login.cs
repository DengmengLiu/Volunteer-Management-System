using program;
using program.Domain;
using program.Domain.DBConnection;
using program.Window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            id.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            pass.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            pass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            id.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pass.UseSystemPasswordChar = true;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pass.UseSystemPasswordChar = false;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();

            this.Hide();
            signupForm.Show();

        }

        private void log_Click(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(id.Text, out userId))
            {
                MessageBox.Show("Please enter a valid user ID.");
                return;
            }

            string password = pass.Text;

            User user = new User();
            // Check user login
            User userInfo = user.LoginCheck(Convert.ToInt32(id.Text), pass.Text);
            if (userInfo != null)
            {
                if (userInfo.Authority == AuthorityType.User)
                {
                    string username = userInfo.Name;
                    // Create and show the user dashboard
                    Dashboard dashboard = new Dashboard(userId, username);

                    dashboard.Show();
                    this.Hide(); 
                }
                if (userInfo.Authority == AuthorityType.Administrator)  
                {
                    // Create and show the administrator page
                    AdministratorPage adminpage = new AdministratorPage();
                    adminpage.Show();
                    this.Hide(); 
                }
            }

            else
            {
                MessageBox.Show("Id or password not match!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
