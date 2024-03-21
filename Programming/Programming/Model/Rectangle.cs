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

        public double Width
        {
            get => _width;
            set
            {
                if (value < 0.0) throw new ArgumentException();
                _width = value;
            }
        }
        public double Length
        {
            get => _length;
            set
            {
                if (value < 0.0) throw new ArgumentException();
                _length = value;
            }
        }
        
        public Rectangle(double width, double length, string color)
        {
            Width = width;
            Length = length;
            Color = color;
        }
        public Rectangle() { }

        public object Clone()
        {
            return new Rectangle(Width, Length, Color);
        }
    }
}
