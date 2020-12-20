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
    public partial class LoggedIn : Form
    {
        FirstControl fc = new FirstControl();
        SecondControl sc = new SecondControl();

        public LoggedIn(string role)
        {
            InitializeComponent();
            this.label2.Text = role;
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 g2 = new Form1();
            g2.Show();
            this.Close();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {
            if (Form1.LoggedInUser.GetUserType() == "Admin")
            {
                mainMenuButton.Visible = true;
                adminMenuButton.Visible = true;
            }    
            if (Form1.LoggedInUser.GetUserType() == "User")
            {
                mainMenuButton.Visible = true;
                adminMenuButton.Visible = false;
            }
            mainPanel.Controls.Add(fc);
            fc.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(fc);
            fc.Show();
        }

        private void adminMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(sc);
            sc.Show();
        }
    }
}
