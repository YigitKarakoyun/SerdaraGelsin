using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavHazirlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int satir = 12;
        int sutun = 5;
        Form2 frm2;

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox combo = new ComboBox();
            combo.Location = new Point(350, 20);
            combo.Items.Add("Solaris");
            combo.Items.Add("Ikarus");
            combo.SelectedIndexChanged += MyCombo_SelectedIndexChange;
            this.Controls.Add(combo);

            Button btn = new Button();
            btn.Height = 30;
            btn.Width = 70;
            btn.Text = "Giriş Yap";
            btn.Location = new Point(350, 70);
            this.Controls.Add(btn);
        }

        private void MyCombo_SelectedIndexChange(object sender, EventArgs e)
        {
            //ButonDispose();
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex == 0)
            {
                MessageBox.Show(cmb.SelectedItem.ToString());
                satir = 12;
                sutun = 5; 
            }
            else
            {
                MessageBox.Show(cmb.SelectedItem.ToString());
                satir = 14;
                sutun = 4; 
            }
            KoltukDuzeni(satir, sutun);
        }

        private void KoltukDuzeni(int boy, int en)
        {
            ButonDispose();
            int koltukNo = 1;
            for (int i = 0; i < boy; i++)//satir
            {
                for (int j = 0; j < en; j++) // sutun
                {
                    Button btn = new Button();
                    btn.Height = 30;
                    btn.Width = 30;
                    btn.Name = "btn" + koltukNo;
                    btn.Tag = "koltuk";
                    btn.Text = koltukNo.ToString();
                    btn.Location = new Point(j*30, i*30);
                    btn.Click += Btn_Click;
                    this.Controls.Add(btn);
                    koltukNo++;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            frm2 = new Form2(tiklananButon);
            frm2.ShowDialog();
        }

        private void ButonDispose()
        {
            baslangic:
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    string s = item.Tag?.ToString();
                    if (s == "koltuk")
                    {
                        item.Dispose();
                        goto baslangic;
                    }
                }
            }
        }
    }
}
