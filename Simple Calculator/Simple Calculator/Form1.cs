using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        double resultValue;
        string operationPerformed;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button14.Text;
            }
            else
            { 
                textBox1.Text = textBox1.Text + button14.Text; 
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button11.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button11.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button12.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button12.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button13.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button13.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button8.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button9.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button10.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button10.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button5.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button6.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button7.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button7.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button1.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + button15.Text;
            operationPerformed = button15.Text;
            label1.Text = resultValue + " " + operationPerformed;
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + button4.Text;
            operationPerformed = button4.Text;
            label1.Text = resultValue + " " + operationPerformed;
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + button3.Text;
            operationPerformed = button3.Text;
            label1.Text = resultValue + " " + operationPerformed;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + button2.Text;
            operationPerformed = button2.Text;
            label1.Text = resultValue + " " + operationPerformed;
            textBox1.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                label1.Text = resultValue + operationPerformed + double.Parse(textBox1.Text);     
                textBox1.Text = (resultValue + double.Parse(textBox1.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                label1.Text = resultValue + operationPerformed + double.Parse(textBox1.Text);
                textBox1.Text = (resultValue - double.Parse(textBox1.Text)).ToString();
            }
            else if (operationPerformed == "*")
            {
                label1.Text = resultValue + operationPerformed + double.Parse(textBox1.Text);
                textBox1.Text = (resultValue * double.Parse(textBox1.Text)).ToString();
            }
            else if (operationPerformed == "/") { 
                label1.Text = resultValue + operationPerformed + double.Parse(textBox1.Text);
             textBox1.Text = (resultValue / double.Parse(textBox1.Text)).ToString();
            }
        }
    }
}
