using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        Model.Rectangle[] _rectangles;
        Model.Rectangle _currentRectangle;

        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Rectangle();
                Random rnd = new Random();
                int rndColor = rnd.Next(0, 7);
                _rectangles[i].Width = rnd.Next(1, 100) + rnd.NextDouble();
                _rectangles[i].Length = rnd.Next(1, 100) + rnd.NextDouble();
                Model.Color rectanglesColor = (Model.Color)rndColor;
                string randomColor = rectanglesColor.ToString();
                _rectangles[i].Color = randomColor;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            ValueOfSelectedValue.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    foreach (int i in Enum.GetValues(typeof(Model.Color)))
                    {
                        ValuesListBox.Items.Add((Model.Color)i);
                    }
                    break;
                case "EducationForm":
                    foreach (int i in Enum.GetValues(typeof(EducationForm)))
                    {
                        ValuesListBox.Items.Add((EducationForm)i);
                    }
                    break;
                case "Genre":
                    foreach (int i in Enum.GetValues(typeof(Genre)))
                    {
                        ValuesListBox.Items.Add((Genre)i);
                    }
                    break;
                case "Manufacture":
                    foreach (int i in Enum.GetValues(typeof(Manufacture)))
                    {
                        ValuesListBox.Items.Add((Manufacture)i);
                    }
                    break;
                case "Season":
                    foreach (int i in Enum.GetValues(typeof(Season)))
                    {
                        ValuesListBox.Items.Add((Season)i);
                    }
                    break;
                case "Weekday":
                    foreach (int i in Enum.GetValues(typeof(Weekday)))
                    {
                        ValuesListBox.Items.Add((Weekday)i);
                    }
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueOfSelectedValue.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string valueOfTextBox = ValueForParsingBox.Text;
            if (valueOfTextBox == "")
            {
                return;
            }
            if (!Enum.TryParse(typeof(Weekday), valueOfTextBox, out object result) || Int32.TryParse(valueOfTextBox, out int value))
            {
                ResultOfParsing.Text = "Это не день недели.";
            }
            else
            {
                ResultOfParsing.Text = $"Это день недели ({valueOfTextBox} = {(int)result + 1}).";
            }
            ResultOfParsing.Visible = true;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    Picture.Image = Image.FromFile(@"images\winter.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(122, 255, 255);
                    break;
                case "Spring":
                    Picture.Image = Image.FromFile(@"images\spring.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
                    break;
                case "Summer":
                    Picture.Image = Image.FromFile(@"images\summer.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    break;
                case "Autumn":
                    Picture.Image = Image.FromFile(@"images\autumn.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
                    break;
            }
        }

        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RectanglesListBox.SelectedItem.ToString())
            {
                case "Rectangle 1":
                    _currentRectangle = (Model.Rectangle)_rectangles[0].Clone();
                    LengthTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;
                case "Rectangle 2":
                    _currentRectangle = _rectangles[1];
                    LengthTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;
                case "Rectangle 3":
                    _currentRectangle = _rectangles[2];
                    LengthTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;
                case "Rectangle 4":
                    _currentRectangle = _rectangles[3];
                    LengthTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;
                case "Rectangle 5":
                    _currentRectangle = _rectangles[4];
                    LengthTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text.Replace('.', ','));
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            _rectangles[RectanglesListBox.SelectedIndex].Length = _currentRectangle.Length;
            LengthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text.Replace('.', ','));
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            _rectangles[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
            WidthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
            _rectangles[RectanglesListBox.SelectedIndex].Color = _currentRectangle.Color;
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

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}