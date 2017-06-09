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
    public partial class Form1 : Form
    {
        public string username;
        public string password;
        User User1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User user in Library.Users)
            {
                if (user.Login == username && user.Password == password)
                {
                    User1 = user;
                    break;
                }
            }
            UserForm secondform = new UserForm();
            Hide();
            secondform.ShowDialog();
            Close();
        }
    }
}
