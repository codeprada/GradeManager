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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects_Form));
            this.addNewLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.subjectCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewLink
            // 
            this.addNewLink.AutoSize = true;
            this.addNewLink.Location = new System.Drawing.Point(257, 11);
            this.addNewLink.Name = "addNewLink";
            this.addNewLink.Size = new System.Drawing.Size(68, 13);
            this.addNewLink.TabIndex = 5;
            this.addNewLink.TabStop = true;
            this.addNewLink.Text = "New Subject";
            this.addNewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select A Class";
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(93, 6);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(122, 21);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // subjectCheckListBox
            // 
            this.subjectCheckListBox.CheckOnClick = true;
            this.subjectCheckListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subjectCheckListBox.FormattingEnabled = true;
            this.subjectCheckListBox.Location = new System.Drawing.Point(2, 29);
            this.subjectCheckListBox.Name = "subjectCheckListBox";
            this.subjectCheckListBox.Size = new System.Drawing.Size(323, 289);
            this.subjectCheckListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.addNewLink);
            this.panel1.Controls.Add(this.classComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subjectCheckListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(327, 320);
            this.panel1.TabIndex = 3;
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
            this.panel3.Size = new System.Drawing.Size(327, 29);
            this.panel3.TabIndex = 4;
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(249, 0);
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
            this.minimizePictureBox.Location = new System.Drawing.Point(275, 0);
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
            this.closePictureBox.Location = new System.Drawing.Point(301, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 29);
            this.closePictureBox.TabIndex = 3;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Tag = "close";
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(4, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(327, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Subjects_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(335, 379);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subjects_Form";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Subjects_Form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Subjects_Form_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox subjectCheckListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.LinkLabel addNewLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}