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
            this.clearBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.profileDescriptionTxt = new System.Windows.Forms.TextBox();
            this.profileNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentTermNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startingSchoolYearNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTermNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingSchoolYearNumeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.profileDescriptionTxt);
            this.groupBox1.Controls.Add(this.profileNameTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currentTermNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.startingSchoolYearNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(194, 236);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(15, 236);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // profileDescriptionTxt
            // 
            this.profileDescriptionTxt.Location = new System.Drawing.Point(15, 120);
            this.profileDescriptionTxt.Multiline = true;
            this.profileDescriptionTxt.Name = "profileDescriptionTxt";
            this.profileDescriptionTxt.Size = new System.Drawing.Size(254, 100);
            this.profileDescriptionTxt.TabIndex = 7;
            // 
            // profileNameTxt
            // 
            this.profileNameTxt.Location = new System.Drawing.Point(133, 13);
            this.profileNameTxt.Name = "profileNameTxt";
            this.profileNameTxt.Size = new System.Drawing.Size(136, 20);
            this.profileNameTxt.TabIndex = 6;
            this.profileNameTxt.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profile Name";
            // 
            // currentTermNumeric
            // 
            this.currentTermNumeric.Location = new System.Drawing.Point(133, 73);
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
            this.currentTermNumeric.Size = new System.Drawing.Size(136, 20);
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
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Term/Semester";
            // 
            // startingSchoolYearNumeric
            // 
            this.startingSchoolYearNumeric.Location = new System.Drawing.Point(133, 43);
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
            this.startingSchoolYearNumeric.Size = new System.Drawing.Size(136, 20);
            this.startingSchoolYearNumeric.TabIndex = 1;
            this.startingSchoolYearNumeric.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting School Year";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(298, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 317);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateProfile";
            this.Text = "Create New Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTermNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingSchoolYearNumeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox profileDescriptionTxt;
        private System.Windows.Forms.TextBox profileNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown currentTermNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startingSchoolYearNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}