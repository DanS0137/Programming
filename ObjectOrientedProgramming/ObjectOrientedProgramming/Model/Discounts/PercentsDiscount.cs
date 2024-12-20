using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Model;
using ObjectOrientedProgramming.Model.Enumerations;

namespace ObjectOrientedProgramming.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о процентной скидке на категорию товаров.
    /// </summary>
    public class PercentsDiscount : IDiscount, IComparable<PercentsDiscount>
    {
        /// <summary>
        /// Скидка в процентах.
        /// </summary>
        private int _discount = 0;
        /// <summary>
        /// Название категории.
        /// </summary>
        private Category _category = Category.Attack;
        /// <summary>
        /// Сумма приобретённых товаров этой категории.
        /// </summary>
        private double _summary = 0;

        /// <summary>
        /// Возвращает и задаёт значение скидки в процентах.
        /// Не может превышать 10.
        /// </summary>
        public int Discount
        {
            get => _discount;
            set
            {
                if (value > 10)
                {
                    _discount = 10;
                }
                else
                {
                    _discount = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задаёт категорию товаров со скидкой.
        /// </summary>
        public Category Category
        {
            get => _category;
            set => _category = value;
        }
        /// <summary>
        /// Возвращает и задаёт сумму приобретённых товаров категории,
        /// на которую есть скидка.
        /// </summary>
        public double Summary
        {
            get => _summary;
            set => _summary = value;
        }
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"Процентная \"{Category}\" - {Discount}%";
        }

        /// <summary>
        /// Считает размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double amount = CalcAmount(items);
            double discont = amount * Discount / 100;
            return discont;
        }
        /// <summary>
        /// Считает размер скидки и изменяет значение свойства <see cref="Summary"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double amount = CalcAmount(items);
            double discont = amount * Discount / 100;

            if (Discount == 0) Summary += amount;
            else Summary += amount * (1.0 - Discount / 100.0);

            return discont;
        }
        /// <summary>
        /// Изменяет значение свойства <see cref="Discount"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            Discount = (int)Math.Truncate(Summary / 20000);
        }
        /// <summary>
        /// Считает стоимость товаров скидочной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        private double CalcAmount(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }
            return amount;
        }

        /// <summary>
        /// Сравнивает два объекта класса <see cref="PercentsDiscount"/>.
        /// </summary>
        /// <param name="disc">Объект для сравнения.</param>
        /// <returns> Возвращает -2, если передаваемый объект равен null.
        /// Возвращает -1, если значение <see cref="Discount"/> передаваемого объекта больше.
        /// Возвращает 0, если значения равны.
        /// Возвращает 1, если значение меньше.</returns>
        public int CompareTo(PercentsDiscount disc)
        {
            if (disc == null)
                return -2;
            if (disc.Discount == Discount)
                return 0;
            if (disc.Discount > Discount)
                return -1;
            else
                return 1;
        }
    }
}
