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
        int selectedOperator;
        TextBox display;
        bool error;

        // Constructor grabbing calculator display textbox
        public Calculations(TextBox calcDisplay, int selectedOperator, decimal previous, bool error)
        {
            display = calcDisplay;
            this.selectedOperator = selectedOperator;
            this.previous = previous;
            this.error = error;
            
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
         * Use:         Method to subtract a number from another.
         * Function:    Takes the previous input and the current input in the display \ 
         *              and subtracts the current input from the previous.
         * Parameters:  minuend, subtrahend.
         * Return:      The result of the subtraction.
         */
        public decimal Sub(decimal minuend, decimal subtrahend)
        {
            decimal result = minuend - subtrahend;
            return result;
        }

        /* 
         * Use:         Method to multiply the previous input times the current input.
         * Function:    Takes the previous input and multiplies it by the current input \
         *              in the display. If the previous or the current input is zero it \
         *              always returns zero.
         * Parameters:  Multiplicand, multiplier.
         * Return:      The result of the multiplication.
         */
        public decimal Mul(decimal multiplicand, decimal multiplier)
        {
            if (multiplicand == 0 || multiplier == 0)
            {
                return 0;
            }

            decimal result = multiplicand * multiplier;

            return result;
        }

        /* 
         * Use:         Method to divide the previous input by the current input.
         * Function:    Takes the previous input and divides it by the current input \
         *              in the display. If the divisor is zero it displays an error.
         * Parameters:  Dividend, divisor.
         * Return:      The result of the division.
         */
        public decimal Div(decimal dividend, decimal divisor)
        {
            decimal result = 0;
            if (divisor == 0)
            {
                error = true;
                return result;
            }

            result = dividend / divisor;

            return result;
        }

        /* 
         * Use:         Method to do modulus arithmetic.
         * Function:    Takes the previous input and mods it into the current input.
         * Parameters:  n, mod.
         * Return:      decimal n to the mod provided.
         */
        public decimal Mod(decimal n, decimal mod)
        {
            decimal result = n % mod;
            return result;
        }

        // Store previous value in the display for use later
        public decimal StorePrevious()
        {
            if (display.Text != "")
            {
                return previous = Convert.ToDecimal(display.Text);
            }

            return 0;
        }

    }
}
