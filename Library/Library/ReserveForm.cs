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
    public partial class ReserveForm : Form
    {
        Book book4;
        User user4;
        decimal price;
        int duration;
        bool q = false;
        public ReserveForm()
        {
            InitializeComponent();
        }
        public ReserveForm(Book book, User user)
        {
            InitializeComponent();
            book4 = book;
            user4 = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                duration = int.Parse(textBox1.Text);
                price = book4.BookSample.Cost * int.Parse(textBox1.Text);
            }
            catch
            {
                price = 0;

            }
            if (duration < 0)
            {
                price = 0;
            }

            label3.Text = price + "";
        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (user4.Money < (int)price)
            {
                MessageBox.Show("You don't have enough money to reserve this book.");
                return;
            }

            try
            {
                user4.Reserve(book4, int.Parse(textBox1.Text));

            }
            catch
            {
                MessageBox.Show("Please enter a possitive number.");
                return;
            }

            if (duration <= 0)
            {
                MessageBox.Show("Please enter a possitive number");
                return;
            }
            Close();
        }

    }
}
