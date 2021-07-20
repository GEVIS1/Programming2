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

        /* Operators are numbered as follows:
         * Add: 0
         * Sub: 1
         * Mul: 2
         * Div: 3
         * Mod: 4
         */

        private int selectedOperator;
        public Calculator(int selectedOperator)
        {
            InitializeComponent();
            calcInstance = new Calculations(display, selectedOperator, previous);
            this.selectedOperator = selectedOperator;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 0.ToString();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 1.ToString();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 2.ToString();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 3.ToString();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 4.ToString();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 5.ToString();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 6.ToString();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 7.ToString();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 8.ToString();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calcInstance.StorePrevious();
            display.Text = 9.ToString();
        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            switch (selectedOperator)
            {
                // Add
                case 0:
                    calcInstance.Add(previous, Convert.ToDecimal(display.Text));
                    break;

                //// Sub
                //case 1:
                //    calcInstance.Sub();
                //    break;

                //// Mul
                //case 2:
                //    calcInstance.Mul();
                //    break;

                //// Div
                //case 3:
                //    calcInstance.Div();
                //    break;

                //// Mod
                //case 4:
                //    calcInstance.Mod();
                //    break;
                
                default:
                    display.Text = "Error";
                    break;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void mul_Click(object sender, EventArgs e)
        {

        }

        private void div_Click(object sender, EventArgs e)
        {

        }

        private void mod_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
