namespace Project
{
    partial class TempratureConvertForm
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
            this.CtoFRadioButton = new System.Windows.Forms.RadioButton();
            this.FtoCRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeLabel = new System.Windows.Forms.Label();
            this.ReadLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CtoFRadioButton
            // 
            this.CtoFRadioButton.AutoSize = true;
            this.CtoFRadioButton.Location = new System.Drawing.Point(145, 31);
            this.CtoFRadioButton.Name = "CtoFRadioButton";
            this.CtoFRadioButton.Size = new System.Drawing.Size(91, 20);
            this.CtoFRadioButton.TabIndex = 0;
            this.CtoFRadioButton.TabStop = true;
            this.CtoFRadioButton.Text = "from C to F";
            this.CtoFRadioButton.UseVisualStyleBackColor = true;
            this.CtoFRadioButton.CheckedChanged += new System.EventHandler(this.CtoFRadioButton_CheckedChanged);
            // 
            // FtoCRadioButton
            // 
            this.FtoCRadioButton.AutoSize = true;
            this.FtoCRadioButton.Location = new System.Drawing.Point(145, 78);
            this.FtoCRadioButton.Name = "FtoCRadioButton";
            this.FtoCRadioButton.Size = new System.Drawing.Size(91, 20);
            this.FtoCRadioButton.TabIndex = 1;
            this.FtoCRadioButton.TabStop = true;
            this.FtoCRadioButton.Text = "from F to C";
            this.FtoCRadioButton.UseVisualStyleBackColor = true;
            this.FtoCRadioButton.CheckedChanged += new System.EventHandler(this.FtoCRadioButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // writeLabel
            // 
            this.writeLabel.AutoSize = true;
            this.writeLabel.Location = new System.Drawing.Point(65, 150);
            this.writeLabel.Name = "writeLabel";
            this.writeLabel.Size = new System.Drawing.Size(16, 16);
            this.writeLabel.TabIndex = 5;
            this.writeLabel.Text = "C";
            // 
            // ReadLabel
            // 
            this.ReadLabel.AutoSize = true;
            this.ReadLabel.Location = new System.Drawing.Point(285, 149);
            this.ReadLabel.Name = "ReadLabel";
            this.ReadLabel.Size = new System.Drawing.Size(15, 16);
            this.ReadLabel.TabIndex = 6;
            this.ReadLabel.Text = "F";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(272, 327);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(136, 327);
            this.readFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(100, 28);
            this.readFileButton.TabIndex = 9;
            this.readFileButton.Text = "&Read File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(9, 327);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(100, 28);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "&Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Message:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(9, 208);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.Size = new System.Drawing.Size(363, 112);
            this.MessageTextBox.TabIndex = 13;
            this.MessageTextBox.Text = "";
            // 
            // TempratureConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 380);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.ReadLabel);
            this.Controls.Add(this.writeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FtoCRadioButton);
            this.Controls.Add(this.CtoFRadioButton);
            this.Name = "TempratureConvertForm";
            this.Text = "Temp App - Kevin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CtoFRadioButton;
        private System.Windows.Forms.RadioButton FtoCRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label writeLabel;
        private System.Windows.Forms.Label ReadLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox MessageTextBox;
    }
}