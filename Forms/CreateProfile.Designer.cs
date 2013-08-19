namespace Grade_Manager
{
    partial class CreateProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.newClassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingSchoolYearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTermNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingSchoolYearNumeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(210, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // classesComboBox
            // 
            this.classesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(77, 74);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(65, 21);
            this.classesComboBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "/";
            // 
            // endingSchoolYearNumeric
            // 
            this.endingSchoolYearNumeric.Location = new System.Drawing.Point(148, 22);
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
            this.endingSchoolYearNumeric.Size = new System.Drawing.Size(52, 20);
            this.endingSchoolYearNumeric.TabIndex = 10;
            this.endingSchoolYearNumeric.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(125, 186);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // profileDescriptionTxt
            // 
            this.profileDescriptionTxt.Location = new System.Drawing.Point(6, 123);
            this.profileDescriptionTxt.Multiline = true;
            this.profileDescriptionTxt.Name = "profileDescriptionTxt";
            this.profileDescriptionTxt.Size = new System.Drawing.Size(196, 57);
            this.profileDescriptionTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // currentTermNumeric
            // 
            this.currentTermNumeric.Location = new System.Drawing.Point(77, 48);
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
            this.currentTermNumeric.Size = new System.Drawing.Size(52, 20);
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
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semester";
            // 
            // startingSchoolYearNumeric
            // 
            this.startingSchoolYearNumeric.Location = new System.Drawing.Point(77, 22);
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
            this.startingSchoolYearNumeric.Size = new System.Drawing.Size(52, 20);
            this.startingSchoolYearNumeric.TabIndex = 1;
            this.startingSchoolYearNumeric.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Year";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 213);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(210, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // newClassLinkLabel
            // 
            this.newClassLinkLabel.AutoSize = true;
            this.newClassLinkLabel.Location = new System.Drawing.Point(145, 82);
            this.newClassLinkLabel.Name = "newClassLinkLabel";
            this.newClassLinkLabel.Size = new System.Drawing.Size(57, 13);
            this.newClassLinkLabel.TabIndex = 14;
            this.newClassLinkLabel.TabStop = true;
            this.newClassLinkLabel.Text = "New Class";
            this.newClassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newClassLinkLabel_LinkClicked);
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 235);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateProfile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Create New Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingSchoolYearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTermNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingSchoolYearNumeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}