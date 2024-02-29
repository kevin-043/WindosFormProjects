using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class MoneyExchangeForm : Form
    {
        private DateTime _formLoadTime;

        public MoneyExchangeForm()
        {
            InitializeComponent();
        }

        private void MoneyExchangeForm_Load(object sender, EventArgs e)
        {
            _formLoadTime = DateTime.Now;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you want \n to quit the application \n Money Exchange?", "Exit ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime formClosingTime = DateTime.Now;
                TimeSpan timeSpentOnForm = formClosingTime - _formLoadTime;
                MessageBox.Show($"Time spent on the form: {timeSpentOnForm.TotalSeconds} seconds \n start time : {_formLoadTime} \n Stop time : {formClosingTime}", "Time Spent");
                this.Close();
            }
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            MoneyExchangeClass mx = new MoneyExchangeClass();
            mx.ReadFile();
        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(fromTextBox.Text, @"^-?\d*\.?\d*$"))
            {
                
                MessageBox.Show("Please enter a positive number.", "Invalid Input");
                fromTextBox.Text = "";
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            MoneyExchangeClass mx = new MoneyExchangeClass();

            double input = Convert.ToDouble(fromTextBox.Text);
            string from, to;
            double fromVal, toVal;

            if (fromCADRadioButton.Checked == true && toCADRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.CADToCAD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "CAD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromCADRadioButton.Checked == true && toUSDradioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.CADToUSD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "USD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromCADRadioButton.Checked == true && toEURRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.CADToEUR(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "EUR";
                mx.Write(fromVal, toVal, from, to);
            } 
            else if (fromCADRadioButton.Checked == true && toGBPRadioButton.Checked == true) 
            {
                fromVal = input;
                toVal = mx.CADToGBP(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "GBP";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromCADRadioButton.Checked == true && toINDRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.CADToIND(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "IND";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromUSDRadioButton.Checked == true && toCADRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.USDToCAD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "USD";
                to = "CAD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromUSDRadioButton.Checked == true && toUSDradioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.USDToUSD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "USD";
                to = "USD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromUSDRadioButton.Checked == true && toEURRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.USDToEUR(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "USD";
                to = "EUR";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromUSDRadioButton.Checked == true && toGBPRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.USDToGBP(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "USD";
                to = "GBP";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromUSDRadioButton.Checked == true && toINDRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.USDToIND(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "USD";
                to = "IND";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromEURRadioButton.Checked == true && toCADRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.EURToCAD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "CAD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromEURRadioButton.Checked == true && toUSDradioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.EURToUSD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "USD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromEURRadioButton.Checked == true && toEURRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.EURToEUR(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "EUR";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromEURRadioButton.Checked == true && toGBPRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.EURToGBP(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "GBP";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromEURRadioButton.Checked == true && toINDRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.EURToIND(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "IND";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromGBPRadioButton.Checked == true && toCADRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.GBPToCAD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "CAD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromGBPRadioButton.Checked == true && toUSDradioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.GBPToUSD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "USD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromGBPRadioButton.Checked == true && toEURRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.GBPToEUR(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "EUR";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromGBPRadioButton.Checked == true && toGBPRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.GBPToGBP(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "GBP";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromGBPRadioButton.Checked == true && toINDRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.GBPToIND(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "IND";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromINDRadioButton.Checked == true && toCADRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.INDToCAD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "IND";
                to = "CAD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromINDRadioButton.Checked == true && toUSDradioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.INDToUSD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "IND";
                to = "USD";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromINDRadioButton.Checked == true && toEURRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.INDToCAD(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "IND";
                to = "EUR";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromINDRadioButton.Checked == true && toGBPRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.INDToGBP(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "IND";
                to = "GBP";
                mx.Write(fromVal, toVal, from, to);
            }
            else if (fromINDRadioButton.Checked == true && toINDRadioButton.Checked == true)
            {
                fromVal = input;
                toVal = mx.INDToIND(input);
                toTextBox.Text = Convert.ToString(toVal);
                from = "IND";
                to = "IND";
                mx.Write(fromVal, toVal, from, to);
            }

    
        }

        
    }
}
