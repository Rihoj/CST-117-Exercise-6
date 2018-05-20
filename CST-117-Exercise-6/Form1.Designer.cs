namespace CST_117_Exercise_6
{
    partial class snakeEyesForm
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
            this.rollButton = new System.Windows.Forms.Button();
            this.diceOnePanel = new System.Windows.Forms.Panel();
            this.diceTwoPanel = new System.Windows.Forms.Panel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(13, 13);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(100, 100);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // diceOnePanel
            // 
            this.diceOnePanel.Location = new System.Drawing.Point(131, 12);
            this.diceOnePanel.Name = "diceOnePanel";
            this.diceOnePanel.Size = new System.Drawing.Size(100, 100);
            this.diceOnePanel.TabIndex = 1;
            // 
            // diceTwoPanel
            // 
            this.diceTwoPanel.Location = new System.Drawing.Point(256, 13);
            this.diceTwoPanel.Name = "diceTwoPanel";
            this.diceTwoPanel.Size = new System.Drawing.Size(100, 100);
            this.diceTwoPanel.TabIndex = 2;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(12, 161);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(279, 13);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.Text = "Roll dice to see how many rolls it takes to get snake eyes!";
            // 
            // snakeEyesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 334);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.diceTwoPanel);
            this.Controls.Add(this.diceOnePanel);
            this.Controls.Add(this.rollButton);
            this.Name = "snakeEyesForm";
            this.Text = "Snake Eyes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Panel diceOnePanel;
        private System.Windows.Forms.Panel diceTwoPanel;
        private System.Windows.Forms.Label resultsLabel;
    }
}

