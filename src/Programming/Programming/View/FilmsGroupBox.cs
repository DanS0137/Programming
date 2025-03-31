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
    public partial class FilmsGroupBox : UserControl
    {
        Film[] _films;
        Film _currentFilm;
        Random rnd = new Random();

        public FilmsGroupBox()
        {
            InitializeComponent();
            _films = new Film[5];
            for (int i = 0; i < 5; i++)
            {
                _films[i] = new Film();
                _films[i].YearOfRelease = rnd.Next(1900, 2025);
                _films[i].Duration = rnd.Next(1, 300);
                int rndRating = rnd.Next(11);
                if (rndRating != 10) _films[i].Rating = rndRating + Math.Round(rnd.NextDouble(), 2);
                else _films[i].Rating = 10;
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FilmsListBox.SelectedItem.ToString())
            {
                case "Film 1":
                    _currentFilm = _films[0];
                    break;
                case "Film 2":
                    _currentFilm = _films[1];
                    break;
                case "Film 3":
                    _currentFilm = _films[2];
                    break;
                case "Film 4":
                    _currentFilm = _films[3];
                    break;
                case "Film 5":
                    _currentFilm = _films[4];
                    break;
            }
            NameOfFilmTextBox.Text = _currentFilm.Name.ToString();
            DurationOfFilmTextBox.Text = _currentFilm.Duration.ToString();
            YearOfFilmReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
            GenreOfFilmTextBox.Text = _currentFilm.Genre.ToString();
            RatingOfFilmTextBox.Text = _currentFilm.Rating.ToString();
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

        #region Functions of text changes

        private void NameOfFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameOfFilmTextBox.Text;
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
            YearOfFilmReleaseTextBox.BackColor = System.Drawing.Color.White;
        }

        private void GenreOfFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreOfFilmTextBox.Text;
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
            RatingOfFilmTextBox.BackColor = System.Drawing.Color.White;
        }

        #endregion
    }
}
