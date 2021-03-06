﻿namespace Grade_Manager_DB_Controller
{
    partial class Student_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Management));
            this.studentDataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addNewStudentPictureBox = new System.Windows.Forms.PictureBox();
            this.studentDataGridContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewStudentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataGridContextMenu
            // 
            this.studentDataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.studentDataGridContextMenu.Name = "studentDataGridContextMenu";
            this.studentDataGridContextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // studentGridView
            // 
            this.studentGridView.AllowUserToAddRows = false;
            this.studentGridView.AllowUserToDeleteRows = false;
            this.studentGridView.AllowUserToOrderColumns = true;
            this.studentGridView.AllowUserToResizeRows = false;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.ContextMenuStrip = this.studentDataGridContextMenu;
            this.studentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridView.Location = new System.Drawing.Point(0, 48);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.ReadOnly = true;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.ShowEditingIcon = false;
            this.studentGridView.Size = new System.Drawing.Size(716, 579);
            this.studentGridView.TabIndex = 1;
            this.studentGridView.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.studentGridView_CellContextMenuStripNeeded);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.maximizePictureBox);
            this.panel2.Controls.Add(this.minimizePictureBox);
            this.panel2.Controls.Add(this.closePictureBox);
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 29);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.BackColor = System.Drawing.Color.White;
            this.maximizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizePictureBox.BackgroundImage")));
            this.maximizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizePictureBox.Location = new System.Drawing.Point(638, 0);
            this.maximizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maximizePictureBox.Size = new System.Drawing.Size(26, 29);
            this.maximizePictureBox.TabIndex = 6;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Tag = "maximize";
            this.maximizePictureBox.Click += new System.EventHandler(this.maximizePictureBox_Click);
            this.maximizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.maximizePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.maximizePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.maximizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.White;
            this.minimizePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.BackgroundImage")));
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Location = new System.Drawing.Point(664, 0);
            this.minimizePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimizePictureBox.Size = new System.Drawing.Size(26, 29);
            this.minimizePictureBox.TabIndex = 5;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Tag = "minimize";
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            this.minimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.minimizePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.minimizePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.minimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.White;
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Location = new System.Drawing.Point(690, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.closePictureBox.Size = new System.Drawing.Size(26, 29);
            this.closePictureBox.TabIndex = 3;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Tag = "close";
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            this.closePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.closePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DimGray;
            this.titleLabel.Location = new System.Drawing.Point(263, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(169, 15);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Student Management";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 656);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.studentGridView);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 627);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.addNewStudentPictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(716, 48);
            this.panel4.TabIndex = 2;
            // 
            // addNewStudentPictureBox
            // 
            this.addNewStudentPictureBox.BackgroundImage = global::Grade_Manager_DB_Controller.Properties.Resources.add;
            this.addNewStudentPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewStudentPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewStudentPictureBox.Location = new System.Drawing.Point(20, 6);
            this.addNewStudentPictureBox.Name = "addNewStudentPictureBox";
            this.addNewStudentPictureBox.Size = new System.Drawing.Size(32, 32);
            this.addNewStudentPictureBox.TabIndex = 0;
            this.addNewStudentPictureBox.TabStop = false;
            this.addNewStudentPictureBox.Tag = "add_student";
            this.addNewStudentPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addNewStudentPictureBox_MouseClick);
            this.addNewStudentPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addNewStudentPictureBox_MouseDown);
            this.addNewStudentPictureBox.MouseEnter += new System.EventHandler(this.addNewStudentPictureBox_MouseEnter);
            this.addNewStudentPictureBox.MouseLeave += new System.EventHandler(this.addNewStudentPictureBox_MouseLeave);
            this.addNewStudentPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addNewStudentPictureBox_MouseUp);
            // 
            // Student_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Management";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Student_Management_Paint);
            this.studentDataGridContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addNewStudentPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip studentDataGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox addNewStudentPictureBox;


    }
}