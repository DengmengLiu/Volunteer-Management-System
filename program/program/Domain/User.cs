using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using program.Domain.DBConnection;

namespace program.Domain
{
    public enum Gender
    {
        Female = 0, // Female
        Male = 1, // Male
        Other = 2 // Other
    }
    public enum AuthorityType
    {
        Administrator = 0,
        User = 1,
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Sex { get; set; }
        public AuthorityType Authority { get; set; }
        //public ICollection<UserActivity> UserActivities { get; set; }
        public User()
        {

        }

        public User(string name, string password, string email, string phone, Gender sex, AuthorityType authority)
        {
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Sex = sex;
            Authority = authority;
        }

        //Find user based on id and password
        public User LoginCheck(int id, string password)
        {
            var context = Context.ReturnContext();
            var user = context.User.SingleOrDefault(s => s.Id == id && s.Password == password);
            return user;
        }

        // register new user
        public int CreateUser(string name, string password, string email, string phone, Gender sex)
        {
            using (var context = Context.ReturnContext())
            {
                var newUser = new User
                {
                    Name = name,
                    Sex = sex,
                    Phone = phone,
                    Email = email,
                    Password = password,
                    Authority = AuthorityType.User
                };

                
                context.User.Add(newUser);
                context.SaveChanges();

                int newUserId = newUser.Id;

                
                MessageBox.Show($"Registration completed! Your new ID is {newUserId}");

                return newUserId;
            }
        }

        //find all users
        // Return a User list
        // When other functions call this function, you can add traversal conditions to achieve the purpose of other functions. There is no division here. Please write logic in your own function.
        public static List<User> GetAll()
        {
            return Context.ReturnContext().User.ToList();
        }

        // Add user
        public User Create()
        {
            var context = Context.ReturnContext();
            context.User.Add(this);
            context.SaveChanges();
            return this;
        }
        public User Create(User u)
        {
            var context = Context.ReturnContext();
            context.User.Add(u);
            context.SaveChanges();
            return u;
        }
        // Find user based on id
        public User Read(int id)
        {
            var context = Context.ReturnContext();
            var user = context.User.SingleOrDefault(s => s.Id == id);
            if (user != null)
            {
                return new User
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Phone = user.Phone,
                    Sex = user.Sex,
                    Password = user.Password,
                    Authority = user.Authority
                };
            }
            else
            {
                return null; 
            }
        }

        //Modify user
        public void Update(User u)
        {
            var context = Context.ReturnContext();
            var user = context.User.Find(Id);

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    user.Name = u.Name;
                    user.Email = u.Email;
                    user.Password = u.Password;
                    user.Phone = u.Phone;
                    user.Sex = u.Sex;
                    user.Authority = u.Authority;

                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Failed to Update User.", ex);
                }
            }
        }

        //Delete user based on id
        // Provide string return value
        public string Delete()
        {
            var context = Context.ReturnContext();
            User user = context.User.Find(Id);

            if (user != null)
            {
                context.User.Remove(user);
                context.SaveChanges();
                return "Delete Success!";
            }
            return "User not exist, Delete failed!";
        }
        public string Delete(int id)
        {
            var context = Context.ReturnContext();
            User user = context.User.Find(id);

            if (user != null)
            {
                context.User.Remove(user);
                context.SaveChanges();
                return "Delete Success!";
            }
            return "User not exist, Delete failed!";
        }


    }

}
