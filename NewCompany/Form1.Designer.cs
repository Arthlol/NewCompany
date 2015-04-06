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
            this.NewTurn = new System.Windows.Forms.Button();
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.CoinsLabelValue = new System.Windows.Forms.Label();
            this.WorksForHimSelfLabel = new System.Windows.Forms.Label();
            this.WorksForHimSelfLabelValue = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewTurn
            // 
            this.NewTurn.Location = new System.Drawing.Point(173, 279);
            this.NewTurn.Name = "NewTurn";
            this.NewTurn.Size = new System.Drawing.Size(176, 52);
            this.NewTurn.TabIndex = 0;
            this.NewTurn.Text = "новый ход";
            this.NewTurn.UseVisualStyleBackColor = true;
            this.NewTurn.Click += new System.EventHandler(this.NewTurn_Click);
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.AutoSize = true;
            this.CoinsLabel.Location = new System.Drawing.Point(12, 48);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(50, 13);
            this.CoinsLabel.TabIndex = 1;
            this.CoinsLabel.Text = "Монеты:";
            // 
            // CoinsLabelValue
            // 
            this.CoinsLabelValue.AutoSize = true;
            this.CoinsLabelValue.Location = new System.Drawing.Point(90, 48);
            this.CoinsLabelValue.Name = "CoinsLabelValue";
            this.CoinsLabelValue.Size = new System.Drawing.Size(13, 13);
            this.CoinsLabelValue.TabIndex = 2;
            this.CoinsLabelValue.Text = "_";
            // 
            // WorksForHimSelfLabel
            // 
            this.WorksForHimSelfLabel.AutoSize = true;
            this.WorksForHimSelfLabel.Location = new System.Drawing.Point(15, 95);
            this.WorksForHimSelfLabel.Name = "WorksForHimSelfLabel";
            this.WorksForHimSelfLabel.Size = new System.Drawing.Size(99, 13);
            this.WorksForHimSelfLabel.TabIndex = 3;
            this.WorksForHimSelfLabel.Text = "Работаем на себя";
            // 
            // WorksForHimSelfLabelValue
            // 
            this.WorksForHimSelfLabelValue.AutoSize = true;
            this.WorksForHimSelfLabelValue.Location = new System.Drawing.Point(136, 95);
            this.WorksForHimSelfLabelValue.Name = "WorksForHimSelfLabelValue";
            this.WorksForHimSelfLabelValue.Size = new System.Drawing.Size(13, 13);
            this.WorksForHimSelfLabelValue.TabIndex = 4;
            this.WorksForHimSelfLabelValue.Text = "_";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(173, 233);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(176, 40);
            this.NewGameButton.TabIndex = 5;
            this.NewGameButton.Text = "Новая игра";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 386);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.WorksForHimSelfLabelValue);
            this.Controls.Add(this.WorksForHimSelfLabel);
            this.Controls.Add(this.CoinsLabelValue);
            this.Controls.Add(this.CoinsLabel);
            this.Controls.Add(this.NewTurn);
            this.Name = "Form1";
            this.Text = "типа название";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewTurn;
        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.Label CoinsLabelValue;
        private System.Windows.Forms.Label WorksForHimSelfLabel;
        private System.Windows.Forms.Label WorksForHimSelfLabelValue;
        private System.Windows.Forms.Button NewGameButton;
    }
}

