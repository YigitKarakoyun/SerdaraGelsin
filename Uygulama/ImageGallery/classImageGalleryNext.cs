using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGallery
{
    class classImageGalleryNext
    {
        classImageGallery classImageGallery = new classImageGallery();
        int counted = 0;
        int countable;
        public Image[] images;
        public classImageGalleryNext()
        {
            images = classImageGallery.GetImages();
            countable = images.Length;
        }
        public Image GetNextImage()
        {
            Image temp = null;
            if (images == null)
            {
                return null;
            }
            if (counted < countable)
            {
                temp = images[counted];
                counted++;
            }
            else
            {
                counted = 0;
                if (images.Length > 0)
                {
                    temp = images[counted];
                }
                
                
            }
            return temp;
        }
        
    }
}
