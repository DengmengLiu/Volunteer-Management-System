using program.Domain;
using program.Domain.DBConnection;
using program.Tools.DataGridSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace program.Window
{
    public partial class AdministratorPage : Form
    {
        Tools.AdministratorFunction function = new Tools.AdministratorFunction();
        public AdministratorPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void EAdd(object sender, EventArgs e)
        {
            /* panelAdd.Visible = true;
             panelCheckActivity.Visible = false;*/
            Form2 form = new Form2();
            form.Show();

        }
        //Modify and delete operations for selected activities
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)  
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                string description = row.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                int people = Convert.ToInt32(row.Cells["noPeopleDataGridViewTextBoxColumn"].Value);
                int id = Convert.ToInt32(row.Cells["id"].Value);
                DateTime st = Convert.ToDateTime(row.Cells["startTimeDataGridViewTextBoxColumn"].Value);
                DateTime ed = Convert.ToDateTime(row.Cells["endTimeDataGridViewTextBoxColumn"].Value);
                string place = row.Cells["placeDataGridViewTextBoxColumn"].Value.ToString();

                Form2 form2 = new Form2();
                form2.createOrUpdate = id;
                form2.textBoxName.Text = name;
                form2.textBoxNP.Text = people.ToString();
                form2.textBoxDes.Text = description;
                form2.dateTimeST.Value = st;
                form2.dateTimeET.Value = ed;
                form2.textBoxPlace.Text = place;
                form2.Show();
                BUpdate_Click(sender, e);


            }

            if (e.ColumnIndex == 8 && e.RowIndex >= 0)  
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                function.DeleteActivity(id);
                BUpdate_Click(sender, e);
                //Console.WriteLine(id);

            }
        }
        //Get all activities
        public void BUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;


            List<Activity> list = function.ListAllActivities();
            dataGridView1.DataSource = list;
        }
        //Get all users
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            List<User> list = function.ListAllUsers();
            dataGridView2.DataSource = list;

        }
        //Modify and delete operations for selected users
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)  
            {
                
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string name = row.Cells["dataGridViewName"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                int id = Convert.ToInt32(row.Cells["UserId"].Value);
                var sex = Convert.ToInt32(row.Cells["Sex"].Value);
                var authority = Convert.ToInt32(row.Cells["Authority"].Value);
                string email = row.Cells["Email"].Value.ToString();

                Form3 form3 = new Form3();
                form3.createOrUpdate = id;
                form3.textBoxName.Text = name;
                form3.textBoxPhone.Text = phone;
                form3.textBoxEmail.Text = email;
                form3.textBoxPassword.Text = password;
                if (authority == 0)
                {
                    form3.radioButton4.Checked = true;
                }

                if (sex == 1)
                {
                    form3.radioButton1.Checked = true;
                }
                else if (sex == 0)
                {
                    form3.radioButton2.Checked = true;
                }
                else
                {
                    form3.radioButton3.Checked = true;
                }
                form3.Show();
                button4_Click(sender, e);


            }

            if (e.ColumnIndex == 8 && e.RowIndex >= 0)  
            {
                
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["UserId"].Value);
                function.DeleteUser(id);
                button4_Click(sender, e);
                //Console.WriteLine(id);
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
        //get all activities
        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;


            List<Activity> list = function.ListAllActivities();
            dataGridView3.DataSource = list;
        }
        //Show everyone involved in the event
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)  
            {
               
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["ActivityId"].Value);
                DateTime st = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn4"].Value);
                DateTime ed = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn5"].Value);
                ActivitySignIn activitySign = new ActivitySignIn();
                activitySign.startTime = st;
                activitySign.endTime = ed;
                List<CheckInData> list = function.CheckInDatas(id);
                foreach (CheckInData check in list)
                {
                    if (check.SignInTime != null && check.State != UserActivityStatus.SignedIn)
                    {
                        check.SignInTime = null;
                    }
                }
                activitySign.dataGridView1.DataSource = list;

                activitySign.Show();




            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
