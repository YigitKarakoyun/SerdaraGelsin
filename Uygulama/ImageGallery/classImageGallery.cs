using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGallery
{
    class classImageGallery
    {
        public classImageGallery()
        {
            imagePath = Application.StartupPath + "\\images\\";
        }
        string imagePath;
        public Image[] GetImages()
        {
            if (!File.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }
            string[] imagesPath = Directory.GetFiles(imagePath);
            //MessageBox.Show(imagePath);
            Image[] tempImages = new Image[imagesPath.Length];
            for (int i = 0; i < imagesPath.Length; i++)
            {
                tempImages[i] = GetImageFormLocation(imagesPath, i);
            }
            //MessageBox.Show((tempImages == null).ToString()+tempImages.Length);
            return tempImages;
        }
        public Image GetImageFormLocation(string[] images,int i)
        { 
            if (images == null || images.Length<=i || i<0)
            {
                return null;
            }
            return Image.FromFile(images[i]);
        }
        Random random = new Random();
        public int GetImageIndexRandomly(string[] images)
        {
            if (images == null)
            {
                return -1;
            }
            return random.Next(images.Length);
        }
        public Image GetImageFormLocation_Randomly(string[] images)
        {
            return GetImageFormLocation(images, GetImageIndexRandomly(images));
        }

        public Image GetSelectedButton_Image(object sender)
        {
            if (sender is Button)
            {
                Button temp = sender as Button;
                return temp.BackgroundImage;
            }
            return null;
        }
    }
}
