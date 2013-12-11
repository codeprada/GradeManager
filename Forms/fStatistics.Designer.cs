namespace Grade_Manager_DB_Controller
{
    partial class Statistics
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
            this.lineGraphBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lineGraphBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "View a visual representation of each student_id\'s \r\nprogress over a semester with th" +
    "e option to \r\ncompare results side by side with other students.";
            // 
            // lineGraphBtn
            // 
            this.lineGraphBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.chart_line1;
            this.lineGraphBtn.Location = new System.Drawing.Point(6, 19);
            this.lineGraphBtn.Name = "lineGraphBtn";
            this.lineGraphBtn.Size = new System.Drawing.Size(87, 68);
            this.lineGraphBtn.TabIndex = 0;
            this.lineGraphBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lineGraphBtn.UseVisualStyleBackColor = true;
            this.lineGraphBtn.Click += new System.EventHandler(this.lineGraphBtn_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistics";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lineGraphBtn;
    }
}