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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.loginPanel = new System.Windows.Forms.RibbonPanel();
            this.logInRibBtn = new System.Windows.Forms.RibbonButton();
            this.logoutPanel = new System.Windows.Forms.RibbonPanel();
            this.semesterManagementRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.studentManagementRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.assignmentManagementRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.subjectsManagementRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.gradesManagementRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.reportsManagementRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.logoutRibbonBtn = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ribbon1
            // 
            this.ribbon1.BorderMode = System.Windows.Forms.RibbonWindowMode.InsideWindow;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbText = "Menu";
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.Size = new System.Drawing.Size(914, 129);
            this.ribbon1.TabIndex = 7;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.loginPanel);
            this.ribbonTab1.Panels.Add(this.logoutPanel);
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Main";
            // 
            // loginPanel
            // 
            this.loginPanel.Items.Add(this.logInRibBtn);
            this.loginPanel.Text = "";
            // 
            // logInRibBtn
            // 
            this.logInRibBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.login;
            this.logInRibBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.logInRibBtn.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.logInRibBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("logInRibBtn.SmallImage")));
            this.logInRibBtn.Text = "Log In";
            this.logInRibBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // logoutPanel
            // 
            this.logoutPanel.Items.Add(this.semesterManagementRibbonBtn);
            this.logoutPanel.Text = "";
            // 
            // semesterManagementRibbonBtn
            // 
            this.semesterManagementRibbonBtn.Enabled = false;
            this.semesterManagementRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.profiles;
            this.semesterManagementRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.semesterManagementRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("semesterManagementRibbonBtn.SmallImage")));
            this.semesterManagementRibbonBtn.Text = "Semester";
            this.semesterManagementRibbonBtn.Click += new System.EventHandler(this.profileMangementBtn_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.studentManagementRibbonBtn);
            this.ribbonPanel1.Items.Add(this.assignmentManagementRibbonBtn);
            this.ribbonPanel1.Items.Add(this.subjectsManagementRibbonBtn);
            this.ribbonPanel1.Items.Add(this.gradesManagementRibbonBtn);
            this.ribbonPanel1.Items.Add(this.reportsManagementRibbonBtn);
            this.ribbonPanel1.Text = "Management";
            // 
            // studentManagementRibbonBtn
            // 
            this.studentManagementRibbonBtn.Enabled = false;
            this.studentManagementRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.user;
            this.studentManagementRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.studentManagementRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("studentManagementRibbonBtn.SmallImage")));
            this.studentManagementRibbonBtn.Text = "Students";
            this.studentManagementRibbonBtn.Click += new System.EventHandler(this.studentManagementBtn_Click);
            // 
            // assignmentManagementRibbonBtn
            // 
            this.assignmentManagementRibbonBtn.Enabled = false;
            this.assignmentManagementRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.classes;
            this.assignmentManagementRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.assignmentManagementRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("assignmentManagementRibbonBtn.SmallImage")));
            this.assignmentManagementRibbonBtn.Text = "Assignments";
            this.assignmentManagementRibbonBtn.Click += new System.EventHandler(this.assignmentManagementRibbonBtn_Click);
            // 
            // subjectsManagementRibbonBtn
            // 
            this.subjectsManagementRibbonBtn.Enabled = false;
            this.subjectsManagementRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.library;
            this.subjectsManagementRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.subjectsManagementRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("subjectsManagementRibbonBtn.SmallImage")));
            this.subjectsManagementRibbonBtn.Text = "Subjects";
            this.subjectsManagementRibbonBtn.Click += new System.EventHandler(this.subjectManagementBtn_Click);
            // 
            // gradesManagementRibbonBtn
            // 
            this.gradesManagementRibbonBtn.Enabled = false;
            this.gradesManagementRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.grades;
            this.gradesManagementRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.gradesManagementRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("gradesManagementRibbonBtn.SmallImage")));
            this.gradesManagementRibbonBtn.Text = "Grades";
            // 
            // reportsManagementRibbonBtn
            // 
            this.reportsManagementRibbonBtn.Enabled = false;
            this.reportsManagementRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.reports;
            this.reportsManagementRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.reportsManagementRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportsManagementRibbonBtn.SmallImage")));
            this.reportsManagementRibbonBtn.Text = "Reports";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.logoutRibbonBtn);
            this.ribbonPanel2.Text = "";
            // 
            // logoutRibbonBtn
            // 
            this.logoutRibbonBtn.Enabled = false;
            this.logoutRibbonBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.logout;
            this.logoutRibbonBtn.MinimumSize = new System.Drawing.Size(70, 50);
            this.logoutRibbonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("logoutRibbonBtn.SmallImage")));
            this.logoutRibbonBtn.Text = "Log Out";
            this.logoutRibbonBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 415);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel loginPanel;
        private System.Windows.Forms.RibbonButton logInRibBtn;
        private System.Windows.Forms.RibbonPanel logoutPanel;
        private System.Windows.Forms.RibbonButton semesterManagementRibbonBtn;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton studentManagementRibbonBtn;
        private System.Windows.Forms.RibbonButton assignmentManagementRibbonBtn;
        private System.Windows.Forms.RibbonButton subjectsManagementRibbonBtn;
        private System.Windows.Forms.RibbonButton gradesManagementRibbonBtn;
        private System.Windows.Forms.RibbonButton reportsManagementRibbonBtn;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton logoutRibbonBtn;
        private System.Windows.Forms.Panel panel1;


    }
}

