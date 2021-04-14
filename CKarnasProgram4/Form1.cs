using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Click event payment calculation

        private void btnPayment_Click(object sender, EventArgs e)
        {
            {
                // Declare Variables

                int intLoan, intDuration;

                double doubleRate, MonthlyPmt;

                Loan aLoan;

                // Convert data in numeric up/down controls and assign to variables

                intLoan = Convert.ToInt32(numUpDnLoanAmt.Value);
                intDuration = Convert.ToInt32(numUpDnDuration.Value);
                doubleRate = Convert.ToDouble(numUpDwnInterest.Value);

                //instantiate a loan object

                aLoan = new Loan();

                // call the CalculatePayment Method

                MonthlyPmt = aLoan.CalculateMonthlyPayment(intLoan, intDuration, doubleRate);

                // display the result

                lblPayment.Text = MonthlyPmt.ToString("C");

            }

        }

        // Exits the form

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Resets the form inputs and payment label

        private void btnReset_Click(object sender, EventArgs e)
        {
            numUpDnLoanAmt.Value = 0;
            numUpDnDuration.Value = 0;
            numUpDwnInterest.Value = 0;
            lblPayment.Text = null;
        }
    }
}
