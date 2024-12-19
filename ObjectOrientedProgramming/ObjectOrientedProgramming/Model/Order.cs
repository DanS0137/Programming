using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    [Serializable]
    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Сумма всех заказов.
        /// </summary>
        protected static int _allOrders = 0;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        protected readonly DateTime _dateOfCreation;
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        protected readonly int _id;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Состав заказа.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Статус заказа.
        /// </summary>
        private Enumerations.OrderStatus _orderStatus;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get => _id;
        }
        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Возвращает список товаров в заказе. Добавить предмет в заказ можно,
        /// используя метод AddItem().
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
        /// Возвращает сумму заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null) return -1;
                double amount = 0;
                foreach(Item item in Items)
                {
                    amount += item.Cost;
                }
                return amount;
            }
        }
        /// <summary>
        /// Возвращает время создания заказа.
        /// </summary>
        public DateTime DateOfCreation
        {
            get => _dateOfCreation;
        }
        /// <summary>
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public Enumerations.OrderStatus OrderStatus
        {
            get => _orderStatus;
            set
            {
                _orderStatus = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки заказа.</param>
        /// <param name="items">Список содержимого заказа.</param>
        public Order(Address address, List<Item> items)
        {
            Address = address;
            foreach (Item item in items)
            {
                Items.Add((Item)item.Clone());
            }
            _dateOfCreation = DateTime.Now;
            _id = _allOrders++;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _dateOfCreation = DateTime.Now;
            _id = _allOrders;
            _allOrders += 1;
        }

        /// <summary>
        /// Сравнивает объекты класса <see cref="Order"/>.
        /// </summary>
        /// <param name="order">Объект для сравнения.</param>
        /// <returns>Возвращает false, если передаваемый объект равен null или его <see cref="Id"/> не совпадает.
        /// Возвращает true, если их <see cref="Id"/> совпадают.</returns>
        public bool Equals(Order order)
        {
            if (order == null)
                return false;
            if (Id == order.Id)
                return true;
            else
                return false;
        }
    }
}
