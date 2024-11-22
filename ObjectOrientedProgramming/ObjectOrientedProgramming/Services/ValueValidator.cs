using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Services
{
    static class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength) throw new 
                    ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
        }

        public static void AssertStringOnLength(string value, int minLength, int maxLength, string propertyName)
        {
            if (value.Length > maxLength || value.Length < minLength) throw new 
                    ArgumentException($"{propertyName} должен быть меньше или равен {maxLength} и больше или равен {minLength} символов.");
        }
    }
}
