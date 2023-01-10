using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static decimal firstValue = 0;
        public static decimal secondValue = 0;
        public static decimal currentElement = 0;
        public static char symbol = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        MathOperations operations
            = new MathOperations(firstValue, symbol, secondValue);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //The C symbol
        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            firstValue = 0;
            secondValue = 0;
            currentElement = 0;
        }

        //The % symbol
        private void button17_Click(object sender, EventArgs e)
        {
            currentElement = Convert.ToDecimal(label1.Text);
            label1.Text
                = operations.Percent(currentElement).ToString();
            currentElement = operations.Percent(currentElement);
        }

        //The / symbol
        private void button16_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDecimal(label1.Text);
            symbol = '/';
            label2.Text = $"{firstValue} / ";
            label1.Text = "";
        }

        //The * symbol
        private void button15_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDecimal(label1.Text);
            symbol = '*';
            label2.Text = $"{firstValue} *";
            label1.Text = "";
        }

        //The - symbol
        private void button14_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDecimal(label1.Text);
            symbol = '-';
            label2.Text = $"{firstValue} - ";
            label1.Text = "";
        }

        //The + symbol
        private void button13_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDecimal(label1.Text);
            symbol = '+';
            label2.Text = $"{firstValue} + ";
            label1.Text = "";
        }

        //The equals 
        private void button12_Click(object sender, EventArgs e)
        {
            secondValue = Convert.ToDecimal(label1.Text);
            label2.Text = "";

            switch (symbol)
            {
                case '+':
                    currentElement = operations.Add(firstValue, secondValue);
                    label1.Text
                        = operations.Add(firstValue, secondValue).ToString();
                    break;
                case '-':
                    currentElement = operations.Substract(firstValue, secondValue);
                    label1.Text
                        = operations.Substract(firstValue, secondValue).ToString();
                    break;
                case '/':
                    currentElement = operations.Devide(firstValue, secondValue);
                    label1.Text
                        = operations.Devide(firstValue, secondValue).ToString();
                    break;
                case '*':
                    currentElement = operations.Multiply(firstValue, secondValue);
                    label1.Text
                        = operations.Multiply(firstValue, secondValue).ToString();
                    break;
                default:
                    break;
            }

        }
        
        //The number 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        //The number 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        //The number 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        //The number 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        //The number 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        //The number 6
        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        //The number 7
        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        //The number 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        //The number 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        //The separator
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";
        }

        private void nightMode_Click(object sender, EventArgs e)
        {
            
        }
    }
}
