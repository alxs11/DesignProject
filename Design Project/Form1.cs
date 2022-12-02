using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Final design project
//Allows user to use a GUI to do specific Order of Magnitude estimates
//Author: Alexis Urias

namespace Design_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (radioButton1.Checked)
                f2.ShowDialog();

            Form3 f3 = new Form3();
            if (radioButton2.Checked)
                f3.ShowDialog();

            Form4 f4 = new Form4();
            if (radioButton3.Checked)
                f4.ShowDialog();

            Form5 form5 = new Form5();
            if (radioButton4.Checked)
                form5.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
