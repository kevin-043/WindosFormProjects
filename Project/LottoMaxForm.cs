using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LottoMaxForm : Form
    {
        public LottoMaxForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            winnningNumbersTextBox.Text = "";
            int[] numArray = new int[8];
            numArray = GenerateNumbers();

            for (int i = 0; i < 8; i++)
            {
                winnningNumbersTextBox.Text += Convert.ToString(numArray[i]) + "\r\n";
            }

            WriteFile(numArray);
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

        public int[] GenerateNumbers() 
        {
            Random random = new Random();
            List<int> numbersList = new List<int>();

            while (numbersList.Count < 8)
            {
                int randomNumber = random.Next(1, 50);
                if (!numbersList.Contains(randomNumber))
                {
                    numbersList.Add(randomNumber);
                }
            }

            int[] numbersArray = numbersList.ToArray();
            return numbersArray;

        }
        
        public void WriteFile(int[] numArray)
        {
            string path = "LottoNbrs.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        string numbers = "";
                        int bonus = numArray[7];
                        for (int i = 0; i < 7; i++)
                        {
                            numbers = numbers + numArray[i] + ", ";
                        }
                        sw.WriteLine($"Max, {DateTime.Now}  {numbers}   Bonus {bonus}");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" not found." + ex, "File Not Found");
            }
        }

        public void ReadFile()
        {
            string path = "LottoNbrs.txt";
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
