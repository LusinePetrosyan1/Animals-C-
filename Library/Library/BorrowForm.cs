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
    public partial class BorrowForm : Form
    {
        public Book book1;
        public User user1;
        public static DateTime end;
        public static decimal price;
        public static Calendar cal;
        public BorrowForm()
        {
            InitializeComponent();
        }
        public BorrowForm(Book book, User user)
        {
            InitializeComponent();
            user1 = user;
            book1 = book;
        }
        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            end =monthCalendar1.SelectionRange.Start;
            if (end <= DateTime.Now)
            {
                price = 0;
                label2.Text = price + "";
            }
            else
            {
                price = (decimal)((int)((decimal)(end - DateTime.Now).TotalDays*book1.BookSample.Cost*100))/100;
                label2.Text = price + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool q = false;
            bool a = false;
            if (end <= DateTime.Now)
            {
                q = true;
                MessageBox.Show("Choose days after today.");
            }
            if (user1.Money < price) {
                a = true;
                MessageBox.Show("You don't have enough money to borrow this book.");
            }

            if(!q && !a)
            {
                user1.BorrowBook(book1, end);
                Close();
            }
        }
    }
}
