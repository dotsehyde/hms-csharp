namespace HMS
{
    partial class RegisterForm
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
            label4 = new Label();
            regBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtConPassword = new TextBox();
            loginLink = new LinkLabel();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 120);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 15;
            label4.Text = "Create a new account";
            // 
            // regBtn
            // 
            regBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regBtn.Location = new Point(201, 340);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(173, 48);
            regBtn.TabIndex = 13;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 231);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Password*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 178);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 11;
            label2.Text = "Username*:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(204, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(204, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 68);
            label1.Name = "label1";
            label1.Size = new Size(325, 31);
            label1.TabIndex = 8;
            label1.Text = "Hospital Management System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 285);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 17;
            label5.Text = "Confirm Password*:";
            // 
            // txtConPassword
            // 
            txtConPassword.Location = new Point(204, 282);
            txtConPassword.Name = "txtConPassword";
            txtConPassword.PlaceholderText = "Confirm Password";
            txtConPassword.Size = new Size(250, 27);
            txtConPassword.TabIndex = 16;
            txtConPassword.UseSystemPasswordChar = true;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.Location = new Point(201, 420);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(171, 20);
            loginLink.TabIndex = 18;
            loginLink.TabStop = true;
            loginLink.Text = "Already have an account";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(575, 467);
            ControlBox = false;
            Controls.Add(loginLink);
            Controls.Add(label5);
            Controls.Add(txtConPassword);
            Controls.Add(label4);
            Controls.Add(regBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button regBtn;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private Label label5;
        private TextBox txtConPassword;
        private LinkLabel loginLink;
    }
}