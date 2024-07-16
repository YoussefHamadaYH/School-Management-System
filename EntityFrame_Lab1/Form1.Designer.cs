namespace EntityFrame_Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_student = new DataGridView();
            txt_fname = new TextBox();
            txt_address = new TextBox();
            txt_lname = new TextBox();
            nud_age = new NumericUpDown();
            cb_dept = new ComboBox();
            F_Name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_search = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(20, 60);
            dgv_student.Margin = new Padding(4);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 51;
            dgv_student.Size = new Size(642, 359);
            dgv_student.TabIndex = 0;
            dgv_student.RowHeaderMouseDoubleClick += dgv_student_RowHeaderMouseDoubleClick;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(162, 41);
            txt_fname.Margin = new Padding(4);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(170, 34);
            txt_fname.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(483, 44);
            txt_address.Margin = new Padding(4);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(170, 34);
            txt_address.TabIndex = 3;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(161, 137);
            txt_lname.Margin = new Padding(4);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(170, 34);
            txt_lname.TabIndex = 4;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(483, 140);
            nud_age.Margin = new Padding(4);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(170, 34);
            nud_age.TabIndex = 5;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(802, 40);
            cb_dept.Margin = new Padding(4);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(142, 36);
            cb_dept.TabIndex = 6;
            // 
            // F_Name
            // 
            F_Name.AutoSize = true;
            F_Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            F_Name.Location = new Point(72, 44);
            F_Name.Margin = new Padding(4, 0, 4, 0);
            F_Name.Name = "F_Name";
            F_Name.Size = new Size(86, 28);
            F_Name.TabIndex = 7;
            F_Name.Text = "F_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(73, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 8;
            label2.Text = "L_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(394, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(375, 47);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 10;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(679, 44);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 11;
            label5.Text = "Dept_Name";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.Transparent;
            btn_add.Location = new Point(162, 236);
            btn_add.Margin = new Padding(4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(129, 41);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_update.ForeColor = Color.Transparent;
            btn_update.Location = new Point(385, 236);
            btn_update.Margin = new Padding(4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(129, 41);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.Transparent;
            btn_delete.Location = new Point(632, 236);
            btn_delete.Margin = new Padding(4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(129, 41);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Teal;
            btn_search.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_search.ForeColor = Color.Transparent;
            btn_search.Location = new Point(840, 236);
            btn_search.Margin = new Padding(4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(129, 41);
            btn_search.TabIndex = 15;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 819);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 819);
            panel1.TabIndex = 23;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.s;
            panel9.Location = new Point(38, 461);
            panel9.Name = "panel9";
            panel9.Size = new Size(53, 54);
            panel9.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.Add_Teacher;
            panel8.Location = new Point(38, 558);
            panel8.Name = "panel8";
            panel8.Size = new Size(65, 62);
            panel8.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.icons8_dashboard_48;
            panel7.Location = new Point(40, 355);
            panel7.Name = "panel7";
            panel7.Size = new Size(51, 50);
            panel7.TabIndex = 6;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Transparent;
            button6.Image = Properties.Resources.icons8_logout_64;
            button6.Location = new Point(30, 712);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(87, 83);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(30, 546);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(275, 87);
            button7.TabIndex = 4;
            button7.Text = "   Add Instructor ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(30, 447);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(275, 79);
            button8.TabIndex = 3;
            button8.Text = "Add Student ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(30, 344);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(275, 77);
            button5.TabIndex = 2;
            button5.Text = "Dashbord";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(38, 228);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 28);
            label7.TabIndex = 1;
            label7.Text = "Welcome Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.student_education_;
            pictureBox2.Image = Properties.Resources.sssssss1;
            pictureBox2.Location = new Point(52, 25);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 182);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(22, 679);
            button4.Name = "button4";
            button4.Size = new Size(94, 44);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;

            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(22, 391);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 4;
            button3.Text = "Add Instructor ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(22, 319);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 3;
            button2.Text = "Add Student ";
            button2.UseVisualStyleBackColor = true;
        
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(22, 246);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 2;
            button1.Text = "Dashbord";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(28, 163);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 1;
            label6.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.student_education_;
            pictureBox1.Image = Properties.Resources.sssssss1;
            pictureBox1.Location = new Point(39, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dgv_student);
            panel3.Location = new Point(475, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(682, 433);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 1;
            label1.Text = "Student`s Data";
            // 
            // panel4
            // 
            panel4.Controls.Add(F_Name);
            panel4.Controls.Add(txt_fname);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txt_lname);
            panel4.Controls.Add(btn_search);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btn_delete);
            panel4.Controls.Add(txt_address);
            panel4.Controls.Add(btn_update);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btn_add);
            panel4.Controls.Add(nud_age);
            panel4.Controls.Add(cb_dept);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(336, 451);
            panel4.Name = "panel4";
            panel4.Size = new Size(1001, 298);
            panel4.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1366, 819);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_student;
        private TextBox txt_fname;
        private TextBox txt_address;
        private TextBox txt_lname;
        private NumericUpDown nud_age;
        private ComboBox cb_dept;
        private Label F_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_search;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel panel1;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button5;
        private Label label7;
        private PictureBox pictureBox2;
    }
}
