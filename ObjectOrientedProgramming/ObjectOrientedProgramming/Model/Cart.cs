using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Хранит информацию о товарах в корзине покупателя.
    /// </summary>
    public class Cart
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
    }
}
