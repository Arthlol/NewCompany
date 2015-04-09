namespace NewCompany
{
    partial class Оценка
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.AddSituation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(14, 36);
            this.comboBox.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(500, 29);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Студент";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(3, 10);
            this.AnswerLabel.MaximumSize = new System.Drawing.Size(700, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(110, 21);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.Text = "AnswerLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ScoreTextBox);
            this.groupBox1.Location = new System.Drawing.Point(50, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 537);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(635, 498);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 28);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.AnswerLabel);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 450);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Оценить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(446, 499);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(27, 27);
            this.ScoreTextBox.TabIndex = 5;
            this.ScoreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // AddSituation
            // 
            this.AddSituation.FlatAppearance.BorderSize = 0;
            this.AddSituation.Location = new System.Drawing.Point(835, -1);
            this.AddSituation.Name = "AddSituation";
            this.AddSituation.Size = new System.Drawing.Size(50, 50);
            this.AddSituation.TabIndex = 6;
            this.AddSituation.Text = "+";
            this.AddSituation.UseCompatibleTextRendering = true;
            this.AddSituation.UseVisualStyleBackColor = true;
            this.AddSituation.Click += new System.EventHandler(this.AddSituation_Click);
            // 
            // Оценка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.ControlBox = false;
            this.Controls.Add(this.AddSituation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Оценка";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyseForm";
            this.Load += new System.EventHandler(this.Оценка_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button AddSituation;
    }
}