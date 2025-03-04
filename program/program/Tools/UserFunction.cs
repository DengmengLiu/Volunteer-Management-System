using program.Domain;
using program.Domain.DBConnection;
using program.Tools.DataGridSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace program.Tools
{
    public class UserFunction
    {
        //Gets all notifications for that user
        public List<Notification> GetNotifications(int uid)
        {
            var context = Context.ReturnContext();
            var query = from a in context.Notification
                        where a.UserId == uid
                        select new Notification
                        {
                            Id = a.Id,
                            UserId = a.UserId,
                            Time = a.Time,
                            NotificationContext = a.NotificationContext
                        };
            return query.ToList();
        }

        public void DeleteNotification(int id)
        {
            var context = Context.ReturnContext();
            Notification notification = context.Notification.Find(id);
            context.Notification.Remove(notification);
            context.SaveChanges();
        }
    }

}
