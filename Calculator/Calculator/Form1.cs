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
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "÷";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "×";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = Operations.Changes(a);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            String b = textBox1.Text;
            String a = "";
            if (!b.Contains('+') && !b.Contains('×') && !b.Contains('÷') && !b.Contains('%') && (!b.Contains('-') || b.IndexOf('-') == 0))
            {
                {
                    a = (Int64.Parse(b) * (-1))+"";
                }
            }
            else {
                a = b;
            }
            textBox1.Text = a + "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "√" + "( "+ textBox1.Text +" )";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length - 1;
            textBox1.SelectionLength = 0;
        }
    }
}
