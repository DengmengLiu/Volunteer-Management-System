using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using program.Domain;
using program.Domain.DBConnection;
using program.Tools.DataGridSource;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Activity = program.Domain.Activity;

namespace program.Tools
{
    public class AdministratorFunction
    {
        private Domain.Activity activity = new Domain.Activity();
        private Domain.User user = new Domain.User();
        private Domain.UserActivity userActivity = new Domain.UserActivity();
        Notification notification1 = new Notification();
        public System.Timers.Timer timer;

        public AdministratorFunction()
        {
            timer = new System.Timers.Timer(5000);
            timer.Elapsed += ActivityStartNotiifcation;
            timer.AutoReset = true;
        }

        public void AddActivity(Domain.Activity activity)
        {
            activity.Create(activity);
        }

        public void UpdateActivity(Domain.Activity activity, int id)
        {
            Domain.Activity activity1 = Activity.Read(id);
            activity1.Update(activity);
        }

        public void DeleteActivity(int id)
        {
            activity.Delete(id);
        }

        public List<Domain.Activity> ListAllActivities()
        {
            return Domain.Activity.AllActivities();
        }

        public void AddUser(User user1)
        {
            user1.Create();
        }

        public void UpdateUser(User user1, int id)
        {
            User user2 = user1.Read(id);
            user2.Update(user1);
        }

        public void DeleteUser(int id)
        {
            user.Delete(id);
        }

        public List<User> ListAllUsers()
        {
            return User.GetAll();
        }

        //Gets information about all participants in the event
        public List<CheckInData> CheckInDatas(int id)
        {
            var context = Context.ReturnContext();
            string sqlCommand = "SELECT  a.UserId, u.Name, a.ActivityId, a.State, a.Feedback, a.SignInTime FROM   UserActivity AS a JOIN [User] AS u ON a.UserId = u.Id WHERE   a.ActivityId = {0};";

            List<CheckInData> list = context.Set<CheckInData>().FromSqlRaw(sqlCommand, id).ToList();
            return list;
        }

        public void SetSignInTime(DateTime time, int uid, int aid)
        {
            var context = Context.ReturnContext();
            string sqlCommand = "UPDATE UserActivity SET SignInTime = {0}, State = 1 WHERE UserId = {1} AND ActivityId = {2}";
            context.Database.ExecuteSqlRaw(sqlCommand, time, uid, aid);
        }


        public void NotificationTimer()
        {

        }
        //Email two hours before the event
        public void ActivityStartNotiifcation(object? sender, ElapsedEventArgs e)
        {
            var context = Context.ReturnContext();
            string sqlCommand = "SELECT act.Name AS ActivityName,act.Place, act.StartTime, ua.UserId AS UId, u.Name UserName ,u.Email FROM UserActivity ua JOIN Activity act ON ua.ActivityId = act.Id JOIN [User] u ON u.Id = ua.UserId;";
            List<StartNotification> list = context.Set<StartNotification>().FromSqlRaw(sqlCommand).ToList();
            foreach (var notification in list)
            {
                double sub = (notification.StartTime - DateTime.Now).TotalMinutes;
             
                if ((sub < 120) && (sub > 119.92))
                {
                    string contexts = string.Format("Hello,{0},The event you booked {1} will take place in 2 hours at {2}", notification.UserName, notification.ActivityName, notification.Place);
                    Notification notification2 = new Notification(notification.UId, contexts, DateTime.Now);
                    notification2.Create();
                  
                    EmailNotification.SendEmail("renyuxing14@gmail.com", "y b u x t l t k j s n j w s t s", notification.Email, "The event you subscribed to will take place in two hours ", contexts);
                   
                }
            }

        }
    }
}
