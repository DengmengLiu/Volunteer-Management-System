using Microsoft.EntityFrameworkCore;
using program.Tools.DataGridSource;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Domain.DBConnection
{
    public class Context : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<UserActivity> UserActivity { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<WaitList> WaitList { get; set; }
        public DbSet<StartNotification> StartNotification { get; set; }
        public DbSet<CheckInData> CheckInData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //请修改connect string中Server属性到你本地匹配的服务器
            optionsBuilder.UseSqlServer(@"Server=(local);Database=test;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StartNotification>().HasNoKey().ToView(null);
        }

        public static Context ReturnContext()
        {
            return new Context();
        }
    }
}

