using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class SeasonHandleGroupBox : UserControl
    {
        public delegate void MethodContainer();
        public event MethodContainer buttonClickedWinter, buttonClickedSpring, buttonClickedSummer, buttonClickedAutumn;

        public SeasonHandleGroupBox()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    Picture.Image = Image.FromFile(@"images\winter.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    buttonClickedWinter();
                    break;
                case "Spring":
                    Picture.Image = Image.FromFile(@"images\spring.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    buttonClickedSpring();
                    break;
                case "Summer":
                    Picture.Image = Image.FromFile(@"images\summer.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    buttonClickedSummer();
                    break;
                case "Autumn":
                    Picture.Image = Image.FromFile(@"images\autumn.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    buttonClickedAutumn();
                    break;
            }
        }
    }
}
