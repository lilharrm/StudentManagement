using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;


namespace LoginApp
{

    public partial class Form1 : Form
    {

        public static User LoggedInUser;
        public static Group LoggednInUserGroup;
        public static List<Grade> AllGrades;
        public static List<Subject> AllSubjects;
        public static List<User> AllUsers;
        public static List<Group> AllGroups;
        public static LoggedIn g;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersRepository repository = new UsersRepository();
            try
            {
                Form1.LoggedInUser = repository.Login(textBox1.Text, textBox2.Text);
                if(Form1.LoggedInUser.GetUserType() == "User")
                {
                    Form1.LoggednInUserGroup = repository.GettingGroup(Form1.LoggedInUser.GetGroup());
                }
                if(Form1.LoggedInUser.GetUserType() == "Admin" || Form1.LoggedInUser.GetUserType() == "Teacher")
                {
                    Form1.AllUsers = repository.UsersList();
                    Form1.AllGroups = repository.GroupList();
                }
                Form1.AllGrades = repository.GradesList();
                Form1.AllSubjects = repository.SubjectList();
                Form1.g = new LoggedIn();
                Form1.g.Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
