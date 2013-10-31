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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.helpPictureBox = new System.Windows.Forms.PictureBox();
            this.statisticsPictureBox = new System.Windows.Forms.PictureBox();
            this.reportsPictureBox = new System.Windows.Forms.PictureBox();
            this.gradesPictureBox = new System.Windows.Forms.PictureBox();
            this.ratingsPictureBox = new System.Windows.Forms.PictureBox();
            this.assignmentsPictureBox = new System.Windows.Forms.PictureBox();
            this.subjectsPictureBox = new System.Windows.Forms.PictureBox();
            this.studentsPictureBox = new System.Windows.Forms.PictureBox();
            this.semesterPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.ribbonOrbSubjects = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbGrades = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbSemesterNew = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbReports = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbStatistics = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbRanking = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbHelp = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTopLoginButton = new System.Windows.Forms.RibbonButton();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 768);
            this.panel1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.logoutPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.helpPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.statisticsPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.reportsPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.gradesPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.ratingsPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.assignmentsPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.subjectsPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.studentsPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.semesterPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.loginPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(914, 739);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 1;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.maximizePictureBox);
            this.menuPanel.Controls.Add(this.minimizePictureBox);
            this.menuPanel.Controls.Add(this.closePictureBox);
            this.menuPanel.Controls.Add(this.titleLabel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(914, 29);
            this.menuPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(432, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(124, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Grade Manager";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.IsBalloon = true;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.BackgroundImage = global::Grade_Manager_DB_Controller.Properties.Resources.logout;
            this.logoutPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutPictureBox.Location = new System.Drawing.Point(0, 684);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(70, 55);
            this.logoutPictureBox.TabIndex = 10;
            this.logoutPictureBox.TabStop = false;
            // 
            // helpPictureBox
            // 
            this.helpPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpPictureBox.BackgroundImage")));
            this.helpPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpPictureBox.Location = new System.Drawing.Point(0, 555);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(70, 55);
            this.helpPictureBox.TabIndex = 9;
            this.helpPictureBox.TabStop = false;
            // 
            // statisticsPictureBox
            // 
            this.statisticsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statisticsPictureBox.BackgroundImage")));
            this.statisticsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statisticsPictureBox.Location = new System.Drawing.Point(0, 495);
            this.statisticsPictureBox.Name = "statisticsPictureBox";
            this.statisticsPictureBox.Size = new System.Drawing.Size(70, 55);
            this.statisticsPictureBox.TabIndex = 8;
            this.statisticsPictureBox.TabStop = false;
            // 
            // reportsPictureBox
            // 
            this.reportsPictureBox.BackgroundImage = global::Grade_Manager_DB_Controller.Properties.Resources.check_book_32;
            this.reportsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportsPictureBox.Location = new System.Drawing.Point(0, 434);
            this.reportsPictureBox.Name = "reportsPictureBox";
            this.reportsPictureBox.Size = new System.Drawing.Size(70, 55);
            this.reportsPictureBox.TabIndex = 7;
            this.reportsPictureBox.TabStop = false;
            // 
            // gradesPictureBox
            // 
            this.gradesPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradesPictureBox.BackgroundImage")));
            this.gradesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gradesPictureBox.Location = new System.Drawing.Point(0, 312);
            this.gradesPictureBox.Name = "gradesPictureBox";
            this.gradesPictureBox.Size = new System.Drawing.Size(70, 55);
            this.gradesPictureBox.TabIndex = 6;
            this.gradesPictureBox.TabStop = false;
            // 
            // ratingsPictureBox
            // 
            this.ratingsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ratingsPictureBox.BackgroundImage")));
            this.ratingsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ratingsPictureBox.Location = new System.Drawing.Point(0, 373);
            this.ratingsPictureBox.Name = "ratingsPictureBox";
            this.ratingsPictureBox.Size = new System.Drawing.Size(70, 55);
            this.ratingsPictureBox.TabIndex = 5;
            this.ratingsPictureBox.TabStop = false;
            // 
            // assignmentsPictureBox
            // 
            this.assignmentsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("assignmentsPictureBox.BackgroundImage")));
            this.assignmentsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.assignmentsPictureBox.Location = new System.Drawing.Point(0, 251);
            this.assignmentsPictureBox.Name = "assignmentsPictureBox";
            this.assignmentsPictureBox.Size = new System.Drawing.Size(70, 55);
            this.assignmentsPictureBox.TabIndex = 4;
            this.assignmentsPictureBox.TabStop = false;
            // 
            // subjectsPictureBox
            // 
            this.subjectsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subjectsPictureBox.BackgroundImage")));
            this.subjectsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subjectsPictureBox.Location = new System.Drawing.Point(0, 190);
            this.subjectsPictureBox.Name = "subjectsPictureBox";
            this.subjectsPictureBox.Size = new System.Drawing.Size(70, 55);
            this.subjectsPictureBox.TabIndex = 3;
            this.subjectsPictureBox.TabStop = false;
            // 
            // studentsPictureBox
            // 
            this.studentsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentsPictureBox.BackgroundImage")));
            this.studentsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.studentsPictureBox.Location = new System.Drawing.Point(0, 129);
            this.studentsPictureBox.Name = "studentsPictureBox";
            this.studentsPictureBox.Size = new System.Drawing.Size(70, 55);
            this.studentsPictureBox.TabIndex = 2;
            this.studentsPictureBox.TabStop = false;
            // 
            // semesterPictureBox
            // 
            this.semesterPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("semesterPictureBox.BackgroundImage")));
            this.semesterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.semesterPictureBox.Location = new System.Drawing.Point(0, 68);
            this.semesterPictureBox.Name = "semesterPictureBox";
            this.semesterPictureBox.Size = new System.Drawing.Size(70, 55);
            this.semesterPictureBox.TabIndex = 1;
            this.semesterPictureBox.TabStop = false;
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPictureBox.BackgroundImage")));
            this.loginPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginPictureBox.Location = new System.Drawing.Point(0, 7);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(70, 55);
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            this.loginPictureBox.Tag = "Login";
            this.loginPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginPictureBox_MouseClick);
            this.loginPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPictureBox_MouseDown);
            this.loginPictureBox.MouseEnter += new System.EventHandler(this.loginPictureBox_MouseEnter);
            this.loginPictureBox.MouseLeave += new System.EventHandler(this.loginPictureBox_MouseLeave);
            this.loginPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPictureBox_MouseUp);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(836, 0);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 29);
            this.maximizePictureBox.TabIndex = 2;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minimizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.BackgroundImage")));
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Location = new System.Drawing.Point(862, 0);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 29);
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Location = new System.Drawing.Point(888, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 29);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // ribbonOrbSubjects
            // 
            this.ribbonOrbSubjects.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbSubjects.Image = global::Grade_Manager_DB_Controller.Properties.Resources.library;
            this.ribbonOrbSubjects.SmallImage = global::Grade_Manager_DB_Controller.Properties.Resources.library;
            this.ribbonOrbSubjects.Text = "Subjects";
            this.ribbonOrbSubjects.Click += new System.EventHandler(this.subjectManagementBtn_Click);
            // 
            // ribbonOrbGrades
            // 
            this.ribbonOrbGrades.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbGrades.Image = global::Grade_Manager_DB_Controller.Properties.Resources.grades;
            this.ribbonOrbGrades.SmallImage = global::Grade_Manager_DB_Controller.Properties.Resources.grades;
            this.ribbonOrbGrades.Text = "Grades";
            this.ribbonOrbGrades.Click += new System.EventHandler(this.gradesManagementRibbonBtn_Click);
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "ribbonOrbMenuItem2";
            // 
            // ribbonOrbSemesterNew
            // 
            this.ribbonOrbSemesterNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSemesterNew.Image")));
            this.ribbonOrbSemesterNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSemesterNew.SmallImage")));
            this.ribbonOrbSemesterNew.Text = "New";
            // 
            // ribbonOrbReports
            // 
            this.ribbonOrbReports.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbReports.Image = global::Grade_Manager_DB_Controller.Properties.Resources.reports;
            this.ribbonOrbReports.SmallImage = global::Grade_Manager_DB_Controller.Properties.Resources.reports;
            this.ribbonOrbReports.Text = "Reports";
            this.ribbonOrbReports.Click += new System.EventHandler(this.reportsManagementRibbonBtn_Click);
            // 
            // ribbonOrbStatistics
            // 
            this.ribbonOrbStatistics.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbStatistics.Image = global::Grade_Manager_DB_Controller.Properties.Resources.statistics;
            this.ribbonOrbStatistics.SmallImage = global::Grade_Manager_DB_Controller.Properties.Resources.statistics;
            this.ribbonOrbStatistics.Text = "Statistics";
            this.ribbonOrbStatistics.Click += new System.EventHandler(this.statisticsRibbonButton_Click);
            // 
            // ribbonOrbRanking
            // 
            this.ribbonOrbRanking.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbRanking.Image = global::Grade_Manager_DB_Controller.Properties.Resources.ranking;
            this.ribbonOrbRanking.SmallImage = global::Grade_Manager_DB_Controller.Properties.Resources.ranking;
            this.ribbonOrbRanking.Text = "Ranking";
            this.ribbonOrbRanking.Click += new System.EventHandler(this.rankingRButton_Click);
            // 
            // ribbonOrbHelp
            // 
            this.ribbonOrbHelp.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbHelp.Image = global::Grade_Manager_DB_Controller.Properties.Resources.help;
            this.ribbonOrbHelp.SmallImage = global::Grade_Manager_DB_Controller.Properties.Resources.help;
            this.ribbonOrbHelp.Text = "Help";
            // 
            // ribbonTopLoginButton
            // 
            this.ribbonTopLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTopLoginButton.Image")));
            this.ribbonTopLoginButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.ribbonTopLoginButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonTopLoginButton.SmallImage")));
            this.ribbonTopLoginButton.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 790);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbSemesterButton;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbStudents;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbAssignments;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbSubjects;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbGrades;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbReports;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbStatistics;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbRanking;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbSemesterNew;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton ribbonTopLoginButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox statisticsPictureBox;
        private System.Windows.Forms.PictureBox reportsPictureBox;
        private System.Windows.Forms.PictureBox gradesPictureBox;
        private System.Windows.Forms.PictureBox ratingsPictureBox;
        private System.Windows.Forms.PictureBox assignmentsPictureBox;
        private System.Windows.Forms.PictureBox subjectsPictureBox;
        private System.Windows.Forms.PictureBox studentsPictureBox;
        private System.Windows.Forms.PictureBox semesterPictureBox;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox helpPictureBox;
        private System.Windows.Forms.PictureBox logoutPictureBox;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}

