using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class IP_v4ValidatorForm : Form
    {
        private DateTime startTime;
        public IP_v4ValidatorForm()
        {
            InitializeComponent();
        }

        private void ValidateIPbutton_Click(object sender, EventArgs e)
        {
            string regexPattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            Regex regex = new Regex(regexPattern);
            string path = "ip4_Validator.bin";
            string ip = IPTextBox.Text;
            if (regex.IsMatch(ip))
            {
                try
                {
                    MessageBox.Show(IPTextBox.Text + "\n The IP is correct");
                    using (FileStream fileStream = new FileStream(path, FileMode.Append))
                    {
                        using (BinaryWriter writer = new BinaryWriter(fileStream))
                        {
                            writer.Write(ip + DateTime.Now.ToLongDateString());
                        }
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("File not fond", "Error") ;
                }
            }
            else
            {
                MessageBox.Show(IPTextBox.Text + "\n The IP must have 4 bytes \n Integer number between 0 to 255 \n Separated by a dot (255.255.255.255)", "Error  - kevin");

            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            IPTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to quit this application ?", "Exit ?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DateTime stopTime = DateTime.Now;
                TimeSpan timeSpent = stopTime - startTime;
                MessageBox.Show($"Time spent on the form: {timeSpent.TotalSeconds} seconds \n Start time : {startTime} \n End Time : {stopTime}", "Time Spent");

                this.Close();
            }
        }

        private void TodayLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void IP_v4ValidatorForm_Load(object sender, EventArgs e)
        {
            TodayLabel.Text = "Today : " + DateTime.Now;
            startTime = DateTime.Now;
        }
    }
}
