using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baslangıc:
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Dispose();
                    goto baslangıc;
                }
            }
            int satirSayisi = 0;
            bool arkaBesli = false;
            int KoltukNo = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                satirSayisi = 14;
                arkaBesli = true;
            }
            else
            {
                satirSayisi = 12;
                arkaBesli = false;
            }


            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2 && (arkaBesli == true && i != satirSayisi -1)
                        || (j == 2 && arkaBesli == false)
                        )
                    {
                        continue;
                    }

                    if (i==6 && j> 2)
                    {
                        continue;
                    }


                    Button btn = new Button();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Top = 50 + (i * 30);
                    btn.Left = 100 + (j * 30);
                    btn.Text = (++KoltukNo).ToString();
                    btn.Click += btn_MyClick;
                    this.Controls.Add(btn);
                }
            }

        }

        private void btn_MyClick(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            frm2 = new Form2();
            frm2.koltukNo = tiklananButon.Text;
            frm2.Show();
        }
    }
}
