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
    public partial class GradeControl : UserControl
    {
        public UsersRepository repository = new UsersRepository();
        public string SelectedGroup;
        public string SelectedSubject;
        List<string> ids = new List<string>();
        private SqlConnection conn;
        public GradeControl()
        {
            InitializeComponent();
        }

        private void GradeControl_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Visible = false;
            bool found = false;
            foreach(User us in Form1.AllUsers)
            {
                if(SelectedGroup == us.GetGroup())
                {
                    found = false;
                    foreach(Grade gr in Form1.AllGrades)
                    {
                        if(gr.GetSubjectId() == SelectedSubject && us.GetId() == gr.GetStudentId())
                        {
                            dataGridView1.Rows.Add(us.GetName(), us.GetSurname(), gr.GetGrades());
                            found = true;
                            ids.Add(us.GetId());
                        }
                    }
                    if(found == false)
                    {
                        dataGridView1.Rows.Add(us.GetName(), us.GetSurname());
                        ids.Add(us.GetId());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            int index = dataGridView1.CurrentRow.Index;
            try
            {
                if (dataGridView1.CurrentRow.Cells[2].Value == DBNull.Value || dataGridView1.CurrentRow.Cells[2].Value == null)
                {
                    string sql = "insert into [Grade](Grades, Student_id, Subject_id, Group_id) " +
                        "values (@Grades, @Student_id, @Subject_id, @Group_id)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Grades", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Student_id", ids[index]);
                    cmd.Parameters.AddWithValue("@Subject_id", SelectedSubject);
                    cmd.Parameters.AddWithValue("@Group_id", SelectedGroup);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    string sql = "update [Grade] set Grades = @newGrade where Student_id = @stud_id and Subject_id = @sub_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@newGrade", textBox1.Text);
                    cmd.Parameters.AddWithValue("@stud_id", ids[index]);
                    cmd.Parameters.AddWithValue("@sub_id", SelectedSubject);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                throw new Exception("Enter a number");
            }
            button2.Visible = false;
            textBox1.Visible = false;
        }
    }
}
