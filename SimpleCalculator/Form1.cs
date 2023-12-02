using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void PerformOperation(string operation)
        {
            if (double.TryParse(textBox1.Text, out double operand1) && double.TryParse(textBox2.Text, out double operand2))
            {
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        if (operand2 != 0)
                            result = operand1 / operand2;
                        else
                            MessageBox.Show("Cannot divide by zero.");
                        break;
                    default:
                        break;
                }

                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }
    }
}
