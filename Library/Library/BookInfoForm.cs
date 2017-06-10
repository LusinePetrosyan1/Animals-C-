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
    public partial class BookInfoForm : Form
    {
        private void BookInfoForm_Load(object sender, EventArgs e)
        {

        }
        public Book book1;
        User user3 ;

        public BookInfoForm()
        {
            InitializeComponent();
        }
        public BookInfoForm(Book book,User user)
        {
            user3 = user;
            InitializeComponent();
            book1 = book;
            label13.Text = book1.BookSample.Name;
            label12.Text = book.BookSample.Author;
            label11.Text = ""+book.BookSample.Year;
            label10.Text = ""+book.BookSample.NumberOfPages;
            label9.Text = "";
            foreach (var item in book.BookSample.Genre)
            {
                label9.Text += item + ",";
            }
            label9.Text = label9.Text.Substring(0, label9.Text.Length - 1);
            label8.Text = book.BookSample.Cost + " Per Day";
            label7.Text = book.Quantity+"";
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrowForm bf = new BorrowForm(book1, user3);
            bf.ShowDialog();
            Update();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            label13.Text = book1.BookSample.Name;
            label12.Text = book1.BookSample.Author;
            label11.Text = "" + book1.BookSample.Year;
            label10.Text = "" + book1.BookSample.NumberOfPages;
            label9.Text = "";
            foreach (var item in book1.BookSample.Genre)
            {
                label9.Text += item + ",";
            }
            label9.Text = label9.Text.Substring(0, label9.Text.Length - 1);
            label8.Text = book1.BookSample.Cost + " Per Day";
            label7.Text = book1.Quantity + "";
        }
    }
}
