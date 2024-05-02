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
    public partial class RectanglesGroupBox : UserControl
    {
        Model.Rectangle[] _rectangles;
        Model.Rectangle _currentRectangle;

        public RectanglesGroupBox()
        {
            InitializeComponent();
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = Model.Geometry.RectangleFactory.Randomize(200, 200);
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RectanglesListBox.SelectedItem.ToString())
            {
                case "Rectangle 1":
                    _currentRectangle = _rectangles[0];
                    break;
                case "Rectangle 2":
                    _currentRectangle = _rectangles[1];
                    break;
                case "Rectangle 3":
                    _currentRectangle = _rectangles[2];
                    break;
                case "Rectangle 4":
                    _currentRectangle = _rectangles[3];
                    break;
                case "Rectangle 5":
                    _currentRectangle = _rectangles[4];
                    break;
            }
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XCentreOfRectangleTextBox.Text = _currentRectangle.Location.CoordinateX.ToString();
            YCentreOfRectangleTextBox.Text = _currentRectangle.Location.CoordinateY.ToString();
            IdOfRectangleTextBox.Text = _currentRectangle.Id.ToString();
        }

        private int FindRectangleWithMaxWidth(Model.Rectangle[] _rectangles)
        {
            double maxWidth = _rectangles[0].Width;
            int indexOfMaxWidth = 0;
            for (int i = 1; i < 5; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    indexOfMaxWidth = i;
                }
            }
            return indexOfMaxWidth;
        }

        private void FindRectangleWithMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        #region Functions of text changes

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LengthTextBox.Text.Replace('.', ','));
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            LengthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text.Replace('.', ','));
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            WidthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        #endregion

    }
}
