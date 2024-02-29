using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal class MoneyExchangeClass
    {

		private double money;
        

        MoneyExchangeForm mx = new MoneyExchangeForm();

        public MoneyExchangeClass()
        {
        }

        public MoneyExchangeClass(double money)
        {
            this.money = money;
        }

        public double MoneyGetSet
		{
			get { return money; }
			set { money = value; }
		}

        
        public double CADToCAD(double money)
        {
            // 1 = 1    25-03-2023
            return money;
        }

        public double CADToUSD(double money)
        {
            // 1 = 0.73     25-03-2023
            return money * 0.73;
        }

        public double CADToEUR(double money)
        {
            // 1 = 0.68     25-03-2023
            return money * 0.68;
        }

        public double CADToGBP(double money)
        {
            // 1 = 0.59     25-03-2023
            return money * 0.59;
        }

        public double CADToIND(double money)
        {
            // 1 = 59.89    25-03-2023
            return money * 59.89;
        }

        public double USDToCAD(double money)
        {
            // 1 = 1.37    25-03-2023
            return money * 1.37;
        }

        public double USDToUSD(double money)
        {
            // 1 = 1    25-03-2023
            return money;
        }

        public double USDToEUR(double money)
        {
            // 1 = 0.93    25-03-2023
            return money * 0.93;
        }

        public double USDToGBP(double money)
        {
            // 1 = 0.82    25-03-2023
            return money * 0.82;
        }

        public double USDToIND(double money)
        {
            // 1 = 82.33    25-03-2023
            return money * 82.33;
        }

        public double EURToCAD(double money)
        {
            // 1 = 1.48    25-03-2023
            return money * 1.48;
        }

        public double EURToUSD(double money)
        {
            // 1 = 1.08    25-03-2023
            return money * 1.08;
        }

        public double EURToEUR(double money)
        {
            // 1 = 1    25-03-2023
            return money;
        }

        public double EURToGBP(double money)
        {
            // 1 = 0.88    25-03-2023
            return money * 0.88;
        }

        public double EURToIND(double money)
        {
            // 1 = 88.58    25-03-2023
            return money * 88.58;
        }

        public double GBPToCAD(double money)
        {
            // 1 = 1.68    25-03-2023
            return money * 1.68;
        }

        public double GBPToUSD(double money)
        {
            // 1 = 1.22   25-03-2023
            return money * 1.22;
        }

        public double GBPToEUR(double money)
        {
            // 1 = 1.14   25-03-2023
            return money * 1.14;
        }

        public double GBPToGBP(double money)
        {
            // 1 = 1    25-03-2023
            return money;
        }

        public double GBPToIND(double money)
        {
            // 1 = 100.69    25-03-2023
            return money * 100.69;
        }

        public double INDToCAD(double money)
        {
            // 1 = 0.017    25-03-2023
            return money * 0.017;
        }

        public double INDToUSD(double money)
        {
            // 1 = 0.012    25-03-2023
            return money * 0.012;
        }

        public double INDToEUR(double money)
        {
            // 1 = 0.011    25-03-2023
            return money * 0.011;
        }

        public double INDToGBP(double money)
        {
            // 1 = 0.0099    25-03-2023
            return money * 0.0099;
        }

        public double INDToIND(double money)
        {
            // 1 = 1    25-03-2023
            return money;
        }

        public void Write(double fromVal, double toVal, string from, string to) 
        {
            DateTime datetimenow = DateTime.Now;
            string path = "MoneyConversions.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                       
                        sw.WriteLine($"{fromVal} {from} = {toVal} {to},  {datetimenow}");
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
            string path = "MoneyConversions.txt";
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
