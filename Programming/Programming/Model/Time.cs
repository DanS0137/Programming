using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о времени суток.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;
        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задаёт количество часов. Должно быть целым числом от 0 до 23 включительно.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                if (Validator.AssertValueInRange(value, 0, 23, "Time.Hours")) _hours = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт количество минут. Должно быть целым числом от 0 до 59 включительно.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                if (Validator.AssertValueInRange(value, 0, 59, "Time.Minutes")) _minutes = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт количество секунд. Должно быть целым числом от 0 до 59 включительно.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                if (Validator.AssertValueInRange(value, 0, 59, "Time.Seconds")) _seconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>. Есть пустой конструктор.
        /// </summary>
        /// <param name="hours">Количество часов. Должно быть целым числом от 0 до 23 включительно.</param>
        /// <param name="minutes">Количество минут. Должно быть целым числом от 0 до 59 включительно.</param>
        /// <param name="seconds">Количество секунд. Должно быть целым числом от 0 до 59 включительно.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time() { }
    }
}
