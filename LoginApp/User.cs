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
using System.Data.SqlClient;

namespace LoginApp
{
    public class User
    {
        protected string Id;
        protected string Name;
        protected string Surname;
        protected string Username;
        protected string Password;
        protected string utype;
        protected string Group_id;
        private SqlConnection conn;
        public User() { }
        public User(string id, string name, string surname, string username, string password, string type, string group)
        {
            if (username != "")
                this.Username = username;
            else throw new Exception("Username is required");

            if (password != "")
                this.Password = password;
            else throw new Exception("Password is required");

            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            utype = type;
            Group_id = group;
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
        }

        public string GetUserName()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {

            if (oldPassword == newPassword) throw new Exception("New password can't be old password");
            if (newPassword == "") throw new Exception("Password cannot be left blank");

            if (oldPassword == Form1.LoggedInUser.GetPassword())
            {
                try
                {

                    string sql = "UPDATE [User] " +
                        "SET password = @password " +
                        "Where id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", Form1.LoggedInUser.GetId());
                    cmd.Parameters.AddWithValue("@password", newPassword);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception exc)
                {
                    throw new Exception(exc.Message);
                }
                Form1.LoggedInUser.Password = newPassword;
            }
            else throw new Exception("Wrong current password entered");
        }

        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public string GetUserType()
        {
            return utype;
        }
        public string GetGroup()
        {
            return Group_id;
        }
        public string GetId()
        {
            return Id;
        }

        public void SetUserType(string type)
        {
            this.utype = type;
        }
    }
}
