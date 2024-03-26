using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private double _coordinateX;
        private double _coordinateY;

        public double CoordinateX
        {
            get => _coordinateX;
            private set
            {
                if (Validator.AssertValueInRange(value, -20.0, 20.0, "Point2D.CoordinateX")) _coordinateX = value;
            }
        }
        public double CoordinateY
        {
            get => _coordinateY;
            private set
            {
                if (Validator.AssertValueInRange(value, -20.0, 20.0, "Point2D.CoordinateY")) _coordinateY = value;
            }
        }

        public Point2D(double coordinateX, double coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
