using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Хранит информацию о товарах в корзине покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров покупателя.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт список товаров покупателя.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает сумму цен товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0.0;
                if (_items.Count > 0)
                {
                    for (int i = 0; i < _items.Count; i++)
                    {
                        amount += _items[i].Cost;
                    }
                }
                return amount;
            }
        }

        /// <summary>
        /// Создаёт копию объекта класса <see cref="Cart"/>.
        /// </summary>
        /// <returns>Возвращает копию объекта. Объекты класса <see cref="Item"/> создаются новые.</returns>
        public object Clone()
        {
            Cart cart = new Cart();
            foreach(Item item in Items)
            {
                cart.Items.Add((Item)item.Clone());
            }
            return cart;
        }
    }
}
