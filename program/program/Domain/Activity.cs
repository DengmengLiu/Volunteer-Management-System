using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using program.Domain.DBConnection;

namespace program.Domain
{
    public enum ActivityExpireStatus
    {
        NotExpired = 0, 
        Expired = 1, 
    }
    public class Activity
    {


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Place { get; set; }
        public double Duration { get; set; }
        public int NoPeople { get; set; }

        // Determine whether the activity has expired
        public ActivityExpireStatus Expired
        {
            get
            {
                return (StartTime < DateTime.Now) ? ActivityExpireStatus.Expired : ActivityExpireStatus.NotExpired;
            }
        }

        public Activity(string name, string description, DateTime startTime, DateTime endTime, string place, int noPeople)
        {
            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Place = place;
            // Calculate Duration and convert the time difference into hours
            Duration = (endTime - startTime).TotalHours;
            NoPeople = noPeople;
        }

        public Activity() { }

        // Find all activities
        // Return an Activity list
        // When other functions call this function, you can add traversal conditions to achieve the purpose of other functions. There is no division here. Please write logic in your own function.
        public static List<Activity> AllActivities()
        {
            return Context.ReturnContext().Activity.ToList();
        }

        // Find the number of people who have joined the target activity
        public int JoinedPeople()
        {
            return Context.ReturnContext().UserActivity.Where(joinedpeople => joinedpeople.ActivityId == this.Id).Count(); //LINQ
        }

        // add activity
        //Formal parameters (Parameter) please ensure that they are provided by the constructor (Constructer) =>
        // Activity created by Activity(string name, string description, DateTime startTime, DateTime endTime, string place, int noPeople, ActivityExpireStatus expired)
        public Activity Create()
        {
            var context = Context.ReturnContext();
            context.Activity.Add(this);
            context.SaveChanges();
            return this;
        }
        public Activity Create(Activity act)
        {
            var context = Context.ReturnContext();
            Activity activity = new Activity(act.Name, act.Description, act.StartTime, act.EndTime, act.Place, act.NoPeople);
            context.Activity.Add(activity);
            context.SaveChanges();
            return activity;
        }

        // Find activities based on id
        public static Activity Read(int id)
        {
            var context = Context.ReturnContext();
            var activity = context.Activity.Find(id);

            if (activity != null)
            {
                return activity;
            }

            return null;
        }


        //Modify current activity
        public void Update(Activity activity)
        {
            var context = Context.ReturnContext();
            var a = context.Activity.Find(Id);

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    
                    a.Description = activity.Description;
                    a.Name = activity.Name;
                    a.StartTime = activity.StartTime;
                    a.EndTime = activity.EndTime;
                    a.Place = activity.Place;
                    a.Duration = (activity.EndTime - activity.StartTime).TotalHours;
                    a.NoPeople = activity.NoPeople;

                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Failed to Update Activity.", ex);
                }
            }
        }

        // Delete activity
        // string return value
        public string Delete()
        {
            var context = Context.ReturnContext();
            var activity = context.Activity.SingleOrDefault(a => a.Id == Id); // LINQ

            if (activity != null)
            {
                context.Activity.Remove(activity);
                context.SaveChanges();
                return "Delete Success!";
            }
            return "Activity not exist, Delete failed!";
        }
        public string Delete(int id)
        {
            var context = Context.ReturnContext();
            var activity = context.Activity.SingleOrDefault(a => a.Id == id); // LINQ

            if (activity != null)
            {
                context.Activity.Remove(activity);
                context.SaveChanges();
                return "Delete Success!";
            }
            return "Activity not exist, Delete failed!";
        }

        //Match activities based on activity name, location, and activity description
        public static List<Activity> SearchActivities(string input)
        {
            var matchingActivities = Context.ReturnContext().Activity
                .Where(activity => activity.Name.Contains(input)
                || activity.Description.Contains(input)
                || activity.Place.Contains(input))
                .ToList();
            return matchingActivities;
        }


    }
}
