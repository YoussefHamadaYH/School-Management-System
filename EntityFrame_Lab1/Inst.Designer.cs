namespace EntityFrame_Lab1
{
    partial class Inst
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
            panel4 = new Panel();
            btn_update = new Button();
            F_Name = new Label();
            txt_name = new TextBox();
            label4 = new Label();
            btn_delete = new Button();
            txt_degree = new TextBox();
            btn_add = new Button();
            cb_dept = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            dgv_ins = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
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
            panel2 = new Panel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_update);
            panel4.Controls.Add(F_Name);
            panel4.Controls.Add(txt_name);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btn_delete);
            panel4.Controls.Add(txt_degree);
            panel4.Controls.Add(btn_add);
            panel4.Controls.Add(cb_dept);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(397, 495);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(938, 311);
            panel4.TabIndex = 23;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_update.ForeColor = Color.Transparent;
            btn_update.Location = new Point(381, 203);
            btn_update.Margin = new Padding(6);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(177, 57);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // F_Name
            // 
            F_Name.AutoSize = true;
            F_Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            F_Name.Location = new Point(31, 27);
            F_Name.Margin = new Padding(6, 0, 6, 0);
            F_Name.Name = "F_Name";
            F_Name.Size = new Size(68, 28);
            F_Name.TabIndex = 7;
            F_Name.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(155, 28);
            txt_name.Margin = new Padding(6);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(232, 34);
            txt_name.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(448, 27);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 10;
            label4.Text = "Degree";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.Transparent;
            btn_delete.Location = new Point(711, 203);
            btn_delete.Margin = new Padding(6);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(177, 57);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_degree
            // 
            txt_degree.Location = new Point(597, 28);
            txt_degree.Margin = new Padding(6);
            txt_degree.Name = "txt_degree";
            txt_degree.Size = new Size(232, 34);
            txt_degree.TabIndex = 3;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.Transparent;
            btn_add.Location = new Point(65, 203);
            btn_add.Margin = new Padding(6);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(177, 57);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(409, 120);
            cb_dept.Margin = new Padding(6);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(194, 36);
            cb_dept.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(240, 120);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 11;
            label5.Text = "Dept_Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dgv_ins);
            panel3.Location = new Point(522, 13);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 465);
            panel3.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 1;
            label1.Text = "Instructor`s Data";
            label1.Click += label1_Click;
            // 
            // dgv_ins
            // 
            dgv_ins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ins.Location = new Point(28, 58);
            dgv_ins.Margin = new Padding(6);
            dgv_ins.Name = "dgv_ins";
            dgv_ins.RowHeadersWidth = 51;
            dgv_ins.Size = new Size(591, 381);
            dgv_ins.TabIndex = 0;
            dgv_ins.RowHeaderMouseDoubleClick += dgv_ins_RowHeaderMouseDoubleClick;
            // 
            // button4
            // 
            button4.Location = new Point(30, 951);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(129, 62);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(30, 547);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(275, 56);
            button3.TabIndex = 4;
            button3.Text = "Add Instructor ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(30, 447);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(275, 56);
            button2.TabIndex = 3;
            button2.Text = "Add Student ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(30, 344);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(275, 56);
            button1.TabIndex = 2;
            button1.Text = "Dashbord";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(38, 228);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 1;
            label6.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.student_education_;
            pictureBox1.Image = Properties.Resources.sssssss1;
            pictureBox1.Location = new Point(54, 25);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 181);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 819);
            panel1.TabIndex = 23;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.s;
            panel9.Location = new Point(50, 478);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(52, 52);
            panel9.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.Add_Teacher;
            panel8.Location = new Point(41, 611);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(64, 71);
            panel8.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.icons8_dashboard_48;
            panel7.Location = new Point(54, 344);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(48, 50);
            panel7.TabIndex = 6;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Transparent;
            button6.Image = Properties.Resources.icons8_logout_64;
            button6.Location = new Point(30, 736);
            button6.Margin = new Padding(6);
            button6.Name = "button6";
            button6.Size = new Size(88, 68);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(30, 588);
            button7.Margin = new Padding(6);
            button7.Name = "button7";
            button7.Size = new Size(297, 107);
            button7.TabIndex = 4;
            button7.Text = "        Add Instructor ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(30, 447);
            button8.Margin = new Padding(6);
            button8.Name = "button8";
            button8.Size = new Size(297, 103);
            button8.TabIndex = 3;
            button8.Text = "Add Student ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(30, 325);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(297, 90);
            button5.TabIndex = 2;
            button5.Text = "Dashbord";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(52, 241);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 31);
            label7.TabIndex = 1;
            label7.Text = "Welcome Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.student_education_;
            pictureBox2.Image = Properties.Resources.sssssss1;
            pictureBox2.Location = new Point(72, 35);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 152);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 819);
            panel2.TabIndex = 21;
            // 
            // Inst
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 819);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Inst";
            Text = "Inst";
            Load += Inst_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label F_Name;
        private TextBox txt_name;
        private Label label4;
        private Button btn_delete;
        private TextBox txt_degree;
        private Button btn_add;
        private ComboBox cb_dept;
        private Label label5;
        private Panel panel3;
        private Label label1;
        private DataGridView dgv_ins;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private PictureBox pictureBox1;
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
        private Panel panel2;
        private Button btn_update;
    }
}