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
    public partial class SecondControl : UserControl
    {

        public UsersRepository repository = new UsersRepository();

        public SecondControl()
        {
            InitializeComponent();
        }

        private void SecondControl_Load(object sender, EventArgs e)
        {
           foreach(User user in repository.GetUsers())
            {
                dataGridView1.Rows.Add(user.GetUserName(), user.GetPassword(), user.GetName(), user.GetSurname(), user.GetAge(), user.GetUserType());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if(MessageBox.Show("Do you really want to remove the selected user?", "Message", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    repository.RemoveUser(repository.GetUsers()[index]);
                    dataGridView1.Rows.RemoveAt(index);
                }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
            }
        }
    }
}
