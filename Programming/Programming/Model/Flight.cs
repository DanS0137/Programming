using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        private string DeparturePoint { get; set; }
        private string Destination { get; set; }
        private int _flightTime;

        public int FlightTime
        {
            get => _flightTime;
            set 
            {
                if (value < 0) throw new ArgumentException();
                _flightTime = value;
            }
        }

        public Flight (string departurePoint, string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }
        public Flight() { }
    }
}
