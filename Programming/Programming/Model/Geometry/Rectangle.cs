using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _length;
        private static int _allRectanglesCount;
        private readonly int _id;
        public string Color { get; set; }
        public Point2D Location { get; set; }

        public int Width
        {
            get => _width;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Rectangle.Width")) _width = value;
            }
        }
        public int Length
        {
            get => _length;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Rectangle.Length")) _length = value;
            }
        }
        public int AllRectanglesCount
        {
            get => _allRectanglesCount;
        }
        public int Id
        {
            get => _id;
        }
        
        public Rectangle(int width, int length, string color, Point2D location)
        {
            Width = width;
            Length = length;
            Color = color;
            Location = location;
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
        public Rectangle() 
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
    }
}
