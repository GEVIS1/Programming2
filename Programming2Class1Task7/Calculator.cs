using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming2Class1Task7
{
    public partial class Calculator : Form
    {
        private Calculations calcInstance;
        decimal previous;
        bool error;

        /* Operators are numbered as follows:
         * Add: 0
         * Sub: 1
         * Mul: 2
         * Div: 3
         * Mod: 4
         */

        private int selectedOperator;
        public Calculator()
        {
            InitializeComponent();
            calcInstance = new Calculations(display, selectedOperator, previous, error);
        }

        private void num0_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 2.ToString();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 3.ToString();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 4.ToString();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 5.ToString();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 6.ToString();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 7.ToString();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 8.ToString();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            display.Text = 9.ToString();
        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            calcInstance.ClearError();

            switch (selectedOperator)
            {
                // Add
                case 0:
                    display.Text = calcInstance.Add(previous, Convert.ToDecimal(display.Text)).ToString();
                    break;

                // Sub
                case 1:
                    display.Text = calcInstance.Sub(previous, Convert.ToDecimal(display.Text)).ToString();
                    break;

                // Mul
                case 2:
                    display.Text = calcInstance.Mul(previous, Convert.ToDecimal(display.Text)).ToString();
                    break;

                // Div
                case 3:
                    display.Text = calcInstance.Div(previous, Convert.ToDecimal(display.Text)).ToString();
                    if (calcInstance.CheckDivByZero())
                    {
                        display.Text = "Error: Div by zero";
                    }
                    break;

                // Mod
                case 4:
                    display.Text = calcInstance.Mod(previous, Convert.ToDecimal(display.Text)).ToString();
                    break;

                default:
                    display.Text = "Error";
                    break;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            selectedOperator = 0;
            display.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            selectedOperator = 1;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            selectedOperator = 2;
        }

        private void div_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            selectedOperator = 3;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            previous = calcInstance.StorePrevious();
            selectedOperator = 4;
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
