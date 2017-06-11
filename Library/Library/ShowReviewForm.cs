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
    public partial class ShowReviewForm : Form
    {
        public ShowReviewForm()
        {
            InitializeComponent();
        }
        List<Review> reviews1;
        ListViewItem item;
        public ShowReviewForm(List<Review> reviews)
        {
            InitializeComponent();
            reviews1 = reviews;
            string[] arr = new string[4];
            for (int i = 0; i < reviews1.Count; i++)
            {
                arr[0] = reviews1[i].User.Login;
                arr[1] = reviews1[i].Rate+"";
                arr[2] = reviews1[i].Opinion;
                arr[3] = reviews1[i].Date+"";
                item = new ListViewItem(arr);
                listView1.Items.Add(item);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
