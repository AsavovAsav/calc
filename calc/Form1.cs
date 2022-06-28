using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static calc.TwoArgumentsFactory;
using static calc.ITwoCalculator;

namespace calc
{
    public partial class Form1 : Form
    {
        public string action;
        public double sum;
        public string first, sec;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            first = textBox1.Text;
            sec = textBox2.Text;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(sec);
            double calc = Creatror(action);
            double result = calc;
            if (action == "Степень")
            {
                if (firstNum < 0)
                {
                    textBox3.Text = "Число должно быть > 0";
                    return;
                }
            }

            if (action == "/")
            {
                if (secondNum == 0)
                {
                    textBox3.Text = "На ноль делить нельзя";
                    return;
                }
            }
            textBox3.Text = result.ToString();
        }
    }
}
