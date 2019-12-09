using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ListView.SelectedListViewItemCollection selectedListViewItemCollection;
        public Form2(ListView.SelectedListViewItemCollection selectedListViewItemCollection)
        {

            InitializeComponent();
            this.selectedListViewItemCollection = selectedListViewItemCollection;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (ListViewItem item in selectedListViewItemCollection)
            {
                label1.Text += 
                    item.SubItems[0].Text + " " +
                    item.SubItems[1].Text + " " +
                    item.SubItems[2].Text + " " +
                    item.SubItems[3].Text + "\n";
            }
            
        }
    }
}
