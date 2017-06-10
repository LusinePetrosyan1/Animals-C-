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
        User user2;
        List<BookSample> BookSamples;
        public BookSearchForm()
        {
            InitializeComponent();
        }
        public BookSearchForm(List<Book> books,User user1)
        {
            Books = books;
            user2 = user1;
            InitializeComponent();
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);
            Books = books;
            foreach(Book b in Books){
                listBox1.Items.Add(b.BookSample.Name+" - "+ b.BookSample.Author+" "+b.BookSample.Year+" "+b.BookSample.Language);
            }
        }

        public BookSearchForm(List<BookSample> bookSamples,User user1)
        {
            Books = new List<Book>();
            user2 = user1;
            InitializeComponent();
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);
            BookSamples = bookSamples;
            foreach (BookSample b in BookSamples)
            {
                listBox1.Items.Add(b.Name + " - " + b.Author + " " + b.Year+" "+b.Language);
            }
                foreach (BookSample bs in bookSamples)
                {
                    foreach (Book b in Library.Books)
                    {
                        if (b.BookSample == bs)
                        {
                            Books.Add(b);
                        }
                    }
                }
        }
        private void BookSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Hide();
                Book book1 = Books[index];
                
                    BookInfoForm bif = new BookInfoForm(book1,user2);
                bif.ShowDialog();
            }
        }
    }
}
