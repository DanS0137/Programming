using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит координаты точки.
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// Координата точки по оси X.
        /// </summary>
        private int _coordinateX;
        /// <summary>
        /// Координата точки по оси Y.
        /// </summary>
        private int _coordinateY;

        /// <summary>
        /// Возвращает и задаёт координату точки по оси X. Должна быть целым неотрицательным числом.
        /// </summary>
        public int CoordinateX
        {
            get => _coordinateX;
            set
            {
                if (Validator.AssertOnNoNegativeValue(value, "Point2D.CoordinateX")) _coordinateX = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт координату точки по оси Y. Должна быть целым неотрицательным числом.
        /// </summary>
        public int CoordinateY
        {
            get => _coordinateY;
            set
            {
                if (Validator.AssertOnNoNegativeValue(value, "Point2D.CoordinateY")) _coordinateY = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="coordinateX">Координата точки по оси X. Должна быть целым неотрицательным числом.</param>
        /// <param name="coordinateY">Координата точки по оси Y. Должна быть целым неотрицательным числом.</param>
        public Point2D(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D() { }
    }
}
