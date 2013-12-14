namespace Grade_Manager_DB_Controller
{
    partial class Assessments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterSubject = new System.Windows.Forms.CheckBox();
            this.filterTimePeriod = new System.Windows.Forms.CheckBox();
            this.filterTypeCheckbox = new System.Windows.Forms.CheckBox();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterSubjectCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filterDateTo = new System.Windows.Forms.DateTimePicker();
            this.filterDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assessDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.assessTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.assessmentDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 167);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterSubject);
            this.groupBox2.Controls.Add(this.filterTimePeriod);
            this.groupBox2.Controls.Add(this.filterTypeCheckbox);
            this.groupBox2.Controls.Add(this.clearFilterBtn);
            this.groupBox2.Controls.Add(this.filterBtn);
            this.groupBox2.Controls.Add(this.filterSubjectCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.filterDateTo);
            this.groupBox2.Controls.Add(this.filterDateFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.filterTypeCombo);
            this.groupBox2.Location = new System.Drawing.Point(322, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // filterSubject
            // 
            this.filterSubject.AutoSize = true;
            this.filterSubject.Location = new System.Drawing.Point(6, 78);
            this.filterSubject.Name = "filterSubject";
            this.filterSubject.Size = new System.Drawing.Size(62, 17);
            this.filterSubject.TabIndex = 15;
            this.filterSubject.Text = "Subject";
            this.filterSubject.UseVisualStyleBackColor = true;
            this.filterSubject.CheckedChanged += new System.EventHandler(this.filterSubject_CheckedChanged);
            // 
            // filterTimePeriod
            // 
            this.filterTimePeriod.AutoSize = true;
            this.filterTimePeriod.Location = new System.Drawing.Point(6, 51);
            this.filterTimePeriod.Name = "filterTimePeriod";
            this.filterTimePeriod.Size = new System.Drawing.Size(82, 17);
            this.filterTimePeriod.TabIndex = 14;
            this.filterTimePeriod.Text = "Time Period";
            this.filterTimePeriod.UseVisualStyleBackColor = true;
            this.filterTimePeriod.CheckedChanged += new System.EventHandler(this.filterTimePeriod_CheckedChanged);
            // 
            // filterTypeCheckbox
            // 
            this.filterTypeCheckbox.AutoSize = true;
            this.filterTypeCheckbox.Location = new System.Drawing.Point(6, 25);
            this.filterTypeCheckbox.Name = "filterTypeCheckbox";
            this.filterTypeCheckbox.Size = new System.Drawing.Size(50, 17);
            this.filterTypeCheckbox.TabIndex = 13;
            this.filterTypeCheckbox.Text = "Type";
            this.filterTypeCheckbox.UseVisualStyleBackColor = true;
            this.filterTypeCheckbox.CheckedChanged += new System.EventHandler(this.filterTypeCheckbox_CheckedChanged);
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.Location = new System.Drawing.Point(195, 131);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(75, 23);
            this.clearFilterBtn.TabIndex = 11;
            this.clearFilterBtn.Text = "Clear Filter";
            this.clearFilterBtn.UseVisualStyleBackColor = true;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(278, 131);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 23);
            this.filterBtn.TabIndex = 10;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterSubjectCombo
            // 
            this.filterSubjectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSubjectCombo.Enabled = false;
            this.filterSubjectCombo.FormattingEnabled = true;
            this.filterSubjectCombo.Location = new System.Drawing.Point(123, 75);
            this.filterSubjectCombo.Name = "filterSubjectCombo";
            this.filterSubjectCombo.Size = new System.Drawing.Size(121, 21);
            this.filterSubjectCombo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "--";
            // 
            // filterDateTo
            // 
            this.filterDateTo.CustomFormat = "dd/MM/yyyy";
            this.filterDateTo.Enabled = false;
            this.filterDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filterDateTo.Location = new System.Drawing.Point(246, 49);
            this.filterDateTo.Name = "filterDateTo";
            this.filterDateTo.Size = new System.Drawing.Size(98, 20);
            this.filterDateTo.TabIndex = 6;
            // 
            // filterDateFrom
            // 
            this.filterDateFrom.CustomFormat = "dd/MM/yyyy";
            this.filterDateFrom.Enabled = false;
            this.filterDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filterDateFrom.Location = new System.Drawing.Point(123, 49);
            this.filterDateFrom.Name = "filterDateFrom";
            this.filterDateFrom.Size = new System.Drawing.Size(98, 20);
            this.filterDateFrom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // filterTypeCombo
            // 
            this.filterTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeCombo.Enabled = false;
            this.filterTypeCombo.FormattingEnabled = true;
            this.filterTypeCombo.Location = new System.Drawing.Point(123, 17);
            this.filterTypeCombo.Name = "filterTypeCombo";
            this.filterTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.filterTypeCombo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.subjectComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.assessDatePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.assessTypeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(232, 131);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(55, 78);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(121, 21);
            this.subjectComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // assessDatePicker
            // 
            this.assessDatePicker.Location = new System.Drawing.Point(55, 49);
            this.assessDatePicker.Name = "assessDatePicker";
            this.assessDatePicker.Size = new System.Drawing.Size(200, 20);
            this.assessDatePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // assessTypeComboBox
            // 
            this.assessTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assessTypeComboBox.FormattingEnabled = true;
            this.assessTypeComboBox.Location = new System.Drawing.Point(56, 22);
            this.assessTypeComboBox.Name = "assessTypeComboBox";
            this.assessTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.assessTypeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.assessmentDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 321);
            this.panel2.TabIndex = 1;
            // 
            // assessmentDataGridView
            // 
            this.assessmentDataGridView.AllowUserToAddRows = false;
            this.assessmentDataGridView.AllowUserToDeleteRows = false;
            this.assessmentDataGridView.AllowUserToOrderColumns = true;
            this.assessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assessmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assessmentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.assessmentDataGridView.MultiSelect = false;
            this.assessmentDataGridView.Name = "assessmentDataGridView";
            this.assessmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assessmentDataGridView.ShowEditingIcon = false;
            this.assessmentDataGridView.Size = new System.Drawing.Size(818, 321);
            this.assessmentDataGridView.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Assessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Assessments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assessments";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker assessDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox assessTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView assessmentDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearFilterBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ComboBox filterSubjectCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker filterDateTo;
        private System.Windows.Forms.DateTimePicker filterDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterTypeCombo;
        private System.Windows.Forms.CheckBox filterSubject;
        private System.Windows.Forms.CheckBox filterTimePeriod;
        private System.Windows.Forms.CheckBox filterTypeCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}