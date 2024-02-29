using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void lottoMaxButton_Click(object sender, EventArgs e)
        {
            LottoMaxForm lottoMaxForm = new LottoMaxForm();
            lottoMaxForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lotto649Button_Click(object sender, EventArgs e)
        {
            Lotto649Form lotto649Form = new Lotto649Form();
            lotto649Form.Show();
        }

        private void montyExchageButton_Click(object sender, EventArgs e)
        {
            MoneyExchangeForm moneyExchangeForm = new MoneyExchangeForm();
            moneyExchangeForm.Show();
        }

        private void TempratureConvertButton_Click(object sender, EventArgs e)
        {
            TempratureConvertForm tempratureConvertForm = new TempratureConvertForm();
            tempratureConvertForm.Show();
        }

        private void calculaterButton_Click(object sender, EventArgs e)
        {
            SimpleCalculatorForm calculaterForm = new SimpleCalculatorForm();
            calculaterForm.Show();
        }

        private void ipButton_Click(object sender, EventArgs e)
        {
            IP_v4ValidatorForm iP_V4ValidatorForm = new IP_v4ValidatorForm();
            iP_V4ValidatorForm.Show();
        }
    }
}
