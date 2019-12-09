using System;
using System.Drawing;
using System.Windows.Forms;

namespace flowLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int count = 0;
            for (int j = 0; j < 12; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Button button = new Button() { Width = 30, Height = 30 };
                    flowLayoutPanel1.Controls.Add(button);

                    if (i % 2 == 1)
                    {
                        button.Enabled = false;
                        button.BackColor = this.BackColor;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        button.Text = "";
                    }
                    else
                    {
                        button.Text = (count++).ToString();
                    }


                }
                Button btnTemp = flowLayoutPanel1.Controls[0] as Button;
            }
            
            
        }
    }
}
