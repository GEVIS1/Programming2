using System;
using System.Windows.Forms;

namespace Programming2Class1Task6
{
    public partial class Form1 : Form
    {
        Random randomInteger = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* 
         * Use: React to user clicking on the Sum button.
         * Function: Take the input from the 5 number textboxes \
         *           and return the sum of the numbers.
         * Parameters: sender, e
         * Return: Void
         */
        private void sum_Click(object sender, EventArgs e)
        {
            int result = 0;

            ErrorCorrection();

            // When we know all the textboxes have only numbers we make the calculation
            result = Int16.Parse(textBox1.Text) +
                     Int16.Parse(textBox2.Text) +
                     Int16.Parse(textBox3.Text) +
                     Int16.Parse(textBox4.Text) +
                     Int16.Parse(textBox5.Text);

            // Display the result
            textBox6.Text = result.ToString();
        }

        /* 
         * Use: React to user clicking on the Average button.
         * Function: Take the input from the 5 number textboxes \
         *           and return the average of the numbers.
         * Parameters: sender, e
         * Return: Void
         */
        private void average_Click(object sender, EventArgs e)
        {
            int result = 0;

            ErrorCorrection();

            // When we know all the textboxes have only numbers we make the calculation
            result = Int16.Parse(textBox1.Text) +
                     Int16.Parse(textBox2.Text) +
                     Int16.Parse(textBox3.Text) +
                     Int16.Parse(textBox4.Text) +
                     Int16.Parse(textBox5.Text);

            // Divide the sum by the 5 input numbers
            result /= 5;

            // Display the result
            textBox7.Text = result.ToString();
        }

        /* 
         * Use: React to user clicking on the Clear button.
         * Function: Clear all textboxes.
         * Parameters: sender, e
         * Return: Void
         */
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }

        /* 
         * Use: React to user clicking on the Random button.
         * Function: Put random integers in all the input textboxes.
         * Parameters: sender, e
         * Return: Void
         */
        private void random_Click(object sender, EventArgs e)
        {
            randomInteger = new Random();

            textBox1.Text = randomInteger.Next(Int16.MaxValue + 1).ToString();
            textBox2.Text = randomInteger.Next(Int16.MaxValue + 1).ToString();
            textBox3.Text = randomInteger.Next(Int16.MaxValue + 1).ToString();
            textBox4.Text = randomInteger.Next(Int16.MaxValue + 1).ToString();
            textBox5.Text = randomInteger.Next(Int16.MaxValue + 1).ToString();
        }

        /* 
         * Use: Fix erronous input in a text box.
         * Function: Check the input text box \
         *           and make sure it only contains numbers.
         *           If found, errors will be replaced by a zero.
         * Parameters: Text box object
         * Return: Void
         */
        private static void FixTextBoxError(TextBox textBox)
        {
            // Test if the text box is empty, or if it contains anything not a 16-bit integer
            if ((textBox.Text == null) || (Int16.TryParse(textBox.Text, out _) == false))
            {
                textBox.Text = "0";
            }
        }

        /* 
         * Use: Run the error corrector on all the textboxes.
         * Function: Repeat the FixTextBoxError method for each text box.
         * Parameters: N/A
         * Return: Void
         */
        private void ErrorCorrection()
        {
            FixTextBoxError(textBox1);
            FixTextBoxError(textBox2);
            FixTextBoxError(textBox3);
            FixTextBoxError(textBox4);
            FixTextBoxError(textBox5);
        }


    }
}
