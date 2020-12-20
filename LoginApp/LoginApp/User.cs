using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApp;
using System.Drawing;
using System.Security.Policy;

namespace LoginApp
{
    public class User : Person
    {
        protected string username;
        protected string password;
        protected string profileImageLocation;
        protected string type;

        public User(string name, string surname, DateTime birthDate, string username, string password, string type) : base(name, surname, birthDate)
        {
            if (username != "")
                this.username = username;
            else throw new Exception("Username is required");

            if (password != "")
                this.password = password;
            else throw new Exception("Password is required");
        }

        public string GetUserName()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {

            if (oldPassword == newPassword) throw new Exception("New password can't be old password");
            if (newPassword == "") throw new Exception("Password cannot be left blank");

            if (oldPassword == Form1.LoggedInUser.GetPassword())
            {
                Form1.LoggedInUser.password = newPassword;
            }
            else throw new Exception("Wrong current password entered");
        }


        public void SetImage(string newImage)
        {
            string location = newImage;
            Form1.LoggedInUser.profileImageLocation = location;
        }


        public string GetImage()
        {
            return profileImageLocation;
        }


        public string GetUserType()
        {
            return type;
        }


        public void SetUserType(string type)
        {
            this.type = type;
        }
    }
}
