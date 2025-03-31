using Programming.Model.Geometry;
using Programming.Model;
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
    public partial class RectanglesCollisionControl : UserControl
    {
        Model.Rectangle _currentRectangle;
        List<Model.Rectangle> _listOfRectangles = new List<Model.Rectangle>();
        List<Panel> _listOfPanels = new List<Panel>();
        Panel _currentPanel;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(RectanglesPanel.Size.Height, RectanglesPanel.Size.Width);
            _listOfRectangles.Add(_currentRectangle);
            RectanglesListBox.Items.Add($"{_currentRectangle.Id - 4}: (X = {_currentRectangle.Location.CoordinateX}; Y = {_currentRectangle.Location.CoordinateY}; W = {_currentRectangle.Width}; L = {_currentRectangle.Length})");
            _currentPanel = new Panel();
            _currentPanel.Size = new Size(_currentRectangle.Width, _currentRectangle.Length);
            _currentPanel.Location = new Point(_currentRectangle.Location.CoordinateX, _currentRectangle.Location.CoordinateY);
            _currentPanel.BackColor = System.Drawing.Color.FromArgb(127, 255, 127);
            _listOfPanels.Add(_currentPanel);
            RectanglesPanel.Controls.Add(_currentPanel);
            RectanglesListBox.SelectedIndex = _listOfRectangles.Count - 1;
            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            _currentRectangle = _listOfRectangles[RectanglesListBox.SelectedIndex];
            _currentPanel = _listOfPanels[RectanglesListBox.SelectedIndex];
            UpdateRectangleInfo();
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            int selInd = RectanglesListBox.SelectedIndex;
            ClearRectangleInfo();
            _listOfPanels.RemoveAt(selInd);
            RectanglesPanel.Controls.RemoveAt(selInd);
            _listOfRectangles.RemoveAt(selInd);
            RectanglesListBox.Items.RemoveAt(selInd);
            FindCollisions();
        }

        private void FindCollisions()
        {
            foreach (Panel i in _listOfPanels)
            {
                i.BackColor = System.Drawing.Color.FromArgb(127, 255, 127);
            }
            for (int i = 0; i < _listOfRectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _listOfRectangles.Count; j++)
                {
                    if (i == j) continue;
                    if (CollisionManager.IsCollision(_listOfRectangles[i], _listOfRectangles[j]))
                    {
                        _listOfPanels[i].BackColor = System.Drawing.Color.FromArgb(255, 127, 127);
                        _listOfPanels[j].BackColor = System.Drawing.Color.FromArgb(255, 127, 127);
                    }
                }
            }
        }

        private void UpdateRectangleInfo()
        {
            LengthOfRectangleTextBox.Text = _currentRectangle.Length.ToString();
            WidthOfRectangleTextBox.Text = _currentRectangle.Width.ToString();
            XOfRectangleTextBox.Text = _currentRectangle.Location.CoordinateX.ToString();
            YOfRectangleTextBox.Text = _currentRectangle.Location.CoordinateY.ToString();
            IdOfRectangleTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void ClearRectangleInfo()
        {
            LengthOfRectangleTextBox.Clear();
            WidthOfRectangleTextBox.Clear();
            XOfRectangleTextBox.Clear();
            YOfRectangleTextBox.Clear();
            IdOfRectangleTextBox.Clear();
        }

        #region Functions of text changes

        private void XOfRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (XOfRectangleTextBox.Text == "")
            {
                XOfRectangleTextBox.BackColor = System.Drawing.Color.White;
                return;
            }
            try
            {
                _currentRectangle.Location.CoordinateX = int.Parse(XOfRectangleTextBox.Text);
                _currentPanel.Location = new Point(int.Parse(XOfRectangleTextBox.Text), Convert.ToInt32(_currentRectangle.Location.CoordinateY));
            }
            catch
            {
                XOfRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            FindCollisions();
            XOfRectangleTextBox.BackColor = System.Drawing.Color.White;
        }

        private void YOfRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (YOfRectangleTextBox.Text == "")
            {
                YOfRectangleTextBox.BackColor = System.Drawing.Color.White;
                return;
            }
            try
            {
                _currentRectangle.Location.CoordinateY = int.Parse(YOfRectangleTextBox.Text);
                _currentPanel.Location = new Point(Convert.ToInt32(_currentRectangle.Location.CoordinateX), int.Parse(YOfRectangleTextBox.Text));
            }
            catch
            {
                YOfRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            FindCollisions();
            YOfRectangleTextBox.BackColor = System.Drawing.Color.White;
        }

        private void WidthOfRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WidthOfRectangleTextBox.Text == "")
            {
                WidthOfRectangleTextBox.BackColor = System.Drawing.Color.White;
                return;
            }
            try
            {
                _currentRectangle.Width = int.Parse(WidthOfRectangleTextBox.Text);
                _currentPanel.Size = new Size(int.Parse(WidthOfRectangleTextBox.Text), Convert.ToInt32(_currentRectangle.Length));
            }
            catch
            {
                WidthOfRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            FindCollisions();
            WidthOfRectangleTextBox.BackColor = System.Drawing.Color.White;
        }

        private void LengthOfRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LengthOfRectangleTextBox.Text == "")
            {
                LengthOfRectangleTextBox.BackColor = System.Drawing.Color.White;
                return;
            }
            try
            {
                _currentRectangle.Length = int.Parse(LengthOfRectangleTextBox.Text);
                _currentPanel.Size = new Size(Convert.ToInt32(_currentRectangle.Width), int.Parse(LengthOfRectangleTextBox.Text));
            }
            catch
            {
                LengthOfRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            FindCollisions();
            LengthOfRectangleTextBox.BackColor = System.Drawing.Color.White;
        }

        #endregion
    }
}
