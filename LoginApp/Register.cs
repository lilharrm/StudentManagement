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
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private SqlConnection conn;

        private void button1_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(@"Server=LAPTOP-269Q5K2N;Database=praktika;User ID=sa;Password=123456");
            try
            {
                string sql = "insert into [Users] (name, surname, password, user_Type, username)" +
                    "values (@name, @surname, @password, @user_type, @username)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@user_type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@username", nameTextBox.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Hide();
                MessageBox.Show("Registration succesfull!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
