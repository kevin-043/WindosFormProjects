using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class SimpleCalculatorForm : Form
    {

        Calculator calculator = new Calculator();

        string value = "";
        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            value += "1";
            valueTextBox.Text = value;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            value += "2";
            valueTextBox.Text = value;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            value += "3";
            valueTextBox.Text = value;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            value += "4";
            valueTextBox.Text = value;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            value += "5";
            valueTextBox.Text = value;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            value += "6";
            valueTextBox.Text = value;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            value += "7";
            valueTextBox.Text = value;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            value += "8";
            valueTextBox.Text = value;

        }


        private void nineButton_Click(object sender, EventArgs e)
        {
            value += "9";
            valueTextBox.Text = value;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            value += "0";
            valueTextBox.Text = value;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            valueTextBox.Text = ".";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            value += " + ";
            valueTextBox.Text = value;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            value += " - ";
            valueTextBox.Text = value;
        }

        private void multiplayButton_Click(object sender, EventArgs e)
        {
            value += " * ";
            valueTextBox.Text = value;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            value += " / ";
            valueTextBox.Text = value;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int indexFirstSpace, indexOp, indexVal2;
            decimal val1, val2, total;
            char op;
            
            indexFirstSpace =  value.IndexOf(" ");
            indexOp = indexFirstSpace + 1;
            
            indexVal2 = indexOp + 1;

            val1 = Convert.ToDecimal(value.Substring(0, indexFirstSpace));
            op = value[indexOp];
            val2 = Convert.ToDecimal(value.Substring(indexVal2));

            Calculator cal = new Calculator(val1,val2,op);

            total = cal.SwitchCase();
            
            value += " = " + Convert.ToString(total);
            valueTextBox.Text = value;
            WriteFile();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            value = "";
            valueTextBox.Text = value;
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

        public void WriteFile()
        {
            string path = "Calculator.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {   
                        DateTime dateTime = DateTime.Now;
                        
                        sw.WriteLine($"{value}");

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
            string path = "Calculator.txt";
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

        
    }
}
