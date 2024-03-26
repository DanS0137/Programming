using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _width;
        private double _length;
        public string Color { get; set; }
        public Point2D Centre { get; set; }

        public double Width
        {
            get => _width;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Rectangle.Width")) _width = value;
            }
        }
        public double Length
        {
            get => _length;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Rectangle.Length")) _length = value;
            }
        }
        
        public Rectangle(double width, double length, string color, Point2D centre)
        {
            Width = width;
            Length = length;
            Color = color;
            Centre = centre;
        }
        public Rectangle() { }
    }
}
