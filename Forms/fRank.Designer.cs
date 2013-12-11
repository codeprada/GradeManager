namespace Grade_Manager_DB_Controller
{
    partial class Rank
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rankListView = new System.Windows.Forms.ListView();
            this.rank_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.average_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roundedRB = new System.Windows.Forms.RadioButton();
            this.preciseRB = new System.Windows.Forms.RadioButton();
            this.generateBtn = new System.Windows.Forms.Button();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.subjectComboBox);
            this.groupBox1.Controls.Add(this.generateBtn);
            this.groupBox1.Controls.Add(this.preciseRB);
            this.groupBox1.Controls.Add(this.roundedRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rankListView);
            this.groupBox2.Location = new System.Drawing.Point(170, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 490);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rank List";
            // 
            // rankListView
            // 
            this.rankListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rank_column,
            this.student_column,
            this.average_column});
            this.rankListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rankListView.FullRowSelect = true;
            this.rankListView.Location = new System.Drawing.Point(3, 16);
            this.rankListView.Name = "rankListView";
            this.rankListView.Size = new System.Drawing.Size(342, 471);
            this.rankListView.TabIndex = 0;
            this.rankListView.UseCompatibleStateImageBehavior = false;
            this.rankListView.View = System.Windows.Forms.View.Details;
            // 
            // rank_column
            // 
            this.rank_column.Text = "Rank";
            this.rank_column.Width = 40;
            // 
            // student_column
            // 
            this.student_column.Text = "Student";
            this.student_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.student_column.Width = 130;
            // 
            // average_column
            // 
            this.average_column.Text = "Average";
            this.average_column.Width = 165;
            // 
            // roundedRB
            // 
            this.roundedRB.AutoSize = true;
            this.roundedRB.Location = new System.Drawing.Point(7, 20);
            this.roundedRB.Name = "roundedRB";
            this.roundedRB.Size = new System.Drawing.Size(69, 17);
            this.roundedRB.TabIndex = 0;
            this.roundedRB.TabStop = true;
            this.roundedRB.Text = "Rounded";
            this.roundedRB.UseVisualStyleBackColor = true;
            // 
            // preciseRB
            // 
            this.preciseRB.AutoSize = true;
            this.preciseRB.Location = new System.Drawing.Point(7, 44);
            this.preciseRB.Name = "preciseRB";
            this.preciseRB.Size = new System.Drawing.Size(60, 17);
            this.preciseRB.TabIndex = 1;
            this.preciseRB.TabStop = true;
            this.preciseRB.Text = "Precise";
            this.preciseRB.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(7, 112);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(139, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(50, 85);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(96, 21);
            this.subjectComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject";
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Rank";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView rankListView;
        private System.Windows.Forms.ColumnHeader rank_column;
        private System.Windows.Forms.ColumnHeader student_column;
        private System.Windows.Forms.ColumnHeader average_column;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.RadioButton preciseRB;
        private System.Windows.Forms.RadioButton roundedRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectComboBox;
    }
}