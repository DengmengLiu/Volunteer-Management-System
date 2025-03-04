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
    public class Favorite
    {
        [Key]
        public int UserId { get; set; }
        public int ActivityId { get; set; }

        public Favorite(int userId, int activityId)
        {
            UserId = userId;
            ActivityId = activityId;
        }

        public Favorite()
        {
        }

        /// <summary>
        /// Creates a new Favorite record in the database.
        /// </summary>
        /// <returns>The newly created Favorite object.</returns>
        public Favorite Create()
        {
            var context = Context.ReturnContext();

            try
            {
                context.Favorite.Add(this); 
                context.SaveChanges();
                return this;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to create Favorite.", ex);
            }
        }
        /// <summary>
        /// Creates a new Favorite record in the database.
        /// </summary>
        /// <param name="f">The Favorite object to be created.</param>
        /// <returns>The newly created Favorite object.</returns>
        public static Favorite Create(Favorite f)
        {
            var context = Context.ReturnContext();

            try
            {
                context.Favorite.Add(f); 
                context.SaveChanges();
                return f;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to create Favorite.", ex);
            }
        }

        /// <summary>
        /// Reads a Favorite record from the database based on user ID and activity ID.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="activityId">The ID of the activity.</param>
        /// <returns>The Favorite object matching the provided user and activity IDs.</returns>
        public static Favorite Read(int userId, int activityId)
        {
            var context = Context.ReturnContext();

            try
            {
                var f = context.Favorite
                    .FirstOrDefault(ua => ua.UserId == userId && ua.ActivityId == activityId);

                return f;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Failed to read UserActivity.", ex);
            }
        }

        // Delete favorites
        public void Delete()
        {
            var context = Context.ReturnContext();
            try
            {
                if (context.Favorite.SingleOrDefault(f => (f.ActivityId == ActivityId) && (f.UserId == UserId)) != null)
                {
                    string sglCommand = "DELETE FROM Favorite WHERE UserId = {0} and ActivityId = {1}";
                    context.Database.ExecuteSqlRaw(sglCommand, UserId, ActivityId);
                }
                
                else
                {
                    throw new Exception("UserActivity is not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete Favorite.", ex);
            }
        }
        public static void Delete(int uid, int aid)
        {
            var context = Context.ReturnContext();
            try
            {
                if (context.Favorite.SingleOrDefault(f => (f.ActivityId == aid) && (f.UserId == uid)) != null)
                {
                    string sglCommand = "DELETE FROM Favorite WHERE UserId = {0} and ActivityId = {1}";
                    context.Database.ExecuteSqlRaw(sglCommand, uid, aid);
                }
                else
                {
                    throw new Exception("UserActivity is not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete Favorite.", ex);
            }
        }

        // Find the user's collection based on the user ID
        public static List<Activity> GetFavoriteActivities(int userId)
        {
            var context = Context.ReturnContext();

            try
            {
                var favoriteActivities = context.Activity
                    .Join(context.Favorite, a => a.Id, f => f.ActivityId, (a, f) => new { Activity = a, Favorite = f })
                    .Where(joined => joined.Favorite.UserId == userId)
                    .Select(joined => joined.Activity)
                    .ToList();

                return favoriteActivities;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get favorite activities for the user.", ex);
            }
        }

        // Query the users who collected this activity based on the activity ID
        public List<User> GetFavoritingUsers(int activityId)
        {
            var context = Context.ReturnContext();

            try
            {
                var favoritingUsers = context.User
                    .Join(context.Favorite, u => u.Id, f => f.UserId, (u, f) => new { User = u, Favorite = f })
                    .Where(joined => joined.Favorite.ActivityId == activityId)
                    .Select(joined => joined.User)
                    .ToList();

                return favoritingUsers;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get favoriting users for the activity.", ex);
            }
        }
    }

}
