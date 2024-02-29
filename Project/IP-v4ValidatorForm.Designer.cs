namespace Project
{
    partial class IP_v4ValidatorForm
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
            this.TodayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ValidateIPbutton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Location = new System.Drawing.Point(103, 18);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(106, 16);
            this.TodayLabel.TabIndex = 0;
            this.TodayLabel.Text = "Today : 30-20-19";
            this.TodayLabel.Click += new System.EventHandler(this.TodayLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter IP address : ";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(124, 95);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(184, 22);
            this.IPTextBox.TabIndex = 2;
            // 
            // ValidateIPbutton
            // 
            this.ValidateIPbutton.Location = new System.Drawing.Point(12, 164);
            this.ValidateIPbutton.Name = "ValidateIPbutton";
            this.ValidateIPbutton.Size = new System.Drawing.Size(93, 39);
            this.ValidateIPbutton.TabIndex = 3;
            this.ValidateIPbutton.Text = "Validate IP";
            this.ValidateIPbutton.UseVisualStyleBackColor = true;
            this.ValidateIPbutton.Click += new System.EventHandler(this.ValidateIPbutton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(116, 164);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(93, 39);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(215, 164);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // IP_v4ValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 219);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ValidateIPbutton);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TodayLabel);
            this.Name = "IP_v4ValidatorForm";
            this.Text = "IP4-Validator";
            this.Load += new System.EventHandler(this.IP_v4ValidatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TodayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button ValidateIPbutton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button exitButton;
    }
}