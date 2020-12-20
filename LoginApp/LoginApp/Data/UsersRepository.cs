using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using LoginApp;

namespace LoginApp
{
    public class UsersRepository
    {
        private static List<User> usersList;

        public List<User> GetUsers()
        {
            return usersList;
        }

        public UsersRepository()
        {
            if (usersList == null)
            {
                usersList = new List<User>();
                User user = new User("Mr", "Administrator", new DateTime(2000, 05, 18), "admin", "admin", "Admin");
                user.SetUserType("Admin");
                usersList.Add(user);
            }
        }

        public void Register(User user)
        {
            usersList.Add(user);
        }

        public User Login(string username, string password)
        {
            foreach (User user in usersList)
            {
                if (user.GetUserName().Equals(username) && user.GetPassword().Equals(password))
                    return user;
            }
            throw new Exception("Bad credentials");
        }

        public string CheckLogin(string username)
        {
            foreach (User user in usersList)
            {
                if (user.GetUserName().Equals(username))
                throw new Exception("User with the same username exists");
            }
            return username;
        }

        public void RemoveUser(User user)
        {
            if (usersList != null)
            {
                usersList.Remove(user);
            }
            else throw new Exception("Userlist is empty");
        }






    }
}
