using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        classCreateButton classCreateButton = new classCreateButton();
        classImageGallery classImageGallery = new classImageGallery();
        classImageGalleryNext classImageGalleryNext = new classImageGalleryNext();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = classImageGalleryNext.GetNextImage();
        }

        bool timerStarted = false;
        private void button1_Click(object sender, EventArgs e)
        {
            timerStarted = !timerStarted;
            if (timerStarted)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
        Button[] buttons;
        private void Form1_Load(object sender, EventArgs e)
        {
            classCreateButton.SetButtons(flowLayoutPanel1, classImageGalleryNext.images);
            pictureBox1.Image = classImageGalleryNext.GetNextImage();

      
            buttons = classCreateButton.GetButtons(flowLayoutPanel1);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += btnClick;
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            timer1.Stop();
            timerStarted = false;
            pictureBox1.Image = classImageGallery.GetSelectedButton_Image(sender);
        }
    }
}
