using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            double first, sec;
            first=Convert.ToDouble(textBox1.Text);
            sec = Convert.ToDouble(textBox2.Text);
            sum = first + sec;
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum;
            double first, sec;
            first = Convert.ToDouble(textBox1.Text);
            sec = Convert.ToDouble(textBox2.Text);
            sum = first - sec;
            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum;
            double first, sec;
            first = Convert.ToDouble(textBox1.Text);
            sec = Convert.ToDouble(textBox2.Text);
            sum = first * sec;
            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sum;
            double first, sec;
            first = Convert.ToDouble(textBox1.Text);
            sec = Convert.ToDouble(textBox2.Text);
            sum = first / sec;
            textBox3.Text = sum.ToString();
        }
    }
}
