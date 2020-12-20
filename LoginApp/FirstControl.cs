using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace LoginApp
{
    public partial class FirstControl : UserControl
    {
        public FirstControl()
        {
            InitializeComponent();
 
            
        }

        private void FirstControl_Load(object sender, EventArgs e)
        {
            groupHere.Visible = false;
            label3.Visible = false;
            GradeGridView1.Visible = false;
            usernameLabel.Text = Form1.LoggedInUser.GetUserName();
            nameLabel.Text = Form1.LoggedInUser.GetName();
            surnameLabel.Text = Form1.LoggedInUser.GetSurname();
            passwordLabel.Text = Form1.LoggedInUser.GetPassword();
            if(Form1.LoggedInUser.GetUserType() == "User")
            {
                groupHere.Visible = true;
                label3.Visible = true;
                GradeGridView1.Visible = true;
                groupHere.Text = Form1.LoggednInUserGroup.GetGroupName();
            }

            foreach(Grade gr in Form1.AllGrades)
            {
                if(gr.GetStudentId() == Form1.LoggedInUser.GetId())
                {
                    foreach(Subject sb in Form1.AllSubjects)
                    {
                        if(sb.GetId() == gr.GetSubjectId())
                        {
                            GradeGridView1.Rows.Add(sb.GetName(), gr.GetGrades());
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.LoggedInUser.ChangePassword(textBox1.Text, textBox2.Text);
                passwordLabel.Text = Form1.LoggedInUser.GetPassword();
                MessageBox.Show("Password succesfully changed!");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
