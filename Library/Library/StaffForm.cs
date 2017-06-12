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
        public User user1;
        public StaffForm()
        {
            InitializeComponent();
        }
        public StaffForm(User user)
        {
            InitializeComponent();
            label1.Text = user.Name;
            label2.Text = user.Surname;
            user1 = user;

        }
        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowHistoryForm a = new ShowHistoryForm();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiveForm rf = new GiveForm(Library.ReturnUsers, Library.ReturnBooks, (Staff)user1);
            rf.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
