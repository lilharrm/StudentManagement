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

        public LoggedIn()
        {
            InitializeComponent();
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 g2 = new Form1();
            g2.Show();
            this.Close();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.LoggedInUser.GetUserName();
            if (Form1.LoggedInUser.GetUserType() == "Admin")
            {
                mainMenuButton.Visible = true;
                adminMenuButton.Visible = true;
                studentGradesToolStripMenuItem.Visible = false;
                registerNewUserToolStripMenuItem.Visible = true;
            }
            if (Form1.LoggedInUser.GetUserType() == "Teacher")
            {
                mainMenuButton.Visible = true;
                adminMenuButton.Visible = false;
                studentGradesToolStripMenuItem.Visible = true;
                registerNewUserToolStripMenuItem.Visible = false;
                manageGroupsToolStripMenuItem.Visible = false;
                manageSubjectsToolStripMenuItem.Visible = false;
            }
            if (Form1.LoggedInUser.GetUserType() == "User")
            {
                mainMenuButton.Visible = true;
                adminMenuButton.Visible = false;
                studentGradesToolStripMenuItem.Visible = false;
                registerNewUserToolStripMenuItem.Visible = false;
                manageGroupsToolStripMenuItem.Visible = false;
                manageSubjectsToolStripMenuItem.Visible = false;
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

        private void registerNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register g3 = new Register();
            g3.ShowDialog();
        }

        public void GradesControl(string selectedGroup, string selectedSubjetc)
        {
            GradeControl gc = new GradeControl();
            gc.SelectedGroup = selectedGroup;
            gc.SelectedSubject = selectedSubjetc;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(gc);
            gc.Show();
        }

        private void manageGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupControl gc = new GroupControl();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(gc);
            gc.Show();
        }

        private void manageSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectControl subc = new SubjectControl();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(subc);
            subc.Show();
        }

        private void studentGradesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThirdControl tc = new ThirdControl();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(tc);
            tc.Show();
        }
    }
}
