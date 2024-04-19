using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private double _innerRadius;
        private double _outerRadius;
        public Point2D Centre { get; set; }
        private static int _allRingsCount;
        private int _id;

        public double Area
        {
            get
            {
                 return Math.PI * Math.Pow(_outerRadius, 2) - Math.PI * Math.Pow(_innerRadius, 2);
            }
        }
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Ring.InnerRadius") && value < OuterRadius) _innerRadius = value;
            }
        }
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Ring.OuterRadius") && value > InnerRadius) _outerRadius = value;
            }
        }
        public int AllRingsCount
        {
            get => _allRingsCount;
        }
        public int Id
        {
            get => _id;
        }

        public Ring(double innerRadius, double outerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            _id = AllRingsCount;
            _allRingsCount += 1;
        }
        public Ring() 
        {
            _id = AllRingsCount;
            _allRingsCount += 1;
        }
    }
}
