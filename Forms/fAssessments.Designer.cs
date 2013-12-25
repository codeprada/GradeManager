namespace Grade_Manager_DB_Controller
{
    partial class fAssessments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAssessments));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.assessmentDataGridView = new System.Windows.Forms.DataGridView();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentDataGridView)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 179);
            this.panel1.TabIndex = 0;
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
            this.groupBox2.BackColor = System.Drawing.Color.White;
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
            this.groupBox2.Size = new System.Drawing.Size(423, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // filterSubject
            // 
            this.filterSubject.AutoSize = true;
            this.filterSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSubject.Location = new System.Drawing.Point(6, 124);
            this.filterSubject.Name = "filterSubject";
            this.filterSubject.Size = new System.Drawing.Size(59, 17);
            this.filterSubject.TabIndex = 15;
            this.filterSubject.Text = "Subject";
            this.filterSubject.UseVisualStyleBackColor = true;
            this.filterSubject.CheckedChanged += new System.EventHandler(this.filterSubject_CheckedChanged);
            // 
            // filterTimePeriod
            // 
            this.filterTimePeriod.AutoSize = true;
            this.filterTimePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterTimePeriod.Location = new System.Drawing.Point(6, 68);
            this.filterTimePeriod.Name = "filterTimePeriod";
            this.filterTimePeriod.Size = new System.Drawing.Size(79, 17);
            this.filterTimePeriod.TabIndex = 14;
            this.filterTimePeriod.Text = "Time Period";
            this.filterTimePeriod.UseVisualStyleBackColor = true;
            this.filterTimePeriod.CheckedChanged += new System.EventHandler(this.filterTimePeriod_CheckedChanged);
            // 
            // filterTypeCheckbox
            // 
            this.filterTypeCheckbox.AutoSize = true;
            this.filterTypeCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterTypeCheckbox.Location = new System.Drawing.Point(6, 25);
            this.filterTypeCheckbox.Name = "filterTypeCheckbox";
            this.filterTypeCheckbox.Size = new System.Drawing.Size(47, 17);
            this.filterTypeCheckbox.TabIndex = 13;
            this.filterTypeCheckbox.Text = "Type";
            this.filterTypeCheckbox.UseVisualStyleBackColor = true;
            this.filterTypeCheckbox.CheckedChanged += new System.EventHandler(this.filterTypeCheckbox_CheckedChanged);
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearFilterBtn.FlatAppearance.BorderSize = 0;
            this.clearFilterBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.clearFilterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clearFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.cancel;
            this.clearFilterBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearFilterBtn.Location = new System.Drawing.Point(273, 107);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(75, 57);
            this.clearFilterBtn.TabIndex = 11;
            this.clearFilterBtn.Tag = "cancel";
            this.clearFilterBtn.Text = "Clear Filter";
            this.clearFilterBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearFilterBtn.UseVisualStyleBackColor = true;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            this.clearFilterBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.clearFilterBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // filterBtn
            // 
            this.filterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.filterBtn.FlatAppearance.BorderSize = 0;
            this.filterBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.filterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.add;
            this.filterBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.filterBtn.Location = new System.Drawing.Point(342, 107);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 57);
            this.filterBtn.TabIndex = 10;
            this.filterBtn.Tag = "add";
            this.filterBtn.Text = "Filter";
            this.filterBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            this.filterBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.filterBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // filterSubjectCombo
            // 
            this.filterSubjectCombo.Enabled = false;
            this.filterSubjectCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSubjectCombo.FormattingEnabled = true;
            this.filterSubjectCombo.Location = new System.Drawing.Point(91, 123);
            this.filterSubjectCombo.Name = "filterSubjectCombo";
            this.filterSubjectCombo.Size = new System.Drawing.Size(121, 21);
            this.filterSubjectCombo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 70);
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
            this.filterDateTo.Location = new System.Drawing.Point(91, 84);
            this.filterDateTo.Name = "filterDateTo";
            this.filterDateTo.Size = new System.Drawing.Size(200, 20);
            this.filterDateTo.TabIndex = 6;
            // 
            // filterDateFrom
            // 
            this.filterDateFrom.CustomFormat = "dd/MM/yyyy";
            this.filterDateFrom.Enabled = false;
            this.filterDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filterDateFrom.Location = new System.Drawing.Point(91, 49);
            this.filterDateFrom.Name = "filterDateFrom";
            this.filterDateFrom.Size = new System.Drawing.Size(200, 20);
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
            this.filterTypeCombo.Enabled = false;
            this.filterTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterTypeCombo.FormattingEnabled = true;
            this.filterTypeCombo.Location = new System.Drawing.Point(91, 19);
            this.filterTypeCombo.Name = "filterTypeCombo";
            this.filterTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.filterTypeCombo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.subjectComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.assessDatePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.assessTypeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New";
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.save;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveBtn.Location = new System.Drawing.Point(232, 107);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 57);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Tag = "save";
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.assessDatePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.assessDatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.assessDatePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.assessDatePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.assessDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
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
            this.assessTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.assessmentDataGridView);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(2, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(814, 497);
            this.mainPanel.TabIndex = 1;
            // 
            // assessmentDataGridView
            // 
            this.assessmentDataGridView.AllowUserToAddRows = false;
            this.assessmentDataGridView.AllowUserToDeleteRows = false;
            this.assessmentDataGridView.AllowUserToOrderColumns = true;
            this.assessmentDataGridView.AllowUserToResizeRows = false;
            this.assessmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assessmentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.assessmentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assessmentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.assessmentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assessmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assessmentDataGridView.ColumnHeadersHeight = 25;
            this.assessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.assessmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assessmentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.assessmentDataGridView.EnableHeadersVisualStyles = false;
            this.assessmentDataGridView.GridColor = System.Drawing.Color.White;
            this.assessmentDataGridView.Location = new System.Drawing.Point(0, 179);
            this.assessmentDataGridView.MultiSelect = false;
            this.assessmentDataGridView.Name = "assessmentDataGridView";
            this.assessmentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.assessmentDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.assessmentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.assessmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assessmentDataGridView.ShowCellErrors = false;
            this.assessmentDataGridView.ShowCellToolTips = false;
            this.assessmentDataGridView.ShowEditingIcon = false;
            this.assessmentDataGridView.ShowRowErrors = false;
            this.assessmentDataGridView.Size = new System.Drawing.Size(814, 318);
            this.assessmentDataGridView.TabIndex = 0;
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
            this.menuPanel.Size = new System.Drawing.Size(814, 29);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDrag_MouseDown);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(734, 2);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 25);
            this.maximizePictureBox.TabIndex = 2;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Tag = "maximize";
            this.maximizePictureBox.Click += new System.EventHandler(this.maximizePictureBox_Click);
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
            this.minimizePictureBox.Location = new System.Drawing.Point(760, 2);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 25);
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Tag = "minimize";
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
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
            this.closePictureBox.Location = new System.Drawing.Point(786, 2);
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
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(2, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 18);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Assessments";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDrag_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(2, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(814, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // fAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(818, 552);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAssessments";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assessments";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fAssessments_Paint);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentDataGridView)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
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
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
    }
}