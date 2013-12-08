﻿namespace Grade_Manager
{
    partial class Semester_Form
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
            this.semesterListView = new System.Windows.Forms.ListView();
            this.semester_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.current_term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.starting_school_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ending_school_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // semesterListView
            // 
            this.semesterListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.semesterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semester_id,
            this.class_name,
            this.current_term,
            this.starting_school_year,
            this.ending_school_year});
            this.semesterListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterListView.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.semesterListView.FullRowSelect = true;
            this.semesterListView.HideSelection = false;
            this.semesterListView.Location = new System.Drawing.Point(0, 0);
            this.semesterListView.Name = "semesterListView";
            this.semesterListView.Size = new System.Drawing.Size(405, 379);
            this.semesterListView.TabIndex = 5;
            this.semesterListView.UseCompatibleStateImageBehavior = false;
            this.semesterListView.View = System.Windows.Forms.View.Details;
            this.semesterListView.DoubleClick += new System.EventHandler(this.loadBtn_Click);
            // 
            // semester_id
            // 
            this.semester_id.Text = "ID";
            this.semester_id.Width = 34;
            // 
            // class_name
            // 
            this.class_name.Text = "Class";
            this.class_name.Width = 75;
            // 
            // current_term
            // 
            this.current_term.Text = "Term/Semester";
            this.current_term.Width = 99;
            // 
            // starting_school_year
            // 
            this.starting_school_year.Text = "Beginning Year";
            this.starting_school_year.Width = 98;
            // 
            // ending_school_year
            // 
            this.ending_school_year.Text = "Ending Year";
            this.ending_school_year.Width = 92;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.semesterListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 379);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.loadBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.newBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(406, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 379);
            this.panel2.TabIndex = 7;
            // 
            // loadBtn
            // 
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadBtn.Location = new System.Drawing.Point(0, 269);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(71, 55);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Tag = "load";
            this.loadBtn.Text = "Load";
            this.loadBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = global::Grade_Manager_DB_Controller.Properties.Resources.cancel;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelBtn.Location = new System.Drawing.Point(0, 324);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(71, 55);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Tag = "cancel";
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.newBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newBtn.FlatAppearance.BorderSize = 0;
            this.newBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.newBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newBtn.Location = new System.Drawing.Point(0, 0);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(71, 55);
            this.newBtn.TabIndex = 0;
            this.newBtn.Tag = "new";
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // Semester_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(478, 381);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Semester_Form";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Semesters";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView semesterListView;
        private System.Windows.Forms.ColumnHeader semester_id;
        private System.Windows.Forms.ColumnHeader class_name;
        private System.Windows.Forms.ColumnHeader starting_school_year;
        private System.Windows.Forms.ColumnHeader ending_school_year;
        private System.Windows.Forms.ColumnHeader current_term;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button newBtn;
    }
}