namespace Grade_Manager
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.semester_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.current_term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.starting_school_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ending_school_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semester_id,
            this.class_name,
            this.current_term,
            this.starting_school_year,
            this.ending_school_year});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 379);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.loadBtn_Click);
            // 
            // semester_id
            // 
            this.semester_id.Text = "ID";
            // 
            // class_name
            // 
            this.class_name.Text = "Class";
            // 
            // current_term
            // 
            this.current_term.Text = "Term/Semester";
            this.current_term.Width = 95;
            // 
            // starting_school_year
            // 
            this.starting_school_year.Text = "Beginning Year";
            this.starting_school_year.Width = 90;
            // 
            // ending_school_year
            // 
            this.ending_school_year.Text = "Ending Year";
            this.ending_school_year.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 379);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loadBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.newBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(400, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 379);
            this.panel2.TabIndex = 7;
            // 
            // newBtn
            // 
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
            // cancelBtn
            // 
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
            // loadBtn
            // 
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
            // Semester_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 381);
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

        private System.Windows.Forms.ListView listView1;
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