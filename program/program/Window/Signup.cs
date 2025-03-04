using program.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using User1;

namespace program
{
    public partial class Signup : Form
    {

        public Signup()
        {
            InitializeComponent();
            ucpass.TextChanged += new EventHandler(confirm_TextChanged);
        }
        private void confirm_TextChanged(object sender, EventArgs e)
        {
            string passwordText = upass.Text;
            string confirmPassword = ucpass.Text;

            if (string.IsNullOrEmpty(confirmPassword) || passwordText == confirmPassword)
            {
                error.Visible = false;
            }
            else
            {
                error.Visible = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            this.Close();

            loginForm.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string name = uname.Text;
            
            string selectedGender = gender.SelectedItem.ToString();
            Gender sex = (Gender)Enum.Parse(typeof(Gender), selectedGender);
            string phone = uphone.Text;
            string email = uemail.Text;
            string password = upass.Text;

            User user = new User();
            int newUserId = user.CreateUser(name, password, email, phone, sex);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}