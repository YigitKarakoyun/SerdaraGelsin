using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        classCount classCount = new classCount();
        classNames classNames = new classNames();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (classCount.GetCountContinue())
            {
                classNames.SetNamesOnForm(this);
                classCount.SetCountedIncrease();
            }
            else
            {
                timer1.Stop();
            }
        }
        
    }
}
