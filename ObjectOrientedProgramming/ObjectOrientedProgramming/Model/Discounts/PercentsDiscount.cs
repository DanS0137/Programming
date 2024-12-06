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
    public class PercentsDiscount : IDiscount
    {
        /// <summary>
        /// Скидка в процентах.
        /// </summary>
        private int _discont = 0;
        /// <summary>
        /// Название категории.
        /// </summary>
        private Category _category = Category.Другое;
        /// <summary>
        /// Сумма приобретённых товаров этой категории.
        /// </summary>
        private double _summary = 0;

        /// <summary>
        /// Возвращает и задаёт значение скидки в процентах.
        /// Не может превышать 10.
        /// </summary>
        public int Discont
        {
            get => _discont;
            set
            {
                if (value > 10)
                {
                    _discont = 10;
                }
                else
                {
                    _discont = value;
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
            get => $"Процентная \"{Category}\" - {Discont}%";
        }

        /// <summary>
        /// Считает размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double amount = CalcAmount(items);
            double discont = amount * Discont / 100;
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
            double discont = amount * Discont / 100;

            if (Discont == 0) Summary += amount;
            else Summary += amount * (1.0 - Discont / 100.0);

            return discont;
        }
        /// <summary>
        /// Изменяет значение свойства <see cref="Discont"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            Discont = (int)Math.Truncate(Summary / 1000);
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
    }
}
