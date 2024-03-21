using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        Model.Rectangle[] _rectangles;
        Model.Rectangle _currentRectangle;
        Film[] _films;
        Film _currentFilm;

        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Rectangle();
                Random rnd = new();
                int rndColor = rnd.Next(0, 8);
                _rectangles[i].Width = rnd.Next(1, 100) + Math.Round(rnd.NextDouble(), 2);
                _rectangles[i].Length = rnd.Next(1, 100) + Math.Round(rnd.NextDouble(), 2);
                Model.Color rectanglesColor = (Model.Color)rndColor;
                string randomColor = rectanglesColor.ToString();
                _rectangles[i].Color = randomColor;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            _films = new Film[5];
            for (int i = 0; i < 5; i++)
            {
                _films[i] = new Film();
                Random rnd = new();
                _films[i].YearOfRelease = rnd.Next(1900, 2025);
                _films[i].Duration = rnd.Next(1, 300);
                int rndRating = rnd.Next(11);
                if (rndRating != 10) _films[i].Rating = rndRating + Math.Round(rnd.NextDouble(), 2);
                else _films[i].Rating = 10;
                FilmsListBox.Items.Add($"Film {i + 1}");
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
            if (!Enum.TryParse(typeof(Weekday), valueOfTextBox, out object result) || int.TryParse(valueOfTextBox, out int value))
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
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
                _currentRectangle.Length = double.Parse(LengthTextBox.Text.Replace('.', ','));
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
                _currentRectangle.Width = double.Parse(WidthTextBox.Text.Replace('.', ','));
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

        private void FindRectangleWithMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        //
        //Films
        //

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FilmsListBox.SelectedItem.ToString())
            {
                case "Film 1":
                    _currentFilm = _films[0];
                    NameOfFilmTextBox.Text = _currentFilm.Name.ToString();
                    DurationOfFilmTextBox.Text = _currentFilm.Duration.ToString();
                    YearOfFilmReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
                    GenreOfFilmTextBox.Text = _currentFilm.Genre.ToString();
                    RatingOfFilmTextBox.Text = _currentFilm.Rating.ToString();
                    break;
                case "Film 2":
                    _currentFilm = _films[1];
                    NameOfFilmTextBox.Text = _currentFilm.Name.ToString();
                    DurationOfFilmTextBox.Text = _currentFilm.Duration.ToString();
                    YearOfFilmReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
                    GenreOfFilmTextBox.Text = _currentFilm.Genre.ToString();
                    RatingOfFilmTextBox.Text = _currentFilm.Rating.ToString();
                    break;
                case "Film 3":
                    _currentFilm = _films[2];
                    NameOfFilmTextBox.Text = _currentFilm.Name.ToString();
                    DurationOfFilmTextBox.Text = _currentFilm.Duration.ToString();
                    YearOfFilmReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
                    GenreOfFilmTextBox.Text = _currentFilm.Genre.ToString();
                    RatingOfFilmTextBox.Text = _currentFilm.Rating.ToString();
                    break;
                case "Film 4":
                    _currentFilm = _films[3];
                    NameOfFilmTextBox.Text = _currentFilm.Name.ToString();
                    DurationOfFilmTextBox.Text = _currentFilm.Duration.ToString();
                    YearOfFilmReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
                    GenreOfFilmTextBox.Text = _currentFilm.Genre.ToString();
                    RatingOfFilmTextBox.Text = _currentFilm.Rating.ToString();
                    break;
                case "Film 5":
                    _currentFilm = _films[4];
                    NameOfFilmTextBox.Text = _currentFilm.Name.ToString();
                    DurationOfFilmTextBox.Text = _currentFilm.Duration.ToString();
                    YearOfFilmReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
                    GenreOfFilmTextBox.Text = _currentFilm.Genre.ToString();
                    RatingOfFilmTextBox.Text = _currentFilm.Rating.ToString();
                    break;
            }
        }

        private void NameOfFIlmTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameOfFilmTextBox.Text;
            _films[FilmsListBox.SelectedIndex].Name = _currentFilm.Name;
        }

        private void DurationOfFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Duration = int.Parse(DurationOfFilmTextBox.Text.Replace('.', ','));
            }
            catch
            {
                DurationOfFilmTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            _films[FilmsListBox.SelectedIndex].Duration = _currentFilm.Duration;
            DurationOfFilmTextBox.BackColor = System.Drawing.Color.White;
        }

        private void YearOfFilmReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.YearOfRelease = int.Parse(YearOfFilmReleaseTextBox.Text.Replace('.', ','));
            }
            catch
            {
                YearOfFilmReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            _films[FilmsListBox.SelectedIndex].YearOfRelease = _currentFilm.YearOfRelease;
            YearOfFilmReleaseTextBox.BackColor = System.Drawing.Color.White;
        }

        private void GenreOfFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreOfFilmTextBox.Text;
            _films[FilmsListBox.SelectedIndex].Genre = _currentFilm.Genre;
        }

        private void RatingOfFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = double.Parse(RatingOfFilmTextBox.Text.Replace('.', ','));
            }
            catch
            {
                RatingOfFilmTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            _films[FilmsListBox.SelectedIndex].Rating = _currentFilm.Rating;
            RatingOfFilmTextBox.BackColor = System.Drawing.Color.White;
        }

        private int FindFilmWithMaxRating(Film[] _films)
        {
            double maxRating = _films[0].Rating;
            int indexOfMaxRating = 0;
            for (int i = 1; i < 5; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRating = _films[i].Rating;
                    indexOfMaxRating = i;
                }
            }
            return indexOfMaxRating;
        }

        private void FindFilmWithMaxRatingButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }
    }
}