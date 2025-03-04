using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using program.Domain.DBConnection;

namespace program.Domain
{
    public class Notification
    {

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string NotificationContext { get; set; }
        public DateTime Time { get; set; }

        public Notification(int userId, string context, DateTime time)
        {
            UserId = userId;
            NotificationContext = context;
            Time = time;
        }
        public Notification() { }

        // Find all notifications
        // Return a Notification list
        // When other functions call this function, you can add traversal conditions to achieve the purpose of other functions. There is no division here. Please write logic in your own function.
        public static List<Notification> AllNotifications()
        {
            return Context.ReturnContext().Notification.ToList();
        }

        //Add notification
        public Notification Create()
        {
            var context = Context.ReturnContext();
            context.Add(this);
            context.SaveChanges();
            return this;
        }
        public static Notification Create(Notification n)
        {
            var context = Context.ReturnContext();
            context.Add(n);
            context.SaveChanges();
            return n;
        }

        // Find notifications based on id
        public Notification Read(int id)
        {
            var context = Context.ReturnContext();
            return context.Notification.Find(id);
        }

        // Modification notice
        public void Update(Notification noti)
        {
            var context = Context.ReturnContext();
            var notification = context.Notification.Find(Id);

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                   
                    notification.NotificationContext = noti.NotificationContext;
                    notification.Time = noti.Time;
                    notification.UserId = noti.UserId;

                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    
                    transaction.Rollback();
                    throw new Exception("Failed to Update Notification.", ex);
                }
            }
        }

        // Delete notification based on id
        // Provide string return value
        public string Delete()
        {
            var context = Context.ReturnContext();
            var notification = context.Notification.Find(Id);

            if (notification != null)
            {
                context.Notification.Remove(notification);
                context.SaveChanges();
                return "Delete Success!";
            }
            throw new Exception("Failed to Delete Notification.");
        }
        public string Delete(int id)
        {
            var context = Context.ReturnContext();
            var notification = context.Notification.Find(id);

            if (notification != null)
            {
                context.Notification.Remove(notification);
                context.SaveChanges();
                return "Delete Success!";
            }
            throw new Exception("Failed to Delete Notification.");
        }

    }
}
