namespace Grade_Manager_DB_Controller
{
    partial class Grade_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grade_Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.assessmentComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SemesterTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentGradeDataViewGrid = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeDataViewGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.subjectComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.assessmentComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SemesterTextBox);
            this.panel1.Controls.Add(this.yearTextBox);
            this.panel1.Controls.Add(this.classTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 194);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tips\r\n*Double click a grade to edit it.\r\n*Grades are saved automatically.";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(76, 101);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(100, 21);
            this.subjectComboBox.TabIndex = 11;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subject";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(184, 32);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 85);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save Grades";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // assessmentComboBox
            // 
            this.assessmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assessmentComboBox.FormattingEnabled = true;
            this.assessmentComboBox.Location = new System.Drawing.Point(76, 128);
            this.assessmentComboBox.Name = "assessmentComboBox";
            this.assessmentComboBox.Size = new System.Drawing.Size(100, 21);
            this.assessmentComboBox.TabIndex = 8;
            this.assessmentComboBox.SelectedIndexChanged += new System.EventHandler(this.assessmentComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Assessment";
            // 
            // SemesterTextBox
            // 
            this.SemesterTextBox.Location = new System.Drawing.Point(76, 75);
            this.SemesterTextBox.Name = "SemesterTextBox";
            this.SemesterTextBox.ReadOnly = true;
            this.SemesterTextBox.Size = new System.Drawing.Size(100, 20);
            this.SemesterTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(76, 53);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 5;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(76, 32);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.ReadOnly = true;
            this.classTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studentGradeDataViewGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 309);
            this.panel2.TabIndex = 1;
            // 
            // studentGradeDataViewGrid
            // 
            this.studentGradeDataViewGrid.AllowUserToAddRows = false;
            this.studentGradeDataViewGrid.AllowUserToDeleteRows = false;
            this.studentGradeDataViewGrid.AllowUserToResizeRows = false;
            this.studentGradeDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradeDataViewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGradeDataViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.studentGradeDataViewGrid.Location = new System.Drawing.Point(0, 0);
            this.studentGradeDataViewGrid.MultiSelect = false;
            this.studentGradeDataViewGrid.Name = "studentGradeDataViewGrid";
            this.studentGradeDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGradeDataViewGrid.ShowEditingIcon = false;
            this.studentGradeDataViewGrid.Size = new System.Drawing.Size(475, 309);
            this.studentGradeDataViewGrid.TabIndex = 0;
            this.studentGradeDataViewGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGradeDataViewGrid_CellDoubleClick);
            this.studentGradeDataViewGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGradeDataViewGrid_CellEndEdit);
            this.studentGradeDataViewGrid.CurrentCellChanged += new System.EventHandler(this.studentGradeDataViewGrid_CurrentCellChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(4, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(475, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.maximizePictureBox);
            this.panel3.Controls.Add(this.minimizePictureBox);
            this.panel3.Controls.Add(this.closePictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 29);
            this.panel3.TabIndex = 3;
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(397, 0);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 29);
            this.maximizePictureBox.TabIndex = 5;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Tag = "maximize";
            this.maximizePictureBox.Visible = false;
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minimizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.BackgroundImage")));
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Location = new System.Drawing.Point(423, 0);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 29);
            this.minimizePictureBox.TabIndex = 4;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Tag = "minimize";
            this.minimizePictureBox.Visible = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Location = new System.Drawing.Point(449, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 29);
            this.closePictureBox.TabIndex = 3;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Tag = "close";
            this.closePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closePictureBox_MouseClick);
            this.closePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.closePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 2000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // Grade_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(483, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Grade_Main_Form";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Grade_Main_Form_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeDataViewGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SemesterTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView studentGradeDataViewGrid;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox assessmentComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.Label label7;
    }
}