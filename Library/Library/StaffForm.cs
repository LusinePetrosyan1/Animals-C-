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
    public partial class StaffForm : Form
    {
        public User user;
        public StaffForm()
        {
            InitializeComponent();
        }
        public StaffForm(User user)
        {
            InitializeComponent();
            label1.Text = user.Name;
            label2.Text = user.Surname;

        }
        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnForm rf = new ReturnForm(Library.ReturnUsers, Library.ReturnBooks);
            rf.ShowDialog();

        }
    }
}
