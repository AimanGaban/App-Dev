using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik_Mangga_Management_Form
{
    public partial class Billing_Form : Form
    {
        //Setting the tax value for payment to 6%
        const double Tax = 1.06;


        public Billing_Form()
        {
            InitializeComponent();
        }
        //To calculate and show the total price
        private void TotalLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double Total, Price = 0;
            //Collecting info from treatmentbox and change it into value
            string Treatment = TreatmentBox.Text;
            //Setting price
            switch (Treatment)
            {
                case "Pimple Treatment":
                    Price = 50;
                    break;
                case "Stretch Treatment":
                    Price = 120;
                    break;
                case "Dermabrasion":
                    Price = 320;
                    break;
                case "Chemical Peel":
                    Price = 280;
                    break;
            }
            //Calculating the total price including medicine and tax
            Total = (Price + Convert.ToDouble(MedicinePriceBox.Text)) * Tax;
            //Setting the value to 2 decimal points
            string s = ".00";
            //To show the total price
            TotalPriceLabel.Text = Total.ToString(s);
            TotalPriceLabel.Visible = true;
        }
        //The payment will be done by clicking this button and all the details has been entered
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            //declaring all needed variables
            double Total = Convert.ToDouble(TotalPriceLabel.Text), Balance, Payment = Convert.ToDouble(PayBox.Text);
            //to calculate the balance
            Balance = Payment - Total;
            //to set the type of payment. If none, warning message will appear
            if (CashRadBut.Checked)
            {
                MethodLabel.Text = CashRadBut.Text;
            }
            else if (CardRadBut.Checked)
            {
                MethodLabel.Text = CardRadBut.Text;
            }
            else if (EWalRadBut.Checked)
            {
                MethodLabel.Text = EWalRadBut.Text;
            }
            else if (TransRadBut.Checked)
            {
                MethodLabel.Text = TransRadBut.Text;
            }
            else
            MessageBox.Show("Please Choose Payment Type", "Error");
            //Setting the output to two decimal place
            if (Balance >= 0)
            {
                BalanceLabel.Text = Balance.ToString(".00");
                BalanceLabel.Visible = true;
            }
            //Show warning of not enough money
            else
            {
                MessageBox.Show("Not enough money","Payment Issue");
                BalanceLabel.Text = Balance.ToString(".00");
                BalanceLabel.Visible = true;
            }
        }
        //As of now, we can't convert the output to pdf and show bill as print. Instead, we return to main page
        private void PrintButton_Click(object sender, EventArgs e)
        {
            Main_Page MP = new Main_Page();
            this.Hide();
            MP.ShowDialog();
        }

    }
}
