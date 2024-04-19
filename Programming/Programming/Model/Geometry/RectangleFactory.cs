using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal static class RectangleFactory
    {
        public static Rectangle Randomize(int height, int width)
        {
            Random random = new Random();
            int rndColor, rectangleWidth, rectangleLength, coordinateX, coordinateY;
            Point2D location;
            rndColor = random.Next(0, 8);
            rectangleWidth = random.Next(1, 100);
            rectangleLength = random.Next(1, 100);
            coordinateX = random.Next(15, width - 15 - rectangleWidth);
            coordinateY = random.Next(15, height - 15 - rectangleLength);
            Color rectangleColor = (Color)rndColor;
            string randomColor = rectangleColor.ToString();
            location = new Point2D(coordinateX, coordinateY);
            Rectangle newRectangle = new Rectangle(rectangleWidth, rectangleLength, randomColor, location);
            return newRectangle;
        }
    }
}
