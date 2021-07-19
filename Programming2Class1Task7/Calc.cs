using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@TODO Write comments.
// Finish methods

namespace Programming2Class1Task7
{
    // Class containing the calculator functionality
    class Calc
    {
        // Always store previous input.
        decimal previous;

        /* 
         * Use: 
         * Function: 
         * Parameters: 
         * Return: 
         */
        public decimal Add(decimal input1, decimal input2)
        {
            decimal result = input1 + input2;
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

    }
}
