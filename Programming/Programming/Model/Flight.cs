using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о полёте.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Возвращает и задаёт точку отправления.
        /// </summary>
        public string DeparturePoint { get; set; }
        /// <summary>
        /// Возвращает и задаёт точку прибытия.
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть целым положительным числом.
        /// </summary>
        public int FlightTime
        {
            get => _flightTime;
            set 
            {
                if (Validator.AssertOnPositiveValue(value, "Flight.FlightTime")) _flightTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>. Есть пустой конструктор.
        /// </summary>
        /// <param name="departurePoint">Точка отправления.</param>
        /// <param name="destination">Точка прибытия.</param>
        /// <param name="flightTime">Время полёта в минутах. Должно быть целым положительным числом.</param>
        public Flight (string departurePoint, string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }
        public Flight() { }
    }
}
