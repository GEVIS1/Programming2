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
        public Calculator()
        {
            InitializeComponent();
            calcInstance = new Calculations(display);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void mul_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
