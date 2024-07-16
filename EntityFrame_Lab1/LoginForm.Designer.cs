namespace EntityFrame_Lab1
{
    partial class LoginForm
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
            label1 = new Label();
            label3 = new Label();
            txt_userName = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 5);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(384, 31);
            label1.TabIndex = 0;
            label1.Text = "School Management System | Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(133, 177);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 38);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(330, 177);
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "Enter Your Frist Name";
            txt_userName.Size = new Size(282, 38);
            txt_userName.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(330, 313);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Enter Your Id";
            txt_password.Size = new Size(282, 38);
            txt_password.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Teal;
            btn_login.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Honeydew;
            btn_login.Location = new Point(382, 435);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(123, 52);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(133, 313);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 43);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(853, 5);
            label4.Name = "label4";
            label4.Size = new Size(29, 31);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(590, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(887, 617);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_userName);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txt_userName;
        private TextBox txt_password;
        private Button btn_login;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
    }
}