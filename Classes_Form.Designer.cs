namespace Grade_Manager_DB_Controller
{
    partial class Classes_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.classTxt = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.classesComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.classTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.createBtn, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load Classes";
            // 
            // classesComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.classesComboBox, 2);
            this.classesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(163, 3);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(315, 21);
            this.classesComboBox.TabIndex = 1;
            // 
            // loadBtn
            // 
            this.loadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadBtn.Location = new System.Drawing.Point(323, 31);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(155, 22);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load Class";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Class";
            // 
            // classTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.classTxt, 2);
            this.classTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classTxt.Location = new System.Drawing.Point(163, 69);
            this.classTxt.Name = "classTxt";
            this.classTxt.Size = new System.Drawing.Size(315, 20);
            this.classTxt.TabIndex = 4;
            // 
            // createBtn
            // 
            this.createBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createBtn.Location = new System.Drawing.Point(323, 97);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(155, 24);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create Class";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // Classes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 124);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Classes_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Classes_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classTxt;
        private System.Windows.Forms.Button createBtn;
    }
}