using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGallery
{
    class classCreateButton
    {
        public void SetButtons(FlowLayoutPanel fp,Image[]images)
        {
            fp.Controls.Clear();
            int btnWidth = 50;
            int btnHeight = 50;
            foreach (Image image in images)
            {
                Button btn = GetButton(btnWidth,btnHeight);
                btn.BackgroundImage = image;
              
                fp.Controls.Add(btn);
            }
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        public Button GetButton(int btnWidth, int btnHeight)
        {
            Button button = new Button();
            button.FlatStyle = FlatStyle.Flat;
            button.Width = btnWidth;
            button.Height = btnHeight;
            button.Margin = new Padding(0);
            button.Padding = new Padding(0);
            button.BackgroundImageLayout = ImageLayout.Stretch;
            return button;
        }
        public Button[] GetButtons(FlowLayoutPanel flowLayoutPanel)
        {
            Control.ControlCollection controlCollection = flowLayoutPanel.Controls;
            int countControls = controlCollection.Count;
            Button[] buttons = new Button[countControls];
            int countMe = 0;
            foreach (Button item in controlCollection)
            {
                buttons[countMe++] = item;
            }
            return buttons;
        }
    }
}
