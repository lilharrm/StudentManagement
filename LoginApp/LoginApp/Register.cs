using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApp;

namespace LoginApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                User user = new User(nameTextBox.Text, surnameTextBox.Text, dateTimePicker1.Value, usernameTextBox.Text, passwordTextBox.Text, comboBox1.Text);
                UsersRepository repository = new UsersRepository();
                if (comboBox1.Text == "") throw new Exception("Please pick user type");
                if(comboBox1.Text == "Admin")
                {
                    user.GetType();
                    user.SetUserType("Admin");
                }
                if(comboBox1.Text == "User")
                {
                    user.GetType();
                    user.SetUserType("User");
                }
                repository.CheckLogin(usernameTextBox.Text);
                repository.Register(user);

                this.Hide();
                MessageBox.Show("Registration succesfull! You may now log in");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }
    }
}
