using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBox1.Text, out number);
            if (number <= 6000000000 || number >= 10000000000)
                label1.Text = "BAD guess.";
            else
                label1.Text = "Good work";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int number2;
            int.TryParse(textBox2.Text, out number2);
            if (number2 < 1 || number2 > 3)
                label1.Text = "BAD guess.";
            else
                label1.Text = "Nice guess!";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            int number3;
            int.TryParse(textBox3.Text, out number3);
            if (number3 <= 5 || number3 >= 60)
                label1.Text = "BAD GUESS.";
            else
                label1.Text = "Great job.";

            double num1, num3;
            double estimate = 0.0;
            int num2;

            double.TryParse(textBox1.Text, out num1);
            int.TryParse(textBox2.Text, out num2);
            double.TryParse(textBox3.Text, out num3);

            if ((num1 <= 6000000000 || num1 >= 10000000000) && (num2 < 1 || num2 > 3) && (num3 <= 5 || num3 >= 60)) ;
                estimate = num1 / (24 * 60 / (num2 * num3));
                label5.Text = "There are " + Convert.ToInt64(estimate).ToString() + " people eating currently!";
        }
        private void label5_Click(object sender, EventArgs e)
        {
            label5.Show();
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
