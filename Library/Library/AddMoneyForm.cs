using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    
    public partial class AddMoneyForm : Form
    {
        public static decimal money;
        public AddMoneyForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                money = Decimal.Parse(textBox1.Text);
                Hide();
            }
            catch
            {

            }
        }

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
