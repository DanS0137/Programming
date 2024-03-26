using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static internal class Validator
    {
        static public bool AssertOnPositiveValue(int value, string call)
        {
            if (value <= 0) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        static public bool AssertOnPositiveValue(double value, string call)
        {
            if (value <= 0.0) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        static public bool AssertValueInRange(int value, int min, int max, string call) 
        {
            if (value < min || value > max) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        static public bool AssertValueInRange(double value, double min, double max, string call)
        {
            if (value < min || value > max) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
    }
}