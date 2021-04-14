/* CIS 605 Assignment 3 - Program 4
 * Developed by Christopher Karnas
 * Date Created: September, 2020
 * Date Last Modified: 9/22/2020
 * Class name: Loan
 * Description: Terms of a loan
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram4
{
    class Loan
    {
 
        // Calculate and return the payment of a loan 

        public double CalculateMonthlyPayment(int intLoan, int intDuration, double doubleRate)
        {
            // constants and variables

            const int NumMonths = 12;
            double MonthlyRate, MonthlyPmt;

            MonthlyRate = doubleRate / (100 * NumMonths);

            MonthlyPmt = (intLoan * (MonthlyRate * Math.Pow(1 + MonthlyRate, intDuration))) / ((Math.Pow(1 + MonthlyRate, intDuration)) - 1);

            return MonthlyPmt;
        }

    }
}
