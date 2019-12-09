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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Sıcak");
            cmbKategori.Items.Add("Soğuk");

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            string fiyat = txtFiyat.Text;
            string stok = txtStok.Text;
            string kategori = cmbKategori.Text;

            ListViewItem listViewItem = GetListViewItem(urunAdi,fiyat,stok,kategori);
            listView1.Items.Add(listViewItem);
            
        }
        private ListViewItem GetListViewItem(string urunAdi, string fiyat,string stok,string kategori)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = urunAdi;
            listViewItem.SubItems.Add(fiyat);
            listViewItem.SubItems.Add(stok);
            listViewItem.SubItems.Add(kategori);
            return listViewItem;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2(listView1.SelectedItems);
            form2.ShowDialog();
        }
    }
}
