using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram
{
    
    public partial class Form1 : Form
    {
        private Random random;   // declaration
        public Form1()
        {
            random = new Random();
            InitializeComponent();

            //for (int i = 0; i < 10000; i++)
            //{
            //    Form1.
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Goodbye world!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nClicks = Convert.ToInt16(textBox1.Text);
            nClicks = nClicks + 1;
            textBox1.Text = Convert.ToString(nClicks);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = random.Next(100).ToString();
        }
    }
}
