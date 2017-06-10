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
    public partial class BookSearchForm : Form
    {
        List<Book> Books;
        public BookSearchForm()
        {
            InitializeComponent();
        }
        public BookSearchForm(List<Book> books)
        {
            InitializeComponent();
            Books = books;
            foreach(Book b in Books){
                listBox1.Items.Add(b.BookSample.Name);
            }
        }
        private void BookSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
