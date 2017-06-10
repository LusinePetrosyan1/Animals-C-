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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string namef;
        string surNamef;
        string userNamef;
        string passwordf;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namef = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            surNamef = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            userNamef = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            passwordf = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 thirdform = new Form1();
            this.Hide();
            thirdform.ShowDialog();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
