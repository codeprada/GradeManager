namespace Grade_Manager_DB_Controller
{
    partial class fCreateAssessmentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCreateAssessmentType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weightingGroupBox = new System.Windows.Forms.GroupBox();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightingLabel = new System.Windows.Forms.Label();
            this.linkedToGroupBox = new System.Windows.Forms.GroupBox();
            this.linkToComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apartOfLinkGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.assessTypeNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.weightingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            this.linkedToGroupBox.SuspendLayout();
            this.apartOfLinkGroupBox.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 279);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveBtn);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 36);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(120, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(310, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.assessTypeNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weightingGroupBox);
            this.groupBox2.Controls.Add(this.linkedToGroupBox);
            this.groupBox2.Controls.Add(this.apartOfLinkGroupBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assessment Weight";
            // 
            // weightingGroupBox
            // 
            this.weightingGroupBox.Controls.Add(this.weightNumericUpDown);
            this.weightingGroupBox.Controls.Add(this.weightingLabel);
            this.weightingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.weightingGroupBox.Location = new System.Drawing.Point(3, 88);
            this.weightingGroupBox.Name = "weightingGroupBox";
            this.weightingGroupBox.Size = new System.Drawing.Size(286, 47);
            this.weightingGroupBox.TabIndex = 6;
            this.weightingGroupBox.TabStop = false;
            this.weightingGroupBox.Visible = false;
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.weightNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightNumericUpDown.Location = new System.Drawing.Point(95, 14);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.weightNumericUpDown.TabIndex = 7;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // weightingLabel
            // 
            this.weightingLabel.AutoSize = true;
            this.weightingLabel.Location = new System.Drawing.Point(6, 16);
            this.weightingLabel.Name = "weightingLabel";
            this.weightingLabel.Size = new System.Drawing.Size(55, 13);
            this.weightingLabel.TabIndex = 6;
            this.weightingLabel.Text = "Weighting";
            // 
            // linkedToGroupBox
            // 
            this.linkedToGroupBox.Controls.Add(this.linkToComboBox);
            this.linkedToGroupBox.Controls.Add(this.label3);
            this.linkedToGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkedToGroupBox.Location = new System.Drawing.Point(3, 50);
            this.linkedToGroupBox.Name = "linkedToGroupBox";
            this.linkedToGroupBox.Size = new System.Drawing.Size(286, 38);
            this.linkedToGroupBox.TabIndex = 2;
            this.linkedToGroupBox.TabStop = false;
            this.linkedToGroupBox.Visible = false;
            // 
            // linkToComboBox
            // 
            this.linkToComboBox.BackColor = System.Drawing.Color.White;
            this.linkToComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkToComboBox.FormattingEnabled = true;
            this.linkToComboBox.Location = new System.Drawing.Point(95, 10);
            this.linkToComboBox.Name = "linkToComboBox";
            this.linkToComboBox.Size = new System.Drawing.Size(121, 21);
            this.linkToComboBox.Sorted = true;
            this.linkToComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Linked To";
            // 
            // apartOfLinkGroupBox
            // 
            this.apartOfLinkGroupBox.Controls.Add(this.noRadioButton);
            this.apartOfLinkGroupBox.Controls.Add(this.label2);
            this.apartOfLinkGroupBox.Controls.Add(this.yesRadioButton);
            this.apartOfLinkGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.apartOfLinkGroupBox.Location = new System.Drawing.Point(3, 16);
            this.apartOfLinkGroupBox.Name = "apartOfLinkGroupBox";
            this.apartOfLinkGroupBox.Size = new System.Drawing.Size(286, 34);
            this.apartOfLinkGroupBox.TabIndex = 1;
            this.apartOfLinkGroupBox.TabStop = false;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(144, 9);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apart of Link";
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.yesRadioButton.FlatAppearance.BorderSize = 0;
            this.yesRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.yesRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.yesRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.yesRadioButton.Location = new System.Drawing.Point(95, 9);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // assessTypeNameTxt
            // 
            this.assessTypeNameTxt.Location = new System.Drawing.Point(104, 21);
            this.assessTypeNameTxt.Name = "assessTypeNameTxt";
            this.assessTypeNameTxt.Size = new System.Drawing.Size(177, 20);
            this.assessTypeNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
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
            this.menuPanel.Padding = new System.Windows.Forms.Padding(2);
            this.menuPanel.Size = new System.Drawing.Size(310, 29);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(230, 2);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 25);
            this.maximizePictureBox.TabIndex = 2;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Tag = "maximize";
            this.maximizePictureBox.Visible = false;
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.minimizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.BackgroundImage")));
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Location = new System.Drawing.Point(256, 2);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 25);
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Tag = "minimize";
            this.minimizePictureBox.Visible = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Location = new System.Drawing.Point(282, 2);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 25);
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
            this.titleLabel.Location = new System.Drawing.Point(2, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(167, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create Assessment Types";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // fCreateAssessmentType
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(314, 312);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fCreateAssessmentType";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Create Assessment";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fCreateAssessmentType_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.weightingGroupBox.ResumeLayout(false);
            this.weightingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            this.linkedToGroupBox.ResumeLayout(false);
            this.linkedToGroupBox.PerformLayout();
            this.apartOfLinkGroupBox.ResumeLayout(false);
            this.apartOfLinkGroupBox.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox apartOfLinkGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assessTypeNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox linkedToGroupBox;
        private System.Windows.Forms.ComboBox linkToComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox weightingGroupBox;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.Label weightingLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}