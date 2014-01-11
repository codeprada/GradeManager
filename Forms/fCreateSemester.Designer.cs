namespace Grade_Manager
{
    partial class CreateSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSemester));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newClassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endingSchoolYearNumeric = new System.Windows.Forms.NumericUpDown();
            this.createBtn = new System.Windows.Forms.Button();
            this.profileDescriptionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentTermNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startingSchoolYearNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingSchoolYearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTermNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingSchoolYearNumeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newClassLinkLabel);
            this.groupBox1.Controls.Add(this.classesComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.endingSchoolYearNumeric);
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.profileDescriptionTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.currentTermNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.startingSchoolYearNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // newClassLinkLabel
            // 
            this.newClassLinkLabel.AutoSize = true;
            this.newClassLinkLabel.Location = new System.Drawing.Point(167, 82);
            this.newClassLinkLabel.Name = "newClassLinkLabel";
            this.newClassLinkLabel.Size = new System.Drawing.Size(57, 13);
            this.newClassLinkLabel.TabIndex = 14;
            this.newClassLinkLabel.TabStop = true;
            this.newClassLinkLabel.Text = "New Class";
            this.newClassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newClassLinkLabel_LinkClicked);
            // 
            // classesComboBox
            // 
            this.classesComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.classesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(99, 74);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(65, 21);
            this.classesComboBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "/";
            // 
            // endingSchoolYearNumeric
            // 
            this.endingSchoolYearNumeric.BackColor = System.Drawing.SystemColors.Info;
            this.endingSchoolYearNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endingSchoolYearNumeric.Location = new System.Drawing.Point(170, 22);
            this.endingSchoolYearNumeric.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.endingSchoolYearNumeric.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.endingSchoolYearNumeric.Name = "endingSchoolYearNumeric";
            this.endingSchoolYearNumeric.ReadOnly = true;
            this.endingSchoolYearNumeric.Size = new System.Drawing.Size(52, 16);
            this.endingSchoolYearNumeric.TabIndex = 10;
            this.endingSchoolYearNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endingSchoolYearNumeric.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(181, 186);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // profileDescriptionTxt
            // 
            this.profileDescriptionTxt.Location = new System.Drawing.Point(28, 123);
            this.profileDescriptionTxt.Multiline = true;
            this.profileDescriptionTxt.Name = "profileDescriptionTxt";
            this.profileDescriptionTxt.Size = new System.Drawing.Size(228, 57);
            this.profileDescriptionTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // currentTermNumeric
            // 
            this.currentTermNumeric.BackColor = System.Drawing.SystemColors.Info;
            this.currentTermNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentTermNumeric.Location = new System.Drawing.Point(99, 48);
            this.currentTermNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.currentTermNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentTermNumeric.Name = "currentTermNumeric";
            this.currentTermNumeric.ReadOnly = true;
            this.currentTermNumeric.Size = new System.Drawing.Size(52, 16);
            this.currentTermNumeric.TabIndex = 3;
            this.currentTermNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semester";
            // 
            // startingSchoolYearNumeric
            // 
            this.startingSchoolYearNumeric.BackColor = System.Drawing.SystemColors.Info;
            this.startingSchoolYearNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startingSchoolYearNumeric.Location = new System.Drawing.Point(99, 22);
            this.startingSchoolYearNumeric.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.startingSchoolYearNumeric.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.startingSchoolYearNumeric.Name = "startingSchoolYearNumeric";
            this.startingSchoolYearNumeric.ReadOnly = true;
            this.startingSchoolYearNumeric.Size = new System.Drawing.Size(52, 16);
            this.startingSchoolYearNumeric.TabIndex = 1;
            this.startingSchoolYearNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startingSchoolYearNumeric.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.startingSchoolYearNumeric.ValueChanged += new System.EventHandler(this.startingSchoolYearNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Year";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(2, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(285, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 224);
            this.panel1.TabIndex = 2;
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
            this.menuPanel.Location = new System.Drawing.Point(2, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(4);
            this.menuPanel.Size = new System.Drawing.Size(285, 29);
            this.menuPanel.TabIndex = 4;
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(203, 4);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 21);
            this.maximizePictureBox.TabIndex = 2;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Tag = "maximize";
            this.maximizePictureBox.Visible = false;
            this.maximizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseDown);
            this.maximizePictureBox.MouseEnter += new System.EventHandler(this.closePictureBox_MouseEnter);
            this.maximizePictureBox.MouseLeave += new System.EventHandler(this.closePictureBox_MouseLeave);
            this.maximizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseUp);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.minimizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.BackgroundImage")));
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Location = new System.Drawing.Point(229, 4);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 21);
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Tag = "minimize";
            this.minimizePictureBox.Visible = false;
            this.minimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseDown);
            this.minimizePictureBox.MouseEnter += new System.EventHandler(this.closePictureBox_MouseEnter);
            this.minimizePictureBox.MouseLeave += new System.EventHandler(this.closePictureBox_MouseLeave);
            this.minimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseUp);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Location = new System.Drawing.Point(255, 4);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 21);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Tag = "close";
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            this.closePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseDown);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.closePictureBox_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.closePictureBox_MouseLeave);
            this.closePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(4, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create New Semester";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CreateSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(289, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateSemester";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Create New Semester";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateSemester_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingSchoolYearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTermNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingSchoolYearNumeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox profileDescriptionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown currentTermNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startingSchoolYearNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown endingSchoolYearNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.LinkLabel newClassLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label titleLabel;
    }
}