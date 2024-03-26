using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string _name = "";
        private int _duration;
        private int _yearOfRelease;
        private string _genre = "";
        private double _rating;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
            }
        }
        public int Duration
        {
            get => _duration;
            set
            {
                if(Validator.AssertOnPositiveValue(value, "Film.Duration")) _duration = value;
            }
        }
        public int YearOfRelease
        {
            get => _yearOfRelease;
            set
            {
                if (Validator.AssertValueInRange(value, 1900, 2024, "Film.YearOfRelease")) _yearOfRelease = value;
            }
        }
        public double Rating
        {
            get => _rating;
            set
            {
                if (Validator.AssertValueInRange(value, 0.0, 59.0, "Film.Rating")) _rating = value;
            }
        }

        public Film(string name, int duration, int yearOfIssue, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfIssue;
            Genre = genre;
            Rating = rating;
        }
        public Film() { }
    }
}
