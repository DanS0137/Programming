using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о геометрической фигуре "прямоугольник".
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _length;
        /// <summary>
        /// Общее количество созданных экземпляров класса.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Возвращает или задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Возвращает или задаёт координаты верхнего левого угла прямоугольника. Должны быть объектом класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Location { get; set; }

        /// <summary>
        /// Возвращает или задаёт ширину прямоугольника. Должна быть целым положительным числом.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Rectangle.Width")) _width = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт длину прямоугольника. Должна быть целым положительным числом.
        /// </summary>
        public int Length
        {
            get => _length;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Rectangle.Length")) _length = value;
            }
        }
        /// <summary>
        /// Возвращает общее количество созданных экземпляров класса.
        /// </summary>
        public int AllRectanglesCount
        {
            get => _allRectanglesCount;
        }
        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="width">Ширина прямоугольника. Должна быть целым положительным числом.</param>
        /// <param name="length">Длина прямоугольника. Должна быть целым положительным числом.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="location">Координаты верхнего левого угла прямоугольника. Должны быть объектом класса <see cref="Point2D"/>.</param>
        public Rectangle(int width, int length, string color, Point2D location)
        {
            Width = width;
            Length = length;
            Color = color;
            Location = location;
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle() 
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
    }
}
