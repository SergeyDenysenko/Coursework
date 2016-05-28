namespace GeographicalHandbook
{
    partial class Cabinet
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
            this.personalData = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.changer = new System.Windows.Forms.Button();
            this.changedPass = new System.Windows.Forms.TextBox();
            this.changeData = new System.Windows.Forms.Button();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.curSurname = new System.Windows.Forms.Label();
            this.curName = new System.Windows.Forms.Label();
            this.curPass = new System.Windows.Forms.Label();
            this.curLogin = new System.Windows.Forms.Label();
            this.marks = new System.Windows.Forms.Label();
            this.marksDataGrid = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // personalData
            // 
            this.personalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalData.Location = new System.Drawing.Point(2, 3);
            this.personalData.Name = "personalData";
            this.personalData.Size = new System.Drawing.Size(411, 46);
            this.personalData.TabIndex = 0;
            this.personalData.Text = "Hello";
            this.personalData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(423, 4);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(158, 44);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Profile";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.changer);
            this.panel1.Controls.Add(this.changedPass);
            this.panel1.Controls.Add(this.changeData);
            this.panel1.Controls.Add(this.surnameLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.passLbl);
            this.panel1.Controls.Add(this.loginLbl);
            this.panel1.Controls.Add(this.curSurname);
            this.panel1.Controls.Add(this.curName);
            this.panel1.Controls.Add(this.curPass);
            this.panel1.Controls.Add(this.curLogin);
            this.panel1.Location = new System.Drawing.Point(108, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 204);
            this.panel1.TabIndex = 10;
            this.panel1.TabStop = true;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(281, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(353, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // changer
            // 
            this.changer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changer.Location = new System.Drawing.Point(194, 160);
            this.changer.Name = "changer";
            this.changer.Size = new System.Drawing.Size(130, 28);
            this.changer.TabIndex = 10;
            this.changer.Text = "Change";
            this.changer.UseVisualStyleBackColor = false;
            this.changer.Visible = false;
            this.changer.Click += new System.EventHandler(this.changer_Click);
            // 
            // changedPass
            // 
            this.changedPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changedPass.Location = new System.Drawing.Point(12, 162);
            this.changedPass.Name = "changedPass";
            this.changedPass.Size = new System.Drawing.Size(145, 24);
            this.changedPass.TabIndex = 9;
            this.changedPass.Visible = false;
            // 
            // changeData
            // 
            this.changeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeData.Location = new System.Drawing.Point(12, 160);
            this.changeData.Name = "changeData";
            this.changeData.Size = new System.Drawing.Size(161, 29);
            this.changeData.TabIndex = 8;
            this.changeData.Text = "Change password";
            this.changeData.UseVisualStyleBackColor = false;
            this.changeData.Click += new System.EventHandler(this.changeData_Click);
            // 
            // surnameLbl
            // 
            this.surnameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.Location = new System.Drawing.Point(103, 112);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(157, 20);
            this.surnameLbl.TabIndex = 7;
            this.surnameLbl.Text = "label4";
            this.surnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLbl
            // 
            this.nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(103, 80);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(157, 20);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "label3";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passLbl
            // 
            this.passLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLbl.Location = new System.Drawing.Point(103, 50);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(157, 20);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "label2";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginLbl
            // 
            this.loginLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.Location = new System.Drawing.Point(103, 22);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(157, 20);
            this.loginLbl.TabIndex = 4;
            this.loginLbl.Text = "label1";
            this.loginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curSurname
            // 
            this.curSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curSurname.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.curSurname.Location = new System.Drawing.Point(12, 112);
            this.curSurname.Name = "curSurname";
            this.curSurname.Size = new System.Drawing.Size(85, 20);
            this.curSurname.TabIndex = 3;
            this.curSurname.Text = "Surname:";
            this.curSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curName
            // 
            this.curName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.curName.Location = new System.Drawing.Point(12, 80);
            this.curName.Name = "curName";
            this.curName.Size = new System.Drawing.Size(85, 20);
            this.curName.TabIndex = 2;
            this.curName.Text = "Name:";
            this.curName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curPass
            // 
            this.curPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curPass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.curPass.Location = new System.Drawing.Point(12, 50);
            this.curPass.Name = "curPass";
            this.curPass.Size = new System.Drawing.Size(85, 20);
            this.curPass.TabIndex = 1;
            this.curPass.Text = "Password:";
            this.curPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curLogin
            // 
            this.curLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.curLogin.Location = new System.Drawing.Point(12, 22);
            this.curLogin.Name = "curLogin";
            this.curLogin.Size = new System.Drawing.Size(85, 20);
            this.curLogin.TabIndex = 0;
            this.curLogin.Text = "Login:";
            this.curLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.Location = new System.Drawing.Point(31, 86);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(35, 13);
            this.marks.TabIndex = 3;
            this.marks.Text = "label1";
            // 
            // marksDataGrid
            // 
            this.marksDataGrid.AllowDrop = true;
            this.marksDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.marksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.mark,
            this.percentage});
            this.marksDataGrid.Location = new System.Drawing.Point(12, 102);
            this.marksDataGrid.Name = "marksDataGrid";
            this.marksDataGrid.Size = new System.Drawing.Size(346, 210);
            this.marksDataGrid.TabIndex = 0;
            this.marksDataGrid.TabStop = false;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // mark
            // 
            this.mark.HeaderText = "Mark";
            this.mark.Name = "mark";
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Percentage";
            this.percentage.Name = "percentage";
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.marksDataGrid);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.personalData);
            this.Name = "Cabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabinet";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personalData;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeData;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label curSurname;
        private System.Windows.Forms.Label curName;
        private System.Windows.Forms.Label curPass;
        private System.Windows.Forms.Label curLogin;
        private System.Windows.Forms.TextBox changedPass;
        private System.Windows.Forms.Button changer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label marks;
        private System.Windows.Forms.DataGridView marksDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
    }
}