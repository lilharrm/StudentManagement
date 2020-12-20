using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using LoginApp;
using System.Data.SqlClient;

namespace LoginApp
{
    public class UsersRepository
    {
        private static List<User> usersList;
        private SqlConnection conn;
        public List<User> GetUsers()
        {
            return usersList;
        }

        public UsersRepository()
        {
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
        }

        public void Register(User user)
        {
            try
            {
                string sql = "insert into [Users](name, surname, password, user_Type, username) " +
                    "values (@name, @surname, @password, @user_Type, @username)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@surname", user.GetSurname());
                cmd.Parameters.AddWithValue("@password", user.GetPassword());
                cmd.Parameters.AddWithValue("@user_Type", user.GetUserType());
                cmd.Parameters.AddWithValue("@username", user.GetUserName());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public User Login(string username, string password)
        {
            try
            {
                string sql = "select id, name, surname, password, user_Type, username, group_id from [Users] " +
                    "where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);     
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        string usrname = reader["username"].ToString();
                        string pass = reader["password"].ToString();
                        string type = reader["user_Type"].ToString();
                        string group = reader["group_id"].ToString();
                        return new User(id, name, surname, usrname, pass, type, group);
                    }
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Bad credentials");
        }

        public Group GettingGroup(string id)
        {
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "select id, Name from [Group] " +
                    "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string groupId = reader["id"].ToString();
                        string groupName = reader["Name"].ToString();

                        return new Group(groupId, groupName);
                    }
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Service unavailable");
        }

        public List<Grade> GradesList()
        {
            List<Grade> AllGrades = new List<Grade>();
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "select id, Grades, Student_id, Subject_id, Group_id from [Grade] ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Id = reader["id"].ToString();
                        string grades = reader["Grades"].ToString();
                        string studentid = reader["Student_id"].ToString();
                        string subjectid = reader["Subject_id"].ToString();
                        string groupid = reader["Group_id"].ToString();
                        Grade gr = new Grade(Id, grades, studentid, subjectid, groupid);
                        AllGrades.Add(gr);
                    }
                }
                conn.Close();
                return AllGrades;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Service unavailable");
        }
        public List<Subject> SubjectList()
        {
            List<Subject> AllSubjects = new List<Subject>();
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "select id, Name, Group_id, Teacher_id from [Subject] ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Id = reader["id"].ToString();
                        string name = reader["Name"].ToString();
                        string groupid = reader["Group_id"].ToString();
                        string teacherid = reader["Teacher_id"].ToString();
                        Subject sb = new Subject(Id, name, groupid, teacherid);
                        AllSubjects.Add(sb);
                    }
                }
                conn.Close();
                return AllSubjects;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Service unavailable");
        }

        public List<User> UsersList()
        {
            List<User> AllUsers = new List<User>();
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "select id, name, surname, password, user_Type, username, group_id from [Users]  ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        string usrname = reader["username"].ToString();
                        string pass = reader["password"].ToString();
                        string type = reader["user_Type"].ToString();
                        string group = reader["group_id"].ToString();
                        User us = new User(id, name, surname, usrname, pass, type, group);
                        AllUsers.Add(us);
                    }
                }
                conn.Close();
                return AllUsers;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Service unavailable");
        }
        public List<Group> GroupList()
        {
            List<Group> AllGroups = new List<Group>();
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "select id, Name from [Group] ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Id = reader["id"].ToString();
                        string name = reader["Name"].ToString();
                        Group gr = new Group(Id, name);
                        AllGroups.Add(gr);
                    }
                }
                conn.Close();
                return AllGroups;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Service unavailable");
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

        public void RemoveUser(string id)
        {
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "delete from [Users] " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }






    }
}
