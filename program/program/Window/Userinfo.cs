using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User1;
using System.Xml;
using program.Domain;
using static User1.Login;
using System.Configuration;
using program.Domain.DBConnection;

namespace program.Window
{
    public partial class Userinfo : UserControl
    {
        private int userId;
        private User userInfo;

        // Read user information based on the user ID
        private User ReadUserInfo(int userId)
        {
            var user = new User();
            return user.Read(userId);
        }


        public Userinfo(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Retrieve user information for the given user ID
            userInfo = ReadUserInfo(userId);

            if (userInfo != null)
            {
                // Populate UI fields with user information
                uname.Text = userInfo.Name;
                gender.Text = userInfo.Sex.ToString();
                uphone.Text = userInfo.Phone;
                uemail.Text = userInfo.Email;
                upass.Text = userInfo.Password;
                var UserActivity = new UserActivity();

                // Calculate and display the user's total participation duration in hours
                double totalDuration = CalculateTotalParticipationDuration(userId);
                time.Text = Math.Round(totalDuration, 2).ToString("0.00") + " hours";



            }
        }

        public double CalculateTotalParticipationDuration(int userId)
        {
            var context = Context.ReturnContext();

            

            List<UserActivity> list = context.UserActivity.Where(s => s.State == UserActivityStatus.SignedIn).Where(s => s.UserId == userId).ToList();
            double totalDuration = 0;

            foreach (var userActivity in list)
            {
                // Calculate the duration for each user activity
                double activityDuration = userActivity.ParticipationDuration();

                // Accumulate the total duration
                totalDuration += activityDuration;
            }

            return totalDuration;
        }




        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string name = uname.Text;
            string selectedGender = gender.Text; 
            Gender sex;

            if (Enum.TryParse(selectedGender, out sex))
            {
                string phone = uphone.Text;
                string email = uemail.Text;
                string password = upass.Text;

                try
                {
                    User user = ReadUserInfo(userId);

                    if (user != null)
                    {
                        user.Name = name;
                        user.Password = password;
                        user.Email = email;
                        user.Phone = phone;
                        user.Sex = sex;
                        user.Authority = AuthorityType.User; 

                        user.Update(user);

                        MessageBox.Show("User information updated successfully.");
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)

                { 
                }
            }
        }
    }
}