using System;
using System.Windows.Forms;

namespace QuizForms
{
    public partial class Form1 : Form
    {
        int ans = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans = 0;

            // Check if exactly checkBox3 is checked and checkBox2 and checkBox1 are not checked
            if (checkBox3.Checked && !checkBox2.Checked && !checkBox1.Checked)
            {
                ans++;
            }

            // Check if exactly checkBox4 is checked and checkBox5 and checkBox6 are not checked
            if (checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
            {
                ans++;
            }

            // Check if exactly checkBox7 is checked and checkBox8 and checkBox9 are not checked
            if (checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked)
            {
                ans++;
            }

            // Update the score and display
            display();
        }

        private void display()
        {
            string s = textBox1.Text;
            label5.Text = "Your Regno: " + s + " And Your Score is: " + ans;
        }
    }
}
