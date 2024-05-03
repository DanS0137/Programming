using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о геометричесокй фигуре "кольцо".
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;
        /// <summary>
        /// Возвращает и задаёт координаты центра кольца. Должны быть объектом класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Centre { get; set; }
        /// <summary>
        /// Общее количество созданных экземпляров класса.
        /// </summary>
        private static int _allRingsCount;
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает вычисленное значение площади кольца.
        /// </summary>
        public double Area
        {
            get
            {
                 return Math.PI * Math.Pow(_outerRadius, 2) - Math.PI * Math.Pow(_innerRadius, 2);
            }
        }
        /// <summary>
        /// Возвращает и задаёт внутренний радиус кольца. Должен быть целым положительным числом и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Ring.InnerRadius") && value < OuterRadius) _innerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт внешний радиус кольца. Должен быть целым положительным числом и больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Ring.OuterRadius") && value > InnerRadius) _outerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает общее количество созданных экземпляров класса.
        /// </summary>
        public int AllRingsCount
        {
            get => _allRingsCount;
        }
        /// <summary>
        /// Возвращает уникальный идентификатор объекта.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="innerRadius">Внутренний радиус кольца. Должен быть целым положительным числом и меньше внешнего радиуса.</param>
        /// <param name="outerRadius">Внешний радиус кольца. Должен быть целым положительным числом и больше внутреннего радиуса.</param>
        public Ring(double innerRadius, double outerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            _id = AllRingsCount;
            _allRingsCount += 1;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring() 
        {
            _id = AllRingsCount;
            _allRingsCount += 1;
        }
    }
}
