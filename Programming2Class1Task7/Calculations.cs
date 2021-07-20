using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@TODO Write comments.
// Finish methods

namespace Programming2Class1Task7
{
    // Class containing the calculator functionality
    class Calculations
    {
        // Always store previous input.
        decimal previous;
        TextBox display;
        
        public Calculations(TextBox calcDisplay)
        {
            display = calcDisplay;
        }

        /* 
         * Use:         Method to add two numbers together.
         * Function:    Takes the previous input and the current input in the display \
         *              and adds them together, then puts the result in the display.
         * Parameters:  addend1, addend2.
         * Return:      The sum of the two addends.
         */
        public decimal Add(decimal addend1, decimal addend2)
        {
            decimal result = addend1 + addend2;
            return result;
        }

        /* 
         * Use: 
         * Function: 
         * Parameters: 
         * Return: 
         */
        public decimal Sub(decimal minuend, decimal subtrahend)
        {
            decimal result = minuend - subtrahend;
            return result;
        }

        /* 
         * Use: 
         * Function: 
         * Parameters: 
         * Return: 
         */
        public decimal Mul(decimal multiplicand, decimal multiplier)
        {
            if (multiplicand == 0 || multiplier == 0)
            {
                return 0;
            }

            decimal result = 0;

            return result;
        }

        /* 
         * Use: 
         * Function: 
         * Parameters: 
         * Return: 
         */
        public decimal Div(decimal dividend, decimal divisor)
        {

            decimal result = 0;

            return result;
        }

        /* 
         * Use: 
         * Function: 
         * Parameters: 
         * Return: 
         */
        public decimal Mod(decimal n, int mod)
        {
            decimal result = 0;

            return result;
        }

        // Store previous value in the display for use later
        public void StorePrevious()
        {
            if (display.Text != "")
            {
                previous = Convert.ToDecimal(display.Text);
            }
        }

    }
}
