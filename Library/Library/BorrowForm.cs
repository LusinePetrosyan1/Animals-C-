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
        public static int price;
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
                price = (int)(end - DateTime.Now).TotalDays*(int)book1.BookSample.Cost;
                label2.Text = price + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (end <= DateTime.Now)
            {
                MessageBox.Show("Choose days after today :D");
            }
            else
            {
                user1.BorrowBook(book1, end);
                Close();
            }
        }
    }
}
