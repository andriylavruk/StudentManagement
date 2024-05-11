namespace StudentManagement.Views
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
            login_btn = new Button();
            login_login_label = new Label();
            login_password_label = new Label();
            login_email_textBox = new TextBox();
            login_password_textBox = new TextBox();
            Login = new Label();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.Location = new Point(136, 229);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(95, 23);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // login_login_label
            // 
            login_login_label.AutoSize = true;
            login_login_label.Location = new Point(81, 106);
            login_login_label.Name = "login_login_label";
            login_login_label.Size = new Size(37, 15);
            login_login_label.TabIndex = 1;
            login_login_label.Text = "Login";
            // 
            // login_password_label
            // 
            login_password_label.AutoSize = true;
            login_password_label.Location = new Point(81, 164);
            login_password_label.Name = "login_password_label";
            login_password_label.Size = new Size(57, 15);
            login_password_label.TabIndex = 2;
            login_password_label.Text = "Password";
            // 
            // login_email_textBox
            // 
            login_email_textBox.Location = new Point(81, 124);
            login_email_textBox.Name = "login_email_textBox";
            login_email_textBox.Size = new Size(214, 23);
            login_email_textBox.TabIndex = 3;
            // 
            // login_password_textBox
            // 
            login_password_textBox.Location = new Point(81, 182);
            login_password_textBox.Name = "login_password_textBox";
            login_password_textBox.PasswordChar = '*';
            login_password_textBox.Size = new Size(214, 23);
            login_password_textBox.TabIndex = 4;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 23F);
            Login.Location = new Point(136, 31);
            Login.Name = "Login";
            Login.Size = new Size(112, 42);
            Login.TabIndex = 5;
            Login.Text = "Sign in";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 290);
            Controls.Add(Login);
            Controls.Add(login_password_textBox);
            Controls.Add(login_email_textBox);
            Controls.Add(login_password_label);
            Controls.Add(login_login_label);
            Controls.Add(login_btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private Label login_login_label;
        private Label login_password_label;
        private TextBox login_email_textBox;
        private TextBox login_password_textBox;
        private Label Login;
    }
}