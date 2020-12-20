namespace LoginApp
{
    partial class LoggedIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuButton,
            this.adminMenuButton,
            this.registerNewUserToolStripMenuItem,
            this.manageGroupsToolStripMenuItem,
            this.manageSubjectsToolStripMenuItem,
            this.studentGradesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(80, 20);
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // adminMenuButton
            // 
            this.adminMenuButton.Name = "adminMenuButton";
            this.adminMenuButton.Size = new System.Drawing.Size(87, 20);
            this.adminMenuButton.Text = "Remove user";
            this.adminMenuButton.Click += new System.EventHandler(this.adminMenuToolStripMenuItem_Click);
            // 
            // registerNewUserToolStripMenuItem
            // 
            this.registerNewUserToolStripMenuItem.Name = "registerNewUserToolStripMenuItem";
            this.registerNewUserToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.registerNewUserToolStripMenuItem.Text = "Register new user";
            this.registerNewUserToolStripMenuItem.Click += new System.EventHandler(this.registerNewUserToolStripMenuItem_Click);
            // 
            // manageGroupsToolStripMenuItem
            // 
            this.manageGroupsToolStripMenuItem.Name = "manageGroupsToolStripMenuItem";
            this.manageGroupsToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manageGroupsToolStripMenuItem.Text = "Manage groups";
            this.manageGroupsToolStripMenuItem.Click += new System.EventHandler(this.manageGroupsToolStripMenuItem_Click);
            // 
            // manageSubjectsToolStripMenuItem
            // 
            this.manageSubjectsToolStripMenuItem.Name = "manageSubjectsToolStripMenuItem";
            this.manageSubjectsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.manageSubjectsToolStripMenuItem.Text = "Manage subjects";
            this.manageSubjectsToolStripMenuItem.Click += new System.EventHandler(this.manageSubjectsToolStripMenuItem_Click);
            // 
            // studentGradesToolStripMenuItem
            // 
            this.studentGradesToolStripMenuItem.Name = "studentGradesToolStripMenuItem";
            this.studentGradesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.studentGradesToolStripMenuItem.Text = "Student grades";
            this.studentGradesToolStripMenuItem.Click += new System.EventHandler(this.studentGradesToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role_Here";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(13, 57);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(756, 412);
            this.mainPanel.TabIndex = 3;
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoggedIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggedIn";
            this.Load += new System.EventHandler(this.LoggedIn_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem mainMenuButton;
        private System.Windows.Forms.ToolStripMenuItem adminMenuButton;
        private System.Windows.Forms.ToolStripMenuItem registerNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentGradesToolStripMenuItem;
    }
}