using System;
using System.Collections.Generic;
namespace ObjectOrientedProgramming.Model.Discounts
{
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private int _points;

        public int Points
        {
            get => _points;
            set => _points = value;
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

        /// <summary>
        /// Сравнивает два объекта класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="disc">Объект для сравнения.</param>
        /// <returns> Возвращает -2, если передаваемый объект равен null.
        /// Возвращает -1, если значение <see cref="Points"/> передаваемого объекта больше.
        /// Возвращает 0, если значения равны.
        /// Возвращает 1, если значение меньше.</returns>
        public int CompareTo(PointsDiscount disc)
        {
            if (disc == null)
                return -2;
            if (disc.Points == Points)
                return 0;
            if (disc.Points > Points)
                return -1;
            else
                return 1;
        }
    }
}
