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
            decimal price = book4.BookSample.Cost * int.Parse(textBox1.Text);
            label3.Text = price + "";
        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
