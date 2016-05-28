namespace GeographicalHandbook
{
    partial class Authorization
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
            this.controlPage = new System.Windows.Forms.TabControl();
            this.authPage = new System.Windows.Forms.TabPage();
            this.errorAuth = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.regPage = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.passReg2 = new System.Windows.Forms.TextBox();
            this.passReg = new System.Windows.Forms.TextBox();
            this.surnameReg = new System.Windows.Forms.TextBox();
            this.nameReg = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.Label();
            this.regPassword2 = new System.Windows.Forms.Label();
            this.logReg = new System.Windows.Forms.TextBox();
            this.regSurname = new System.Windows.Forms.Label();
            this.regName = new System.Windows.Forms.Label();
            this.regLogin = new System.Windows.Forms.Label();
            this.controlPage.SuspendLayout();
            this.authPage.SuspendLayout();
            this.regPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPage
            // 
            this.controlPage.Controls.Add(this.authPage);
            this.controlPage.Controls.Add(this.regPage);
            this.controlPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.controlPage.Location = new System.Drawing.Point(1, 2);
            this.controlPage.Name = "controlPage";
            this.controlPage.SelectedIndex = 0;
            this.controlPage.Size = new System.Drawing.Size(562, 442);
            this.controlPage.TabIndex = 0;
            // 
            // authPage
            // 
            this.authPage.Controls.Add(this.errorAuth);
            this.authPage.Controls.Add(this.enterBtn);
            this.authPage.Controls.Add(this.password);
            this.authPage.Controls.Add(this.login);
            this.authPage.Controls.Add(this.passLabel);
            this.authPage.Controls.Add(this.loginLabel);
            this.authPage.Location = new System.Drawing.Point(4, 22);
            this.authPage.Name = "authPage";
            this.authPage.Padding = new System.Windows.Forms.Padding(3);
            this.authPage.Size = new System.Drawing.Size(554, 416);
            this.authPage.TabIndex = 0;
            this.authPage.Text = "Authorization";
            this.authPage.UseVisualStyleBackColor = true;
            // 
            // errorAuth
            // 
            this.errorAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorAuth.ForeColor = System.Drawing.Color.Red;
            this.errorAuth.Location = new System.Drawing.Point(1, 271);
            this.errorAuth.Name = "errorAuth";
            this.errorAuth.Size = new System.Drawing.Size(553, 39);
            this.errorAuth.TabIndex = 5;
            this.errorAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.White;
            this.enterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.Location = new System.Drawing.Point(160, 321);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(232, 47);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "Sign in";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(160, 213);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(231, 38);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(160, 82);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(233, 38);
            this.login.TabIndex = 2;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passLabel
            // 
            this.passLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(1, 158);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(551, 40);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(0, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(554, 40);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regPage
            // 
            this.regPage.Controls.Add(this.errorLabel);
            this.regPage.Controls.Add(this.regButton);
            this.regPage.Controls.Add(this.passReg2);
            this.regPage.Controls.Add(this.passReg);
            this.regPage.Controls.Add(this.surnameReg);
            this.regPage.Controls.Add(this.nameReg);
            this.regPage.Controls.Add(this.regPassword);
            this.regPage.Controls.Add(this.regPassword2);
            this.regPage.Controls.Add(this.logReg);
            this.regPage.Controls.Add(this.regSurname);
            this.regPage.Controls.Add(this.regName);
            this.regPage.Controls.Add(this.regLogin);
            this.regPage.Location = new System.Drawing.Point(4, 22);
            this.regPage.Name = "regPage";
            this.regPage.Padding = new System.Windows.Forms.Padding(3);
            this.regPage.Size = new System.Drawing.Size(554, 416);
            this.regPage.TabIndex = 1;
            this.regPage.Text = "Registration";
            this.regPage.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(202, 203);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 12;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.White;
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(143, 330);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(248, 48);
            this.regButton.TabIndex = 11;
            this.regButton.Text = "Sign up";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // passReg2
            // 
            this.passReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passReg2.Location = new System.Drawing.Point(197, 146);
            this.passReg2.Name = "passReg2";
            this.passReg2.PasswordChar = '*';
            this.passReg2.Size = new System.Drawing.Size(150, 29);
            this.passReg2.TabIndex = 10;
            // 
            // passReg
            // 
            this.passReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passReg.Location = new System.Drawing.Point(198, 58);
            this.passReg.Name = "passReg";
            this.passReg.PasswordChar = '*';
            this.passReg.Size = new System.Drawing.Size(149, 29);
            this.passReg.TabIndex = 9;
            // 
            // surnameReg
            // 
            this.surnameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameReg.Location = new System.Drawing.Point(16, 236);
            this.surnameReg.Name = "surnameReg";
            this.surnameReg.Size = new System.Drawing.Size(151, 29);
            this.surnameReg.TabIndex = 8;
            // 
            // nameReg
            // 
            this.nameReg.BackColor = System.Drawing.Color.White;
            this.nameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameReg.Location = new System.Drawing.Point(15, 146);
            this.nameReg.Name = "nameReg";
            this.nameReg.Size = new System.Drawing.Size(151, 29);
            this.nameReg.TabIndex = 7;
            // 
            // regPassword
            // 
            this.regPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassword.Location = new System.Drawing.Point(198, 20);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(150, 35);
            this.regPassword.TabIndex = 6;
            this.regPassword.Text = "Password:";
            this.regPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regPassword2
            // 
            this.regPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassword2.Location = new System.Drawing.Point(197, 108);
            this.regPassword2.Name = "regPassword2";
            this.regPassword2.Size = new System.Drawing.Size(150, 35);
            this.regPassword2.TabIndex = 5;
            this.regPassword2.Text = "Confirm p-rd:";
            this.regPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logReg
            // 
            this.logReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logReg.Location = new System.Drawing.Point(16, 58);
            this.logReg.Name = "logReg";
            this.logReg.Size = new System.Drawing.Size(149, 29);
            this.logReg.TabIndex = 4;
            // 
            // regSurname
            // 
            this.regSurname.BackColor = System.Drawing.Color.White;
            this.regSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regSurname.Location = new System.Drawing.Point(16, 198);
            this.regSurname.Name = "regSurname";
            this.regSurname.Size = new System.Drawing.Size(150, 35);
            this.regSurname.TabIndex = 3;
            this.regSurname.Text = "Surname";
            this.regSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regName
            // 
            this.regName.BackColor = System.Drawing.Color.White;
            this.regName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regName.Location = new System.Drawing.Point(16, 108);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(150, 35);
            this.regName.TabIndex = 2;
            this.regName.Text = "Name";
            this.regName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regLogin
            // 
            this.regLogin.BackColor = System.Drawing.Color.White;
            this.regLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogin.Location = new System.Drawing.Point(16, 20);
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(150, 35);
            this.regLogin.TabIndex = 0;
            this.regLogin.Text = "Login:";
            this.regLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 445);
            this.Controls.Add(this.controlPage);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.controlPage.ResumeLayout(false);
            this.authPage.ResumeLayout(false);
            this.authPage.PerformLayout();
            this.regPage.ResumeLayout(false);
            this.regPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl controlPage;
        private System.Windows.Forms.TabPage authPage;
        private System.Windows.Forms.TabPage regPage;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label regLogin;
        private System.Windows.Forms.Label regSurname;
        private System.Windows.Forms.Label regName;
        private System.Windows.Forms.Label regPassword2;
        private System.Windows.Forms.TextBox logReg;
        private System.Windows.Forms.TextBox nameReg;
        private System.Windows.Forms.Label regPassword;
        private System.Windows.Forms.TextBox passReg;
        private System.Windows.Forms.TextBox surnameReg;
        private System.Windows.Forms.TextBox passReg2;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorAuth;
    }
}