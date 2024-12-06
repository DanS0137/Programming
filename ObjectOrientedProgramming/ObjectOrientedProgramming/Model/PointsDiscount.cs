using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Model
{
    public class PointsDiscount
    {
        private int _points;

        public int Points
        {
            get => _points;
            private set => _points = value;
        }

        public string Info
        {
            get => $"Накопительная - {_points} баллов.";
        }

        public double Calculate (List<Item> items)
        {
            double amount = 0;
            foreach(Item item in items)
            {
                amount += item.Cost;
            }
            int maxDiscount = (int)Math.Truncate(0.3 * amount);
            if (Points >= maxDiscount)
            {
                return maxDiscount;
            }
            else
            {
                return Points;
            }
        }

        public double Apply (List<Item> items)
        {
            int discount = (int)Calculate(items);
            Points -= discount;
            return discount;
        }

        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            Points += (int)Math.Ceiling(0.1 * amount);
        }
    }
}
