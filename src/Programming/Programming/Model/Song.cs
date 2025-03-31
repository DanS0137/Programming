using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задаёт исполнителя песни.
        /// </summary>
        public string Performer { get; set; }
        /// <summary>
        /// Длительность песни в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задаёт длительность песни в секундах. Должна быть целым положительным числом.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Song.Duration")) _duration = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="performer">Исполнитель песни.</param>
        /// <param name="duration">Длительность песни в секундах. Должна быть целым положительным числом.</param>
        public Song(string name, string performer, int duration)
        {
            Name = name;
            Performer = performer;
            Duration = duration;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song() { }
    }
}
