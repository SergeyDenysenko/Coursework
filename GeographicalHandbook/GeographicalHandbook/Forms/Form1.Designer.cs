namespace GeographicalHandbook
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Control = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countUrbanPopulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countUrbanPopulationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showContinentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchClose = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urbanPanel = new System.Windows.Forms.Panel();
            this.countResult = new System.Windows.Forms.Label();
            this.urbanClose = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.countUrban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridArea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridLength1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeTableButton = new System.Windows.Forms.Button();
            this.backTableButton = new System.Windows.Forms.Button();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.urbanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Control,
            this.functionsToolStripMenuItem,
            this.exercisesToolStripMenuItem,
            this.signInToolStripMenuItem,
            this.cabinetToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Control
            // 
            this.Control.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(59, 20);
            this.Control.Text = "Control";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countUrbanPopulationToolStripMenuItem,
            this.countUrbanPopulationToolStripMenuItem1,
            this.showContinentsToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // countUrbanPopulationToolStripMenuItem
            // 
            this.countUrbanPopulationToolStripMenuItem.Name = "countUrbanPopulationToolStripMenuItem";
            this.countUrbanPopulationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.countUrbanPopulationToolStripMenuItem.Text = "Search";
            this.countUrbanPopulationToolStripMenuItem.Click += new System.EventHandler(this.countUrbanPopulationToolStripMenuItem_Click);
            // 
            // countUrbanPopulationToolStripMenuItem1
            // 
            this.countUrbanPopulationToolStripMenuItem1.Name = "countUrbanPopulationToolStripMenuItem1";
            this.countUrbanPopulationToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.countUrbanPopulationToolStripMenuItem1.Text = "Count urban population";
            this.countUrbanPopulationToolStripMenuItem1.Click += new System.EventHandler(this.countUrbanPopulationToolStripMenuItem1_Click);
            // 
            // showContinentsToolStripMenuItem
            // 
            this.showContinentsToolStripMenuItem.Name = "showContinentsToolStripMenuItem";
            this.showContinentsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.showContinentsToolStripMenuItem.Text = "Show continents";
            this.showContinentsToolStripMenuItem.Click += new System.EventHandler(this.showContinentsToolStripMenuItem_Click);
            // 
            // exercisesToolStripMenuItem
            // 
            this.exercisesToolStripMenuItem.Name = "exercisesToolStripMenuItem";
            this.exercisesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.exercisesToolStripMenuItem.Text = "Exercises";
            this.exercisesToolStripMenuItem.Click += new System.EventHandler(this.exercisesToolStripMenuItem_Click);
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.signInToolStripMenuItem.Text = "Sign up / Sign in";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // cabinetToolStripMenuItem
            // 
            this.cabinetToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cabinetToolStripMenuItem.Name = "cabinetToolStripMenuItem";
            this.cabinetToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cabinetToolStripMenuItem.Text = "Cabinet";
            this.cabinetToolStripMenuItem.Visible = false;
            this.cabinetToolStripMenuItem.Click += new System.EventHandler(this.cabinetToolStripMenuItem_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchPanel.Controls.Add(this.searchClose);
            this.searchPanel.Controls.Add(this.searchBtn);
            this.searchPanel.Controls.Add(this.searchQuery);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Location = new System.Drawing.Point(10, 202);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(220, 168);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Visible = false;
            // 
            // searchClose
            // 
            this.searchClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchClose.Location = new System.Drawing.Point(200, 0);
            this.searchClose.Margin = new System.Windows.Forms.Padding(0);
            this.searchClose.Name = "searchClose";
            this.searchClose.Size = new System.Drawing.Size(20, 20);
            this.searchClose.TabIndex = 3;
            this.searchClose.Text = "X";
            this.searchClose.UseVisualStyleBackColor = false;
            this.searchClose.Click += new System.EventHandler(this.searchClose_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(48, 92);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(129, 31);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search!";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchQuery
            // 
            this.searchQuery.BackColor = System.Drawing.Color.White;
            this.searchQuery.Location = new System.Drawing.Point(26, 44);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(163, 20);
            this.searchQuery.TabIndex = 1;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchLbl.Location = new System.Drawing.Point(44, 3);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(133, 17);
            this.searchLbl.TabIndex = 0;
            this.searchLbl.Text = "Enter search query:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.capital,
            this.pop,
            this.area});
            this.dataGrid.Location = new System.Drawing.Point(274, 205);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(451, 139);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.Visible = false;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // capital
            // 
            this.capital.HeaderText = "Capital";
            this.capital.Name = "capital";
            this.capital.ReadOnly = true;
            // 
            // pop
            // 
            this.pop.HeaderText = "Population";
            this.pop.Name = "pop";
            this.pop.ReadOnly = true;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // urbanPanel
            // 
            this.urbanPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.urbanPanel.Controls.Add(this.countResult);
            this.urbanPanel.Controls.Add(this.urbanClose);
            this.urbanPanel.Controls.Add(this.countBtn);
            this.urbanPanel.Controls.Add(this.countUrban);
            this.urbanPanel.Controls.Add(this.label2);
            this.urbanPanel.Location = new System.Drawing.Point(10, 30);
            this.urbanPanel.Name = "urbanPanel";
            this.urbanPanel.Size = new System.Drawing.Size(220, 166);
            this.urbanPanel.TabIndex = 4;
            this.urbanPanel.Visible = false;
            // 
            // countResult
            // 
            this.countResult.AutoSize = true;
            this.countResult.Location = new System.Drawing.Point(15, 133);
            this.countResult.Name = "countResult";
            this.countResult.Size = new System.Drawing.Size(0, 13);
            this.countResult.TabIndex = 4;
            // 
            // urbanClose
            // 
            this.urbanClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.urbanClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urbanClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urbanClose.Location = new System.Drawing.Point(201, 0);
            this.urbanClose.Margin = new System.Windows.Forms.Padding(0);
            this.urbanClose.Name = "urbanClose";
            this.urbanClose.Size = new System.Drawing.Size(20, 20);
            this.urbanClose.TabIndex = 3;
            this.urbanClose.Text = "X";
            this.urbanClose.UseVisualStyleBackColor = false;
            this.urbanClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // countBtn
            // 
            this.countBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.countBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countBtn.Location = new System.Drawing.Point(45, 92);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(132, 31);
            this.countBtn.TabIndex = 2;
            this.countBtn.Text = "Count!";
            this.countBtn.UseVisualStyleBackColor = false;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // countUrban
            // 
            this.countUrban.Location = new System.Drawing.Point(26, 54);
            this.countUrban.Name = "countUrban";
            this.countUrban.Size = new System.Drawing.Size(163, 20);
            this.countUrban.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(25, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the name of region \r\nto count urban population";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name1,
            this.dataGridPop1,
            this.dataGridArea1,
            this.dataGridLength1});
            this.dataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(274, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 169);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name1
            // 
            this.name1.HeaderText = "Name";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            // 
            // dataGridPop1
            // 
            this.dataGridPop1.HeaderText = "Population";
            this.dataGridPop1.Name = "dataGridPop1";
            this.dataGridPop1.ReadOnly = true;
            // 
            // dataGridArea1
            // 
            this.dataGridArea1.HeaderText = "Area";
            this.dataGridArea1.Name = "dataGridArea1";
            this.dataGridArea1.ReadOnly = true;
            // 
            // dataGridLength1
            // 
            this.dataGridLength1.HeaderText = "Number of countries";
            this.dataGridLength1.Name = "dataGridLength1";
            this.dataGridLength1.ReadOnly = true;
            // 
            // closeTableButton
            // 
            this.closeTableButton.BackColor = System.Drawing.Color.White;
            this.closeTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeTableButton.Location = new System.Drawing.Point(718, 32);
            this.closeTableButton.Name = "closeTableButton";
            this.closeTableButton.Size = new System.Drawing.Size(36, 34);
            this.closeTableButton.TabIndex = 6;
            this.closeTableButton.Text = "X";
            this.closeTableButton.UseVisualStyleBackColor = false;
            this.closeTableButton.Visible = false;
            this.closeTableButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backTableButton
            // 
            this.backTableButton.BackColor = System.Drawing.Color.White;
            this.backTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backTableButton.Location = new System.Drawing.Point(718, 72);
            this.backTableButton.Name = "backTableButton";
            this.backTableButton.Size = new System.Drawing.Size(36, 32);
            this.backTableButton.TabIndex = 7;
            this.backTableButton.Text = "<";
            this.backTableButton.UseVisualStyleBackColor = false;
            this.backTableButton.Visible = false;
            this.backTableButton.Click += new System.EventHandler(this.backTableButton_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Visible = false;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.backTableButton);
            this.Controls.Add(this.closeTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.urbanPanel);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geographical Handbook";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.urbanPanel.ResumeLayout(false);
            this.urbanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Control;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel urbanPanel;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.TextBox countUrban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countUrbanPopulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countUrbanPopulationToolStripMenuItem1;
        private System.Windows.Forms.Button searchClose;
        private System.Windows.Forms.Button urbanClose;
        private System.Windows.Forms.ToolStripMenuItem showContinentsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn pop;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridPop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridArea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridLength1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exercisesToolStripMenuItem;
        private System.Windows.Forms.Label countResult;
        public System.Windows.Forms.ToolStripMenuItem cabinetToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.Button closeTableButton;
        private System.Windows.Forms.Button backTableButton;
        public System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        
    }
}

