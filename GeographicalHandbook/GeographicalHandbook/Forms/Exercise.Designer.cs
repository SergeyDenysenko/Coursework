namespace GeographicalHandbook
{
    partial class Exercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise));
            this.startBtn = new System.Windows.Forms.Button();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.Label();
            this.skipBtn = new System.Windows.Forms.Button();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.answer = new System.Windows.Forms.Button();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.numOfQuestion = new System.Windows.Forms.TrackBar();
            this.trackBarText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Location = new System.Drawing.Point(278, 231);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(132, 45);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start test!";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.BackColor = System.Drawing.Color.Transparent;
            this.textLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textLabel1.Location = new System.Drawing.Point(203, 31);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(329, 25);
            this.textLabel1.TabIndex = 1;
            this.textLabel1.Text = "Choose the number of questions:\r\n";
            this.textLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio1.Location = new System.Drawing.Point(117, 137);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(65, 24);
            this.radio1.TabIndex = 3;
            this.radio1.Text = "Cap1";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio2.Location = new System.Drawing.Point(117, 160);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(65, 24);
            this.radio2.TabIndex = 4;
            this.radio2.Text = "Cap2";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.skipBtn);
            this.panel1.Controls.Add(this.radio4);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.radio3);
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Controls.Add(this.radio2);
            this.panel1.Controls.Add(this.radio1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(182, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 350);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.resultText);
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 309);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(182, 247);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 34);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(15, 247);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 35);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Play again";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resultText
            // 
            this.resultText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultText.Location = new System.Drawing.Point(3, 78);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(336, 40);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "result_text";
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skipBtn
            // 
            this.skipBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skipBtn.Location = new System.Drawing.Point(22, 283);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(110, 43);
            this.skipBtn.TabIndex = 9;
            this.skipBtn.Text = "Skip";
            this.skipBtn.UseVisualStyleBackColor = false;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio4.Location = new System.Drawing.Point(117, 206);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(65, 24);
            this.radio4.TabIndex = 8;
            this.radio4.TabStop = true;
            this.radio4.Text = "Cap4";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.White;
            this.answer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(216, 283);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(106, 44);
            this.answer.TabIndex = 6;
            this.answer.Text = "Answer";
            this.answer.UseVisualStyleBackColor = false;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio3.Location = new System.Drawing.Point(117, 183);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(65, 24);
            this.radio3.TabIndex = 7;
            this.radio3.TabStop = true;
            this.radio3.Text = "Cap3";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(3, 42);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(342, 66);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "Question....";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfQuestion
            // 
            this.numOfQuestion.AllowDrop = true;
            this.numOfQuestion.BackColor = System.Drawing.Color.White;
            this.numOfQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numOfQuestion.Location = new System.Drawing.Point(229, 76);
            this.numOfQuestion.Maximum = 8;
            this.numOfQuestion.Minimum = 3;
            this.numOfQuestion.Name = "numOfQuestion";
            this.numOfQuestion.Size = new System.Drawing.Size(213, 45);
            this.numOfQuestion.TabIndex = 1;
            this.numOfQuestion.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.numOfQuestion.Value = 3;
            this.numOfQuestion.Scroll += new System.EventHandler(this.numberOfQuestions_Scroll);
            // 
            // trackBarText
            // 
            this.trackBarText.AutoSize = true;
            this.trackBarText.BackColor = System.Drawing.Color.Transparent;
            this.trackBarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackBarText.ForeColor = System.Drawing.Color.White;
            this.trackBarText.Location = new System.Drawing.Point(457, 76);
            this.trackBarText.Name = "trackBarText";
            this.trackBarText.Size = new System.Drawing.Size(36, 39);
            this.trackBarText.TabIndex = 7;
            this.trackBarText.Text = "3";
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(699, 466);
            this.Controls.Add(this.trackBarText);
            this.Controls.Add(this.numOfQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.startBtn);
            this.Name = "Exercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise";
            this.Load += new System.EventHandler(this.Exercise_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOfQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.TrackBar numOfQuestion;
        private System.Windows.Forms.Label trackBarText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}