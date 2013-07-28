namespace Grade_Manager
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.classManagementBtn = new System.Windows.Forms.Button();
            this.subjectManagementBtn = new System.Windows.Forms.Button();
            this.gradeManagementBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.profileMangementBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.studentManagementBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProfileToolStripMenuItem,
            this.selectProfileToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // createProfileToolStripMenuItem
            // 
            this.createProfileToolStripMenuItem.Name = "createProfileToolStripMenuItem";
            this.createProfileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.createProfileToolStripMenuItem.Text = "Create Profile";
            this.createProfileToolStripMenuItem.Visible = false;
            // 
            // selectProfileToolStripMenuItem
            // 
            this.selectProfileToolStripMenuItem.Name = "selectProfileToolStripMenuItem";
            this.selectProfileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.selectProfileToolStripMenuItem.Text = "Select Profile";
            this.selectProfileToolStripMenuItem.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.loginBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.classManagementBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.subjectManagementBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.gradeManagementBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.reportBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.profileMangementBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.logoutBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.studentManagementBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 464);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBtn.Location = new System.Drawing.Point(367, 187);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(176, 86);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // classManagementBtn
            // 
            this.classManagementBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classManagementBtn.Location = new System.Drawing.Point(185, 95);
            this.classManagementBtn.Name = "classManagementBtn";
            this.classManagementBtn.Size = new System.Drawing.Size(176, 86);
            this.classManagementBtn.TabIndex = 2;
            this.classManagementBtn.Text = "Manage Your Classes";
            this.classManagementBtn.UseVisualStyleBackColor = true;
            this.classManagementBtn.Visible = false;
            this.classManagementBtn.Click += new System.EventHandler(this.classManagementBtn_Click);
            // 
            // subjectManagementBtn
            // 
            this.subjectManagementBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectManagementBtn.Enabled = false;
            this.subjectManagementBtn.Location = new System.Drawing.Point(549, 95);
            this.subjectManagementBtn.Name = "subjectManagementBtn";
            this.subjectManagementBtn.Size = new System.Drawing.Size(176, 86);
            this.subjectManagementBtn.TabIndex = 3;
            this.subjectManagementBtn.Text = "Manage Subjects";
            this.subjectManagementBtn.UseVisualStyleBackColor = true;
            this.subjectManagementBtn.Visible = false;
            this.subjectManagementBtn.Click += new System.EventHandler(this.subjectManagementBtn_Click);
            // 
            // gradeManagementBtn
            // 
            this.gradeManagementBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeManagementBtn.Enabled = false;
            this.gradeManagementBtn.Location = new System.Drawing.Point(185, 279);
            this.gradeManagementBtn.Name = "gradeManagementBtn";
            this.gradeManagementBtn.Size = new System.Drawing.Size(176, 86);
            this.gradeManagementBtn.TabIndex = 4;
            this.gradeManagementBtn.Text = "Grades";
            this.gradeManagementBtn.UseVisualStyleBackColor = true;
            this.gradeManagementBtn.Visible = false;
            // 
            // reportBtn
            // 
            this.reportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBtn.Enabled = false;
            this.reportBtn.Location = new System.Drawing.Point(549, 279);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(176, 86);
            this.reportBtn.TabIndex = 5;
            this.reportBtn.Text = "Reports";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Visible = false;
            // 
            // profileMangementBtn
            // 
            this.profileMangementBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileMangementBtn.Location = new System.Drawing.Point(367, 3);
            this.profileMangementBtn.Name = "profileMangementBtn";
            this.profileMangementBtn.Size = new System.Drawing.Size(176, 86);
            this.profileMangementBtn.TabIndex = 6;
            this.profileMangementBtn.Text = "Profiles";
            this.profileMangementBtn.UseVisualStyleBackColor = true;
            this.profileMangementBtn.Visible = false;
            this.profileMangementBtn.Click += new System.EventHandler(this.profileMangementBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutBtn.Location = new System.Drawing.Point(367, 371);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(176, 90);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Visible = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // studentManagementBtn
            // 
            this.studentManagementBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentManagementBtn.Location = new System.Drawing.Point(3, 95);
            this.studentManagementBtn.Name = "studentManagementBtn";
            this.studentManagementBtn.Size = new System.Drawing.Size(176, 86);
            this.studentManagementBtn.TabIndex = 8;
            this.studentManagementBtn.Text = "Students";
            this.studentManagementBtn.UseVisualStyleBackColor = true;
            this.studentManagementBtn.Visible = false;
            this.studentManagementBtn.Click += new System.EventHandler(this.studentManagementBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem createProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProfileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button classManagementBtn;
        private System.Windows.Forms.Button subjectManagementBtn;
        private System.Windows.Forms.Button gradeManagementBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button profileMangementBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button studentManagementBtn;

    }
}

