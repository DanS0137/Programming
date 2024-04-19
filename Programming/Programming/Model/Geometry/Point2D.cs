using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private int _coordinateX;
        private int _coordinateY;

        public int CoordinateX
        {
            get => _coordinateX;
            set
            {
                if (Validator.AssertOnNoNegativeValue(value, "Point2D.CoordinateX")) _coordinateX = value;
            }
        }
        public int CoordinateY
        {
            get => _coordinateY;
            set
            {
                if (Validator.AssertOnNoNegativeValue(value, "Point2D.CoordinateY")) _coordinateY = value;
            }
        }

        public Point2D(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
        public Point2D() { }
    }
}
