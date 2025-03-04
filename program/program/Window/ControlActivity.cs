using program.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.Window
{
    public partial class Form2 : Form
    {
        public int createOrUpdate = 0;
        Tools.AdministratorFunction function = new Tools.AdministratorFunction();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Submit a modified or added activity
        private void buttonSub_Click(object sender, EventArgs e)
        {
            Domain.Activity activity = new Domain.Activity();
            activity.Name = textBoxName.Text;
            activity.StartTime = dateTimeST.Value;
            activity.EndTime = dateTimeET.Value;
            activity.Place = textBoxPlace.Text;
            try { activity.NoPeople = Convert.ToInt32(textBoxNP.Text); }
            catch { MessageBox.Show("Please Enter a int vaule for number of people!"); }

            activity.Description = textBoxDes.Text;
            if (activity.StartTime < activity.EndTime)
            {
                if (createOrUpdate == 0)
                {

                    function.AddActivity(activity);
                    MessageBox.Show("success！", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    function.UpdateActivity(activity, createOrUpdate);
                    this.Close();
                    MessageBox.Show("success！please click 'Update Activity'again to fresh the page", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("please type right time", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
