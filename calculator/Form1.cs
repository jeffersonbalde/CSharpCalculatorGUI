using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        Double result = 0;
        String operation = "";
        bool operationClick = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button7.Text;
            operationClick = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button8.Text;
            operationClick = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button9.Text;
            operationClick = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button4.Text;
            operationClick = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button5.Text;
            operationClick = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button6.Text;
            operationClick = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button1.Text;
            operationClick = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button2.Text;
            operationClick = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button3.Text;
            operationClick = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            textBox1.Text += button0.Text;
            operationClick = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationClick))
            {
                textBox1.Clear();
            }
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += buttonDot.Text;
            }
            operationClick = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            result = 0;
        }

        private void operationPerformed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox1.Text);
            operationClick = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }

            result = Double.Parse(textBox1.Text);
        }
    }
}
