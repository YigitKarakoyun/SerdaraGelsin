using System;
using System.Linq;
using System.Windows.Forms;

namespace projectBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        classPanelArrange classPanel = new classPanelArrange();
        classButton classButton = new classButton();

        int[] doorRight = { 3, 8 };
        int[] doorLeft = { 3, 8 };
        private void button1_Click(object sender, EventArgs e)
        {
            int row = 12;
            int column = 5;

            int count = 0;
            int coridor = 2;
            int notnullrow = row-1;

            panel1.Controls.Clear();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    bool my_control = false;
                    if (notnullrow==i)
                    {
                        my_control = true;

                    }
                    else
                    {
                        if (classPanel.GetCooridor_Not(j, coridor))
                        {
                            my_control = true;
                        }

                        if (doorRight.Contains(i) && j>coridor)
                        {
                            my_control = false;
                        }
                        if (doorLeft.Contains(i) && j < coridor)
                        {
                            my_control = false;
                        }
                    }
                    


                    if (my_control)
                    {
                        count++;
                        
                        int left1 = j * 30;
                        int top1 = i * 30;
                        Button btn = GetButton(left1, top1, 30, 30, count);
                        panel1.Controls.Add(btn);
                    }
                }
            }
        }

        private Button GetButton(int left, int top, int width, int height, int text)
        {
            return classButton.GetButton(left, top, width, height, text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
