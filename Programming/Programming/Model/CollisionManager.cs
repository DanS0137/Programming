using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class CollisionManager
    {
        public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceInX = rectangle1.Centre.CoordinateX;
            double differenceInY = rectangle1.Centre.CoordinateY;
            if (differenceInX < (Math.Abs(rectangle1.Width - rectangle2.Width)/2) &&
                differenceInY < (Math.Abs(rectangle1.Length - rectangle2.Length)/2)) return true;
            else return false;
        }
        public bool IsCollision(Ring ring1, Ring ring2)
        {
            double differenceInX = ring1.Centre.CoordinateX;
            double differenceInY = ring1.Centre.CoordinateY;
            double distance = Math.Sqrt(Math.Pow(differenceInX, 2) + Math.Pow(differenceInY, 2));
            if (distance < (ring1.OuterRadius + ring2.OuterRadius)) return true;
            else return false;
        }
    }
}
