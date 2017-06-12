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
    public partial class ShowHistoryForm : Form
    {
        public ShowHistoryForm()
        {
            InitializeComponent();

            for (int i = 0; i < Library.History.Count; i++)
            {
                listBox1.Items.Add(Library.History[i]); 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
