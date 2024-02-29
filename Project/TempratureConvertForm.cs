using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class TempratureConvertForm : Form
    {

        bool error = false;
        public TempratureConvertForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
                
            string inputVal = textBox1.Text;
            double inputNum;
            double outputVal;
            string message = "";
            string regexPattern = @"^\d+$";
            Regex regex = new Regex(regexPattern);

            if (regex.IsMatch(inputVal))
            {
                    inputNum = Convert.ToDouble(inputVal);

                    if (CtoFRadioButton.Checked)
                    {
                        outputVal = (inputNum * 9 / 5) + 32;
                    }
                    else
                    {
                        outputVal = (inputNum - 32) * 5 / 9;
                    }

                    textBox2.Text = Convert.ToString(outputVal);
                error = false;
                    message = Message();
                if (error == false)
                {
                    WriteFile(message);
                }
                    

            }
            else
            {
                    MessageBox.Show("Invalid input!", "Error");
                    textBox1.Text = "";
                    MessageTextBox.Text ="";
            }
            
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to quit this application ?", "Exit ?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CtoFRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeLabel.Text = "C";
            ReadLabel.Text = "F";
        }

        private void FtoCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeLabel.Text = "F";
            ReadLabel.Text = "C";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"^-?\d*\.?\d*$"))
            {

                MessageBox.Show("Please enter a valid number.", "Invalid Input");
                textBox1.Text = "";
            }
        }

        public void WriteFile(string message)
        {
            string path = "TempConversions.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {   
                        DateTime dateTime = DateTime.Now;
                        if (CtoFRadioButton.Checked)
                        {
                            sw.WriteLine($"{textBox1.Text} C = {textBox2.Text} F, {dateTime}  {message}");
                        }
                        else
                        {
                            sw.WriteLine($"{textBox1.Text} F = {textBox2.Text} C, {dateTime}  {message}");
                        }
                        
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(" file not found.", "File Not Found");
            }
        }

        public void ReadFile()
        {
            string path = "TempConversions.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        MessageBox.Show(sr.ReadToEnd(), path + " - Kevin");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("File not fond");
            }
        }


        public string Message()
        {
            string message = "";
            double cTemp;

            if (CtoFRadioButton.Checked)
            {
                cTemp = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                cTemp= Convert.ToDouble(textBox2.Text);
            }
            
            if (cTemp <= 100 & cTemp > 40)
            {
                message = "Water boils";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.DarkRed;
            }
            else if (cTemp <= 40 & cTemp > 37)
            {
                message = "Hot Bath";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.Red;
            }
            else if (cTemp <= 37 & cTemp > 30)
            {
                message = "Body Temperature";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.Yellow;
            }
            else if (cTemp <= 30 & cTemp > 21)
            {
                MessageTextBox.ForeColor = Color.Yellow;
                MessageTextBox.Text = "Beach Weather";
            }
            else if (cTemp <= 21 & cTemp > 10)
            {
                message = "Room Temperature";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.Green;
            }
            else if (cTemp <= 10 & cTemp > 0)
            {
                message = "Cool Day";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.LightBlue;
            }
            else if (cTemp <= 0 & cTemp > -18)
            {
                message = "Freezing Point of Water";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.Blue;
            }
            else if (cTemp <= -18 & cTemp > -40)
            {
                message = "Very Cold Day";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.Blue;
            }
            else if(cTemp == -40)
            {
                message = "Extremely Cold Day" + "\n(and the same number!)";
                MessageTextBox.Text = message;
                MessageTextBox.ForeColor = Color.Purple;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Invalid input!", "Error");
                error = true;
            }

            return message;
        }

    }
}
