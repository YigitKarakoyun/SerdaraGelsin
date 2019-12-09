using System.Drawing;
using System.Windows.Forms;

namespace projectBus
{
    class classButton
    {
        public Color colorEmpty { get; set; } = Color.Blue;
        public Color colorFull { get; set; } = Color.Red;

        public Button GetButton(int width, int height, int text)
        {
            return GetButton(0, 0, width, height, text); 
        }
        public Button GetButton(int left, int top, int width, int height, int text)
        {
            return new Button()
            {
                Left = left,
                Top = top,
                Width = width,
                Height = height,
                Text = text.ToString(),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(0),
                Padding = new Padding(0),
                BackColor = colorEmpty,
                ForeColor = Color.WhiteSmoke,
            };
        }
        public void setEmpty(Button btn)
        {
            btn.BackColor = colorEmpty;
        }
        public void setFull(Button btn)
        {
            btn.BackColor = colorFull;
        }

    }
}

