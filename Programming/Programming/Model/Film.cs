using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string Name { get; set; }
        private int _duration;
        private int _yearOfIssue;
        private string Genre { get; set; }
        private double _rating;

        public int Duration
        {
            get => _duration;
            set
            {
                if (value < 0) throw new ArgumentException();
                _duration = value;
            }
        }
        public int YearOfIssue
        {
            get => _yearOfIssue;
            set
            {
                if (value < 1900 || value > 2024) throw new ArgumentException();
                _yearOfIssue = value;
            }
        }
        public double Rating
        {
            get => _rating;
            set
            {
                if (value < 0.0 || value > 10.0) throw new ArgumentException();
                _rating = value;
            }
        }

        public Film(string name, int duration, int yearOfIssue, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearOfIssue = yearOfIssue;
            Genre = genre;
            Rating = rating;
        }
    }
}
