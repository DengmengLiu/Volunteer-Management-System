using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using program.Domain.DBConnection;

namespace program.Domain
{
    public enum UserActivityStatus
    {
        NotComplete = 0, 
        SignedIn = 1, 
        Completed = 2 
    }
    public class UserActivity
    {
        [Key]

        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public UserActivityStatus State { get; set; }
        public string Feedback { get; set; }
        public DateTime SignInTime { get; set; }
        public UserActivity(int userId, int activityId, UserActivityStatus state, string feedback, DateTime signInTime)
        {
            UserId = userId;
            ActivityId = activityId;
            State = state;
            Feedback = feedback;
            SignInTime = signInTime;
        }

        public UserActivity()
        {
        }

        /// <summary>
        /// Get a list of activities with the specified status for a given user.
        /// </summary>
        /// <param name="uid">The user's ID.</param>
        /// <param name="status">The status of activities to retrieve.</param>
        /// <returns>A list of activities with the specified status for the user.</returns>
        public static List<Activity> GetActivities(int uid, UserActivityStatus status)
        {
            var context = Context.ReturnContext();

            try
            {
                
                var activities = context.Activity
                    .Join(context.UserActivity, a => a.Id, ua => ua.ActivityId, (a, ua) => new { Activity = a, UserActivity = ua })
                    .Where(joined => joined.UserActivity.UserId == uid)
                    .Where(joined => joined.UserActivity.State == status)
                    .Select(joined => joined.Activity)
                    .ToList();
                return activities;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to get activities for the user.", ex);
            }
        }

        /// <summary>
        /// Get a list of users associated with a specific activity.
        /// </summary>
        /// <param name="aid">The ID of the activity.</param>
        /// <returns>A list of users associated with the activity.</returns>

        public List<User> GetUsers(int aid)
        {
            var context = Context.ReturnContext();

            try
            {
                
                var users = context.User
                    .Join(context.UserActivity, u => u.Id, ua => ua.UserId, (u, ua) => new { User = u, UserActivity = ua })
                    .Where(joined => joined.UserActivity.ActivityId == aid)
                    .Select(joined => joined.User)
                    .ToList();

                return users;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get users for the activity.", ex);
            }
        }

        /// <summary>
        /// Create a new UserActivity record in the database.
        /// </summary>
        /// <returns>The newly created UserActivity object.</returns>

        public UserActivity Create()
        {
            var context = Context.ReturnContext();

            try
            {
                context.UserActivity.Add(this); 
                context.SaveChanges();
                return this;

            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to create UserActivity.", ex);
            }
        }
        /// <summary>
        /// Create a new UserActivity record in the database.
        /// </summary>
        /// <param name="ua">The UserActivity object to be created.</param>
        /// <returns>The newly created UserActivity object.</returns>

        public static UserActivity Create(UserActivity ua)
        {
            var context = Context.ReturnContext();

            try
            {
                context.UserActivity.Add(ua); 
                context.SaveChanges();
                return ua;

            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to create UserActivity.", ex);
            }
        }

        /// <summary>
        /// Read a UserActivity record from the database based on user ID and activity ID.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="activityId">The ID of the activity.</param>
        /// <returns>The UserActivity object matching the provided user and activity IDs.</returns>

        public static UserActivity Read(int userId, int activityId)
        {
            var context = Context.ReturnContext();

            try
            {
                var userActivity = context.UserActivity
                    .FirstOrDefault(ua => ua.UserId == userId && ua.ActivityId == activityId);

                return userActivity;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to read UserActivity.", ex);
            }
        }

        /// <summary>
        /// Update an existing UserActivity record in the database.
        /// </summary>
        /// <param name="ua">The UserActivity object to update.</param>
        public static void Update(UserActivity ua)
        {
            var context = Context.ReturnContext();

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    
                    string updateSql = "UPDATE UserActivity SET Feedback = @Feedback, State = @State WHERE UserId = @UserId AND ActivityId = @ActivityId";
                    string insertSql = "INSERT INTO UserActivity (UserId, ActivityId, Feedback, State) VALUES (@UserId, @ActivityId, @Feedback, @State)";               
                    var parameters = new[]
                    {
                new SqlParameter("@UserId", ua.UserId),
                new SqlParameter("@ActivityId", ua.ActivityId),
                new SqlParameter("@Feedback", ua.Feedback),
                new SqlParameter("@State", ua.State)
            };

                    
                    var userActivity = context.UserActivity
                        .SingleOrDefault(u => u.UserId == ua.UserId && u.ActivityId == ua.ActivityId);

                    if (userActivity != null)
                    {
                       
                        context.Database.ExecuteSqlRaw(updateSql, parameters);
                        Console.WriteLine("Update");
                    }
                    else
                    {
                        
                        context.Database.ExecuteSqlRaw(insertSql, parameters);
                        Console.WriteLine("Create");
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    
                    transaction.Rollback();
                    throw new Exception("Failed to Update or Create UserActivity.", ex);
                }
            }
        }

        /// <summary>
        /// Delete a UserActivity record from the database.
        /// </summary>
        public void Delete()
        {
            var context = Context.ReturnContext();

            try
            {
                if (context.UserActivity
                    .SingleOrDefault(ua => ua.UserId == UserId && ua.ActivityId == ActivityId) != null)
                {
                    
                    string sglCommand = "DELETE FROM UserActivity WHERE UserId = {0} and ActivityId = {1}";
                    context.Database.ExecuteSqlRaw(sglCommand, UserId, ActivityId);
                    context.SaveChanges();
                }
                
                else
                {
                    throw new Exception("UserActivity is not exist.");
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to delete UserActivity.", ex);
            }
        }
        /// <summary>
        /// Delete a UserActivity record from the database based on user ID and activity ID.
        /// </summary>
        /// <param name="uid">The ID of the user.</param>
        /// <param name="aid">The ID of the activity.</param>

        public static void Delete(int uid, int aid)
        {
            var context = Context.ReturnContext();

            try
            {
                

                if (context.UserActivity
                    .SingleOrDefault(ua => ua.UserId == uid && ua.ActivityId == aid) != null)
                {
                    
                    string sglCommand = "DELETE FROM UserActivity WHERE UserId = {0} and ActivityId = {1}";
                    context.Database.ExecuteSqlRaw(sglCommand, uid, aid);
                    context.SaveChanges();
                }
                
                else
                {
                    throw new Exception("UserActivity is not exist.");
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to delete UserActivity.", ex);
            }
        }
        /// <summary>
        /// Get a list of UserActivity records for a specific user.
        /// </summary>
        /// <param name="uid">The ID of the user.</param>
        /// <returns>A list of UserActivity records for the user.</returns>

        public static List<UserActivity> GetUserActivities(int uid)
        {
            var context = Context.ReturnContext();
            var userActivities = context.UserActivity.Where(ua => ua.UserId == uid).ToList();
            return userActivities;
        }

        // <summary>
        /// Calculate the duration of participation in an activity.
        /// </summary>
        /// <returns>The duration of participation in hours.</returns>
        public double ParticipationDuration()
        {
            var context = Context.ReturnContext();
            var activity = context.Activity.FirstOrDefault(a => a.Id == ActivityId);

            if (activity != null)
            {
                
                DateTime endTime = activity.EndTime;
                double duration = (endTime - SignInTime).TotalHours;

                if (duration < 0)
                {
                    throw new Exception("Sign in time is later than the end time, Not vaild!");
                }
                return duration;
            }
            else
            {
                throw new Exception("Activity is not exist");
            }


        }

    }
}
