using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Finance_Calculator
{
    public partial class Form1 : Form
    {
        private const double prime = 0.1175;
        private double primePlusTwo = prime + 0.02;
        private double termInMonths = 72.0;
        private double monthlyAmount = 0.00;
        private double baloonPayment = 0.00;
        private double deposit = 0.00;
        private double tradeInValue = 0.00;
        private double affordabilityAmount = 0.00;
        private double loanAmount = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtMontlyPayment_TextChanged(object sender, EventArgs e)
        {
            monthlyAmount = double.Parse(txtMontlyPayment.Text);
            calculateOutput();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Balloon
            baloonPayment = double.Parse(txtBalloonPayment.Text);
            calculateOutput();
        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            deposit = double.Parse(txtDeposit.Text);
            calculateOutput();
        }

        private void txtTradeInValue_TextChanged(object sender, EventArgs e)
        {
            tradeInValue = double.Parse(txtTradeInValue.Text);
            calculateOutput();
        }

        private void calculateOutput()
        {
            affordabilityAmount = ((monthlyAmount * (1.0 - (Math.Pow((1.0 + primePlusTwo / 12.0), -termInMonths)))) / (primePlusTwo / 12.0)) + deposit + baloonPayment + tradeInValue;
            loanAmount = affordabilityAmount - deposit;
            lblAffordibility.Text = "R " + affordabilityAmount.ToString("f2");
            lblLoanAmount.Text = "R " + loanAmount.ToString("f2");
        }
    }
}
