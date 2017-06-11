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
    public partial class GiveForm : Form
    {
        public GiveForm()
        {
            InitializeComponent();
        }
        List<User> users1;
        List<Book> books1;
        public GiveForm(List<User> users,List<Book> books)
        {
            InitializeComponent();
            users1 = users;
            books1 = books;
            string[] arr = new string[3];
            ListViewItem itm;
            for (int i = 0; i < books.Count; i++)
            {
                arr[0] = users[i].Name+ " " +users[i].Surname;
                arr[1] = books[i].BookSample.Name;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem itm;
            for (int i = books1.Count-1; i >=0; i--)
            {
                itm = listView1.Items[i];
                if (itm.Checked)
                {
                    Library.ReturnUsers.RemoveAt(i);
                    Library.ReturnBooks.RemoveAt(i);
                    users1 = Library.ReturnUsers;
                    books1 = Library.ReturnBooks;
                    listView1.Items.RemoveAt(i);
                }
            }
        }

        private void GiveForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
