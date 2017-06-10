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
        public Book book1;

        public BookInfoForm()
        {
            InitializeComponent();
        }
        public BookInfoForm(Book book)
        {
            book1 = book;
            InitializeComponent();
        }

        private void BookInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
