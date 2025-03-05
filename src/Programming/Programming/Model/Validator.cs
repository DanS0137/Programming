using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Проверяет корректность введёного значения.
    /// </summary>
    static internal class Validator
    {
        /// <summary>
        /// Проверяет является ли целое число положительным.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="call">Место вызова метода.</param>
        /// <returns>Возвращает true, если число положительно, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertOnPositiveValue(int value, string call)
        {
            if (value <= 0) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        /// <summary>
        /// Проверяет является ли вещественное число положительным.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="call">Место вызова метода.</param>
        /// <returns>Возвращает true, если число положительно, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertOnPositiveValue(double value, string call)
        {
            if (value <= 0.0) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        /// <summary>
        /// Проверяет является ли целое число неотрицательным.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="call">Место вызова метода.</param>
        /// <returns>Возвращает true, если число неотрицательно, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertOnNoNegativeValue(int value, string call)
        {
            if (value < 0) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        /// <summary>
        /// Проверяет является ли вещественное число неотрицательным.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="call">Место вызова метода.</param>
        /// <returns>Возвращает true, если число неотрицательно, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertOnNoNegativeValue(double value, string call)
        {
            if (value < 0.0) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        /// <summary>
        /// Проверяет находится ли целое число в указанном диапозоне.
        /// </summary>
        /// <param name="value">Проверяемое целое число.</param>
        /// <param name="min">Нижняя граница диапозона.</param>
        /// <param name="max">Верхняя граница диапозона.</param>
        /// <param name="call">Место вызова метода.</param>
        /// <returns>Возвращает true, если число находится внутри указанного диапозона, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertValueInRange(int value, int min, int max, string call) 
        {
            if (value < min || value > max) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        /// <summary>
        /// Проверяет находится ли вещественное число в указанном диапозоне.
        /// </summary>
        /// <param name="value">Проверяемое вещественное число.</param>
        /// <param name="min">Нижняя граница диапозона.</param>
        /// <param name="max">Верхняя граница диапозона.</param>
        /// <param name="call">Место вызова метода.</param>
        /// <returns>Возвращает true, если число находится внутри указанного диапозона, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertValueInRange(double value, double min, double max, string call)
        {
            if (value < min || value > max) throw new ArgumentException($"Некорректное значение в поле {call}");
            else return true;
        }
        /// <summary>
        /// Проверяет состоит ли строка только из символов латинского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="call">Строка, содержащая место, откуда был вызван метод.</param>
        /// <returns>Возвращает true, если строка состоит из букв латинского алфавита, иначе вызывает исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        static public bool AssertStringContainsOnlyLetters(string value, string call)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!(value[i] > 64 && value[i] < 91 || value[i] > 96 && value[i] < 123))
                {
                    throw new ArgumentException($"Некорректное значение в поле {call}");
                }
            }
            return true;
        }
    }
}