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
    public partial class GroupControl : UserControl
    {
        private SqlConnection conn;
        private List<string> ids;
        public GroupControl()
        {
            InitializeComponent();
        }

        private void GroupControl_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            checkedListBox1.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            Confirm.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "insert into [Group](Name) " +
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
            label2.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            addStudentButton.Visible = false;
            checkedListBox1.Visible = true;
            button3.Visible = true;
            label3.Visible = true;
            comboBox1.Visible = true;
            label4.Visible = true;
            foreach (User us in Form1.AllUsers)
            {
                if(us.GetUserType() == "User" && string.IsNullOrEmpty(us.GetGroup()))
                {
                    checkedListBox1.Items.Add($"{us.GetName()} {us.GetSurname()} {us.GetId()}");
                }
            }
            foreach(Group gr in Form1.AllGroups)
            {
                comboBox1.Items.Add(gr.GetGroupName());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(checkedListBox1.CheckedItems == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Check atleast one student and select a group");
            }
            else
            {
                conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
                string groupId = "";
                foreach (Group gr in Form1.AllGroups)
                {
                    if (gr.GetGroupName() == comboBox1.SelectedItem.ToString())
                    {
                        groupId = gr.GetGroupId();
                    }
                }
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    string[] parts = itemChecked.ToString().Split(' ');
                    string id = parts[2];

                    string sql = "update [Users] set group_id = @newGroup where id = @stud_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@newGroup", groupId);
                    cmd.Parameters.AddWithValue("@stud_id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                checkedListBox1.Visible = false;
                button3.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = true;
                addStudentButton.Visible = true;
                label4.Visible = false;
            }
            
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            Confirm.Visible = true;
            button1.Visible = false;
            addStudentButton.Visible = false;
            deleteGroupButton.Visible = false;
            foreach (Group gr in Form1.AllGroups)
            {
                comboBox2.Items.Add(gr.GetGroupName());
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem != null)
            {
                conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
                string id = Form1.AllGroups[comboBox2.SelectedIndex].GetGroupId();

                string sql1 = "update [Users] set group_id = NULL where group_id = @oldGroupid";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@oldGroupid", id);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                string sql = "delete from [Group] " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();

                comboBox2.Visible = false;
                Confirm.Visible = false;
                button1.Visible = true;
                addStudentButton.Visible = true;
                deleteGroupButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Select a group");
            }
        }
    }
}
