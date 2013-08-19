namespace Grade_Manager_DB_Controller
{
    partial class Subjects_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.subjectCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.addNewLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewLink);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.classComboBox);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.subjectCheckListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select A Class";
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(98, 25);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(122, 21);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(6, 332);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // subjectCheckListBox
            // 
            this.subjectCheckListBox.CheckOnClick = true;
            this.subjectCheckListBox.FormattingEnabled = true;
            this.subjectCheckListBox.Location = new System.Drawing.Point(6, 52);
            this.subjectCheckListBox.Name = "subjectCheckListBox";
            this.subjectCheckListBox.Size = new System.Drawing.Size(299, 274);
            this.subjectCheckListBox.TabIndex = 0;
            // 
            // addNewLink
            // 
            this.addNewLink.AutoSize = true;
            this.addNewLink.Location = new System.Drawing.Point(237, 33);
            this.addNewLink.Name = "addNewLink";
            this.addNewLink.Size = new System.Drawing.Size(68, 13);
            this.addNewLink.TabIndex = 5;
            this.addNewLink.TabStop = true;
            this.addNewLink.Text = "New Subject";
            this.addNewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewLink_LinkClicked);
            // 
            // Subjects_Form
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 379);
            this.Controls.Add(this.groupBox1);
            this.Name = "Subjects_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox subjectCheckListBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.LinkLabel addNewLink;
    }
}