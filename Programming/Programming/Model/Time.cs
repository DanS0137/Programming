using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get => _hours;
            set
            {
                if (Validator.AssertValueInRange(value, 0, 23, "Time.Hours")) _hours = value;
            }
        }
        public int Minutes
        {
            get => _minutes;
            set
            {
                if (Validator.AssertValueInRange(value, 0, 59, "Time.Minutes")) _minutes = value;
            }
        }
        public int Seconds
        {
            get => _seconds;
            set
            {
                if (Validator.AssertValueInRange(value, 0, 59, "Time.Seconds")) _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time() { }
    }
}
