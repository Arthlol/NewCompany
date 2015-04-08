namespace NewCompany
{
    partial class Form1
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterSessionDataGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.AnalyseButton = new System.Windows.Forms.Button();
            this.EnterSessionDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.LightGreen;
            this.NewGameButton.Location = new System.Drawing.Point(300, 450);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(300, 50);
            this.NewGameButton.TabIndex = 5;
            this.NewGameButton.Text = "Начать работу";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MistyRose;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(300, 600);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(300, 50);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Завершить работу";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterSessionDataGroupBox
            // 
            this.EnterSessionDataGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnterSessionDataGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnterSessionDataGroupBox.Controls.Add(this.NameTextBox);
            this.EnterSessionDataGroupBox.Controls.Add(this.NameLabel);
            this.EnterSessionDataGroupBox.Controls.Add(this.GroupTextBox);
            this.EnterSessionDataGroupBox.Controls.Add(this.GroupLabel);
            this.EnterSessionDataGroupBox.Controls.Add(this.SurnameTextBox);
            this.EnterSessionDataGroupBox.Controls.Add(this.SurnameLabel);
            this.EnterSessionDataGroupBox.Location = new System.Drawing.Point(200, 150);
            this.EnterSessionDataGroupBox.Name = "EnterSessionDataGroupBox";
            this.EnterSessionDataGroupBox.Size = new System.Drawing.Size(500, 250);
            this.EnterSessionDataGroupBox.TabIndex = 7;
            this.EnterSessionDataGroupBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(150, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(300, 27);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(50, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 21);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя";
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(150, 150);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(300, 27);
            this.GroupTextBox.TabIndex = 5;
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(50, 150);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(67, 21);
            this.GroupLabel.TabIndex = 4;
            this.GroupLabel.Text = "Группа";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(150, 50);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(300, 27);
            this.SurnameTextBox.TabIndex = 1;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(50, 50);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(85, 21);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(135, 66);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WelcomeLabel.Size = new System.Drawing.Size(656, 44);
            this.WelcomeLabel.TabIndex = 8;
            this.WelcomeLabel.Text = "Добро пожаловать в тренинговую систему <Внештатная ситуация>\r\nВведите свои данные" +
    ":";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalyseButton
            // 
            this.AnalyseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AnalyseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AnalyseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyseButton.Location = new System.Drawing.Point(0, 0);
            this.AnalyseButton.Name = "AnalyseButton";
            this.AnalyseButton.Size = new System.Drawing.Size(101, 48);
            this.AnalyseButton.TabIndex = 9;
            this.AnalyseButton.Text = "Оценить";
            this.AnalyseButton.UseVisualStyleBackColor = false;
            this.AnalyseButton.Click += new System.EventHandler(this.AnalyseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.ControlBox = false;
            this.Controls.Add(this.AnalyseButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.EnterSessionDataGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренинговая система";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnterSessionDataGroupBox.ResumeLayout(false);
            this.EnterSessionDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        public System.Windows.Forms.GroupBox EnterSessionDataGroupBox;
        private System.Windows.Forms.Button AnalyseButton;
    }
}

