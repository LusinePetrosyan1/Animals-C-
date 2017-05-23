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
            textBox1.Select();            
        }
        string memory = "";
        string line = "";
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            line += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            line += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            line += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            line += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            line += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            line += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            line += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            line += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            line += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "÷";
            line += "÷";


        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "×";
            line += "×";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            line += "-";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            line += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            line += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            line += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
            line += "%";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Operations.Changes(line);

            }
            catch(DivideByZeroException)
            {
                textBox1.Text = "Error!";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
            line += ")";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
            line += "(";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            String b = textBox1.Text;
            String a = "";
            if (!b.Contains('+') && !b.Contains('×') && !b.Contains('÷') && !b.Contains('%') && (!b.Contains('-') || b.IndexOf('-') == 0))
            {
                {
                    a = (Double.Parse(b) * (-1)) + "";
                }
            }
            else
            {
                a = b;
            }
            textBox1.Text = a + "";
            line = a;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = "√" + "(" + textBox1.Text + ")";
                line = "(" + "√" + "(" + line + ")" + ")";
            }
            catch (Exception)
            {
                textBox1.Text="Error!";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            textBox1.SelectionStart = textBox1.Text.Length - 1;
            textBox1.SelectionLength = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            memory = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (memory != null && memory != "")
            textBox1.Text = memory;
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            if (b != null & b != "")
                if (!b.Contains('+') && !b.Contains('×') && !b.Contains('÷') && !b.Contains('%') && (!b.Contains('-') || b.IndexOf('-') == 0))
                {
                    memory = Double.Parse(b) * (-1) + "";
                }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (line != null && line != "" && textBox1.Text != null && textBox1.Text != "")
            {
                line = line.Substring(0, line.Length - 1);
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            line = "";
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
