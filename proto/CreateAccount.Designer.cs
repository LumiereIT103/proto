namespace proto
{
    partial class CreateAccountForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            cboGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtCPassword = new TextBox();
            btnCreateAccount = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 77);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 107);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 138);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 172);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 299);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 7;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 265);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 234);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 5;
            label7.Text = "UserName";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 204);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 4;
            label8.Text = "Email ";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(304, 74);
            txtFName.MaxLength = 30;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(231, 23);
            txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(304, 104);
            txtLName.MaxLength = 30;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(231, 23);
            txtLName.TabIndex = 1;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(304, 138);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(231, 23);
            cboGender.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(304, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 201);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(304, 230);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(304, 262);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtCPassword
            // 
            txtCPassword.Location = new Point(304, 291);
            txtCPassword.MaxLength = 50;
            txtCPassword.Name = "txtCPassword";
            txtCPassword.Size = new Size(231, 23);
            txtCPassword.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(409, 338);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(146, 35);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(218, 338);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(146, 35);
            btnBackToLogin.TabIndex = 9;
            btnBackToLogin.Text = "Back To Login";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtCPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboGender);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "CreateAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create An Account";
            Load += CreateAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFName;
        private TextBox txtLName;
        private ComboBox cboGender;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtCPassword;
        private Button btnCreateAccount;
        private Button btnBackToLogin;
    }
}