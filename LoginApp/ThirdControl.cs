using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class ThirdControl : UserControl
    {
        public UsersRepository repository = new UsersRepository();
        public ThirdControl()
        {
            InitializeComponent();
        }

        private void ThirdControl_Load(object sender, EventArgs e)
        {
            foreach(Subject sb in Form1.AllSubjects)
            {
                if(sb.GetTeacherId() == Form1.LoggedInUser.GetId())
                {
                    foreach(Group gr in Form1.AllGroups)
                    {
                        if(sb.GetGroupId() == gr.GetGroupId())
                        {
                            dataGridView1.Rows.Add(sb.GetName(), gr.GetGroupName(), gr.GetGroupId());
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedGroup = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string SelectedSubject ="";
            foreach(Subject sb in Form1.AllSubjects)
            {
                if(sb.GetGroupId() == SelectedGroup && sb.GetName() == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                {
                    SelectedSubject = sb.GetId();
                }
            }
            Form1.g.GradesControl(SelectedGroup, SelectedSubject);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
