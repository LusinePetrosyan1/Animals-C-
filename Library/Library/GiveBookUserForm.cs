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
    public partial class GiveBookUserForm : Form
    {
        List<Book> books1= new List<Book>();
        User user1;
        public GiveBookUserForm()
        {
            InitializeComponent();
        }
        public GiveBookUserForm(List<BookSample> books, User user)
        {
            InitializeComponent();
            user1 = user;
            ListViewItem itm;
            String[] arr = new String[3];
            foreach (BookSample bs in books)
            {
                arr[0] = bs.Name;
                arr[1] = bs.Author;
                arr[2] = bs.Calendar.DateOfBorrow+"";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                foreach (Book b in Library.Books)
                {
                    if (b.BookSample.Name == bs.Name && b.BookSample.Author == bs.Author)
                    {
                        books1.Add(b);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count-1; i >=0 ; i--)
            {
                if (listView1.Items[i].Checked)
                {
                    Library.ReturnBooks.Add(books1[i]);
                    Library.ReturnUsers.Add(user1);
                    books1.RemoveAt(i);
                    listView1.Items.RemoveAt(i);
                }   
            }
        }
    }
}
