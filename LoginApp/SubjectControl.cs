using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class SubjectControl : UserControl
    {
        private SqlConnection conn;
        List<string> teacher_ids = new List<string>();
        List<string> subject_ids = new List<string>();
        List<string> group_ids = new List<string>();
        public SubjectControl()
        {
            InitializeComponent();
        }

        private void SubjectControl_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "insert into [Subject](Name) " +
                    "values (@Name)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            button2.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            button1.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subject_ids = new List<string>();
            foreach(User us in Form1.AllUsers)
            {
                if (us.GetUserType() == "Teacher")
                {
                    comboBox1.Items.Add($"{us.GetName()} {us.GetSurname()}");
                    teacher_ids.Add(us.GetId());
                }
            }
            foreach(Subject sub in Form1.AllSubjects)
            {
                if(string.IsNullOrEmpty(sub.GetTeacherId()))
                {
                    comboBox2.Items.Add(sub.GetName());
                    subject_ids.Add(sub.GetId());
                }
            }
            button1.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button4.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
                string sql = "update [Subject] set Teacher_id = @newTeacher where id = @sub_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@newTeacher", teacher_ids[comboBox1.SelectedIndex]);
                cmd.Parameters.AddWithValue("@sub_id", subject_ids[comboBox2.SelectedIndex]);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                button1.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                button4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;

            }
            else
            {
                MessageBox.Show("Select a teacher and a subject");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            subject_ids = new List<string>();
            foreach(Group gr in Form1.AllGroups)
            {
                comboBox3.Items.Add(gr.GetGroupName());
                group_ids.Add(gr.GetGroupId());
            }
            foreach(Subject sub in Form1.AllSubjects)
            {
                if(string.IsNullOrEmpty(sub.GetGroupId()))
                {
                    comboBox4.Items.Add(sub.GetName());
                    subject_ids.Add(sub.GetId());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
                string sql = "update [Subject] set Group_id = @newGroup where id = @sub_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@newGroup", group_ids[comboBox3.SelectedIndex]);
                cmd.Parameters.AddWithValue("@sub_id", subject_ids[comboBox4.SelectedIndex]);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                comboBox3.Visible = false;
                comboBox4.Visible = false;
                button1.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                button6.Visible = false;

            }
            else
            {
                MessageBox.Show("Select a group and a subject");
            }
        }
    }
}
