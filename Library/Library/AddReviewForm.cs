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
    public partial class AddReviewForm : Form
    {
        Book book5;
        User user5;
        public AddReviewForm()
        {
            InitializeComponent();
        }
        public AddReviewForm(Book book, User user)
        {
            InitializeComponent();
            book5 = book;
            user5 = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = textBox1.Text;
            int rate =(int) numericUpDown1.Value;
            Review a = new Review(user5, DateTime.Now, textBox1.Text, Convert.ToInt32(numericUpDown1.Value));
            for (int i = 0; i < book5.ReviewList.Count; i++)
            {
                if (book5.ReviewList[i].User.Login == user5.Login) {
                    book5.ReviewList.RemoveAt(i);
                    break;
                }
            }
            book5.AddReview(a);
          
            Close();
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
