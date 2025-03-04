using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using program.Domain.DBConnection;

namespace program.Domain
{
    public class WaitList
    {

        [Key]
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public DateTime AddTime { get; set; }

        public WaitList(int userId, int activityId)
        {
            UserId = userId;
            ActivityId = activityId;

            AddTime = DateTime.Now;
        }

        public WaitList()
        {
        }

        // add to waitlist
        public WaitList Create()
        {
            using (var context = Context.ReturnContext())
            {
                context.WaitList.Add(this);
                context.SaveChanges();
                return this;
            }
        }
        public static WaitList Create(WaitList w)
        {
            using (var context = Context.ReturnContext())
            {
                context.WaitList.Add(w);
                context.SaveChanges();
                return w;
            }
        }

        // Read waitlst
        public static WaitList Read(int userId, int activityId)
        {
            using (var context = Context.ReturnContext())
            {
                return context.WaitList.FirstOrDefault(w => w.UserId == userId && w.ActivityId == activityId);
            }
        }

        // Delete from waitlist
        public void Delete()
        {
            using (var context = Context.ReturnContext())
            {
                if (context.WaitList.FirstOrDefault(w => w.UserId == UserId && w.ActivityId == ActivityId) != null)
                {
                    string sglCommand = "DELETE FROM WaitList WHERE UserId = {0} and ActivityId = {1}";
                    context.Database.ExecuteSqlRaw(sglCommand, UserId, ActivityId);
                }
                
                else
                {
                    throw new Exception("UserActivity is not exist.");
                }
            }
        }
        public static void Delete(int uid, int aid)
        {
            using (var context = Context.ReturnContext())
            {
                if (context.WaitList.FirstOrDefault(w => w.UserId == uid && w.ActivityId == aid) != null)
                {
                    string sglCommand = "DELETE FROM WaitList WHERE UserId = {0} and ActivityId = {1}";
                    context.Database.ExecuteSqlRaw(sglCommand, uid, aid);
                }
                
                else
                {
                    throw new Exception("UserActivity is not exist.");
                }
            }
        }

        
        public static List<Activity> GetActivities(int uid)
        {
            var context = Context.ReturnContext();

            try
            {
                
                var activities = context.Activity
                    .Join(context.WaitList, a => a.Id, w => w.ActivityId, (a, w) => new { Activity = a, WaitList = w })
                    .Where(joined => joined.WaitList.UserId == uid)
                    .Select(joined => joined.Activity)
                    .ToList();

                return activities;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to get activities for the user.", ex);
            }
        }

        
        public List<User> GetUsers(int aid)
        {
            var context = Context.ReturnContext();

            try
            {
                
                var users = context.User
                    .Join(context.WaitList, u => u.Id, w => w.UserId, (u, w) => new { User = u, WaitList = w })
                    .Where(joined => joined.WaitList.ActivityId == aid)
                    .Select(joined => joined.User)
                    .ToList();

                return users;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to get users for the activity.", ex);
            }
        }
    }
}
