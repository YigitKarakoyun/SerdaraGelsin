using System;
using System.Drawing;

namespace ScreenServer
{
    class classNames
    {
        string[] isimler =
        {
            "Emrah", "Serdar", "Yigit", "Mustafa", "Dincer",
            "Emre", "Aytug", "Alper",  "Fatih", "Murat",
            "Hakan","Fatos", "Fatma", "Verda", "Gorkem"
        };
        Random random = new Random();
        public string GetName_Randomly()
        {
            int rnd = random.Next(isimler.Length);
            return isimler[rnd];
        }
        public Color GetColor_Randomly()
        {
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            return Color.FromArgb(red, green, blue);
        }
        public Font GetFont()
        {
            return new Font(FontFamily.GenericSansSerif, 50, FontStyle.Bold);
        }

        public Brush GetBrush(Color color)
        {
            return new SolidBrush(color);
        }
        public Point GetPoint(Form1 form1)
        {
            int x = random.Next(10, form1.Width - 75);
            int y = random.Next(10, form1.Height - 75);
            return new Point(x, y);
        }

        //---------------------------------------------------------------------------------
        public void SetNamesOnForm(Form1 form1)
        {
            Color color = GetColor_Randomly();
            Font font = GetFont();
            Brush brush = GetBrush(color);
            string name = GetName_Randomly();
            Point point = GetPoint(form1);

            Graphics g = form1.CreateGraphics();
            g.DrawString(name, font, brush, point);
        }
    }
}
