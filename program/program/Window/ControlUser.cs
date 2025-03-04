using program.Domain;
using program.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.Window
{
    public partial class Form3 : Form
    {
        public int createOrUpdate = 0;
        AdministratorFunction function = new AdministratorFunction();
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Commit a modified or added user
        private void buttonSub_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = textBoxEmail.Text;
            user.Name = textBoxName.Text;
            user.Password = textBoxPassword.Text;
            user.Phone = textBoxPhone.Text;
            if (radioButton1.Checked)
            {
                user.Sex = Gender.Male;
            }
            else if (radioButton2.Checked)
            {
                user.Sex = Gender.Female;
            }
            else { user.Sex = Gender.Other; }
            if (checkBox_admin.Checked)
            {
                user.Authority = AuthorityType.Administrator;
            }
            else
            {
                user.Authority = AuthorityType.User;
            }


            if (createOrUpdate == 0)
            {
                function.AddUser(user);
                MessageBox.Show("success！", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                function.UpdateUser(user, createOrUpdate);
                this.Close();
                MessageBox.Show("success！please click 'Update User'again to fresh the page", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
