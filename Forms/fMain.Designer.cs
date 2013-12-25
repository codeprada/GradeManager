namespace Grade_Manager
{
    partial class fMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.rankingBtn = new System.Windows.Forms.Button();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.subjectsBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.assignmentsBtn = new System.Windows.Forms.Button();
            this.semesterBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(1, 745);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 744);
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.logoutBtn);
            this.splitContainer1.Panel1.Controls.Add(this.helpBtn);
            this.splitContainer1.Panel1.Controls.Add(this.statisticsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.reportsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.rankingBtn);
            this.splitContainer1.Panel1.Controls.Add(this.gradeBtn);
            this.splitContainer1.Panel1.Controls.Add(this.subjectsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.studentsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.assignmentsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.semesterBtn);
            this.splitContainer1.Panel1.Controls.Add(this.loginBtn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(1022, 715);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutBtn.Location = new System.Drawing.Point(1, 659);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(68, 55);
            this.logoutBtn.TabIndex = 30;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Tag = "logout";
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Visible = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click_1);
            this.logoutBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.logoutBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // helpBtn
            // 
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.helpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.help;
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpBtn.Location = new System.Drawing.Point(1, 496);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(68, 55);
            this.helpBtn.TabIndex = 29;
            this.helpBtn.TabStop = false;
            this.helpBtn.Tag = "help";
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            this.helpBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.helpBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.statisticsBtn.FlatAppearance.BorderSize = 0;
            this.statisticsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.statisticsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.statisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.statistics;
            this.statisticsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statisticsBtn.Location = new System.Drawing.Point(1, 441);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(68, 55);
            this.statisticsBtn.TabIndex = 28;
            this.statisticsBtn.TabStop = false;
            this.statisticsBtn.Tag = "statistics";
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Visible = false;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            this.statisticsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.statisticsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.reportsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.reports;
            this.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportsBtn.Location = new System.Drawing.Point(1, 386);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(68, 55);
            this.reportsBtn.TabIndex = 27;
            this.reportsBtn.TabStop = false;
            this.reportsBtn.Tag = "reports";
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Visible = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            this.reportsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.reportsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // rankingBtn
            // 
            this.rankingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rankingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rankingBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rankingBtn.FlatAppearance.BorderSize = 0;
            this.rankingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rankingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rankingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.rating;
            this.rankingBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rankingBtn.Location = new System.Drawing.Point(1, 331);
            this.rankingBtn.Name = "rankingBtn";
            this.rankingBtn.Size = new System.Drawing.Size(68, 55);
            this.rankingBtn.TabIndex = 26;
            this.rankingBtn.TabStop = false;
            this.rankingBtn.Tag = "ratings";
            this.rankingBtn.Text = "Ranking";
            this.rankingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rankingBtn.UseVisualStyleBackColor = true;
            this.rankingBtn.Visible = false;
            this.rankingBtn.Click += new System.EventHandler(this.rankingBtn_Click);
            this.rankingBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.rankingBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // gradeBtn
            // 
            this.gradeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gradeBtn.FlatAppearance.BorderSize = 0;
            this.gradeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.gradeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.gradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradeBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.grades;
            this.gradeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradeBtn.Location = new System.Drawing.Point(1, 276);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(68, 55);
            this.gradeBtn.TabIndex = 25;
            this.gradeBtn.TabStop = false;
            this.gradeBtn.Tag = "grades";
            this.gradeBtn.Text = "Grades";
            this.gradeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradeBtn.UseVisualStyleBackColor = true;
            this.gradeBtn.Visible = false;
            this.gradeBtn.Click += new System.EventHandler(this.gradeBtn_Click);
            this.gradeBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.gradeBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // subjectsBtn
            // 
            this.subjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subjectsBtn.FlatAppearance.BorderSize = 0;
            this.subjectsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.subjectsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.subjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.subjects;
            this.subjectsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subjectsBtn.Location = new System.Drawing.Point(1, 221);
            this.subjectsBtn.Name = "subjectsBtn";
            this.subjectsBtn.Size = new System.Drawing.Size(68, 55);
            this.subjectsBtn.TabIndex = 24;
            this.subjectsBtn.TabStop = false;
            this.subjectsBtn.Tag = "subjects";
            this.subjectsBtn.Text = "Subjects";
            this.subjectsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subjectsBtn.UseVisualStyleBackColor = true;
            this.subjectsBtn.Visible = false;
            this.subjectsBtn.Click += new System.EventHandler(this.subjectsBtn_Click);
            this.subjectsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.subjectsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // studentsBtn
            // 
            this.studentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.studentsBtn.FlatAppearance.BorderSize = 0;
            this.studentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.studentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.students;
            this.studentsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.studentsBtn.Location = new System.Drawing.Point(1, 166);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(68, 55);
            this.studentsBtn.TabIndex = 23;
            this.studentsBtn.TabStop = false;
            this.studentsBtn.Tag = "students";
            this.studentsBtn.Text = "Students";
            this.studentsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Visible = false;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            this.studentsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.studentsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // assignmentsBtn
            // 
            this.assignmentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignmentsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.assignmentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.assignmentsBtn.FlatAppearance.BorderSize = 0;
            this.assignmentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.assignmentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.assignmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignmentsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.assignmentsBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.assignment;
            this.assignmentsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.assignmentsBtn.Location = new System.Drawing.Point(1, 111);
            this.assignmentsBtn.Name = "assignmentsBtn";
            this.assignmentsBtn.Size = new System.Drawing.Size(68, 55);
            this.assignmentsBtn.TabIndex = 22;
            this.assignmentsBtn.TabStop = false;
            this.assignmentsBtn.Tag = "assignments";
            this.assignmentsBtn.Text = "Tests";
            this.assignmentsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.assignmentsBtn.UseVisualStyleBackColor = true;
            this.assignmentsBtn.Visible = false;
            this.assignmentsBtn.Click += new System.EventHandler(this.assignmentsBtn_Click);
            this.assignmentsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.assignmentsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // semesterBtn
            // 
            this.semesterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.semesterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.semesterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.semesterBtn.FlatAppearance.BorderSize = 0;
            this.semesterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.semesterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.semesterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.semesterBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.semesterBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.semester;
            this.semesterBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.semesterBtn.Location = new System.Drawing.Point(1, 56);
            this.semesterBtn.Name = "semesterBtn";
            this.semesterBtn.Size = new System.Drawing.Size(68, 55);
            this.semesterBtn.TabIndex = 21;
            this.semesterBtn.TabStop = false;
            this.semesterBtn.Tag = "semester";
            this.semesterBtn.Text = "Semester";
            this.semesterBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.semesterBtn.UseVisualStyleBackColor = true;
            this.semesterBtn.Visible = false;
            this.semesterBtn.Click += new System.EventHandler(this.semesterBtn_Click);
            this.semesterBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.semesterBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.login;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginBtn.Location = new System.Drawing.Point(1, 1);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(68, 55);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.TabStop = false;
            this.loginBtn.Tag = "login";
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.menuPanel.Controls.Add(this.maximizePictureBox);
            this.menuPanel.Controls.Add(this.minimizePictureBox);
            this.menuPanel.Controls.Add(this.closePictureBox);
            this.menuPanel.Controls.Add(this.titleLabel);
            this.menuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(2);
            this.menuPanel.Size = new System.Drawing.Size(1022, 29);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(942, 2);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 25);
            this.maximizePictureBox.TabIndex = 2;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Tag = "maximize";
            this.maximizePictureBox.Click += new System.EventHandler(this.pictureBox14_Click);
            this.maximizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.maximizePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.maximizePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.maximizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.minimizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.BackgroundImage")));
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Location = new System.Drawing.Point(968, 2);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 25);
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Tag = "minimize";
            this.minimizePictureBox.Click += new System.EventHandler(this.pictureBox13_Click);
            this.minimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.minimizePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.minimizePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.minimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Location = new System.Drawing.Point(994, 2);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 25);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Tag = "close";
            this.closePictureBox.Click += new System.EventHandler(this.pictureBox12_Click);
            this.closePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.closePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(2, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(111, 18);
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
            // ribbonOrbSubjects
            // 
            this.ribbonOrbSubjects.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbSubjects.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSubjects.Image")));
            this.ribbonOrbSubjects.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSubjects.SmallImage")));
            // 
            // ribbonOrbGrades
            // 
            this.ribbonOrbGrades.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbGrades.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbGrades.Image")));
            this.ribbonOrbGrades.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbGrades.SmallImage")));
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            // 
            // ribbonOrbSemesterNew
            // 
            this.ribbonOrbSemesterNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSemesterNew.Image")));
            this.ribbonOrbSemesterNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSemesterNew.SmallImage")));
            // 
            // ribbonOrbReports
            // 
            this.ribbonOrbReports.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbReports.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbReports.Image")));
            this.ribbonOrbReports.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbReports.SmallImage")));
            // 
            // ribbonOrbStatistics
            // 
            this.ribbonOrbStatistics.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbStatistics.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbStatistics.Image")));
            this.ribbonOrbStatistics.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbStatistics.SmallImage")));
            // 
            // ribbonOrbRanking
            // 
            this.ribbonOrbRanking.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbRanking.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRanking.Image")));
            this.ribbonOrbRanking.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRanking.SmallImage")));
            // 
            // ribbonOrbHelp
            // 
            this.ribbonOrbHelp.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbHelp.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbHelp.Image")));
            this.ribbonOrbHelp.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbHelp.SmallImage")));
            // 
            // ribbonTopLoginButton
            // 
            this.ribbonTopLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTopLoginButton.Image")));
            this.ribbonTopLoginButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.ribbonTopLoginButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonTopLoginButton.SmallImage")));
            this.ribbonTopLoginButton.Text = "";
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "fMainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
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
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button semesterBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button statisticsBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button rankingBtn;
        private System.Windows.Forms.Button gradeBtn;
        private System.Windows.Forms.Button subjectsBtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button assignmentsBtn;


    }
}

