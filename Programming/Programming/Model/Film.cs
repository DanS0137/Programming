using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    internal class Film
    {
        /// <summary>
        /// Название фильма. 
        /// </summary>
        private string _name = "";
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _duration;
        /// <summary>
        /// Год выхода фильма от Рождества Христова.
        /// </summary>
        private int _yearOfRelease;
        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre = "";
        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт продолжительность фильма. Должна быть целым числом от 0 до 51421 включительно.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                if(Validator.AssertValueInRange(value, 0, 51421, "Film.Duration")) _duration = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт год выхода фильма. Должен быть целым числом от 1900 до 2024 включительно.
        /// </summary>
        public int YearOfRelease
        {
            get => _yearOfRelease;
            set
            {
                if (Validator.AssertValueInRange(value, 1900, 2024, "Film.YearOfRelease")) _yearOfRelease = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть вещественным числом от 0.0 до 10.0 включительно.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                if (Validator.AssertValueInRange(value, 0.0, 10.0, "Film.Rating")) _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film">.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма. Должна быть целым числом от 0 до 51421 включительно.</param>
        /// <param name="yearOfIssue">Год выхода фильма. Должен быть целым числом от 1900 до 2024 включительно.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть вещественным числом от 0.0 до 10.0 включительно.</param>
        public Film(string name, int duration, int yearOfIssue, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfIssue;
            Genre = genre;
            Rating = rating;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film">.
        /// </summary>
        public Film() { }
    }
}
