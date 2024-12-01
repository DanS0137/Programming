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
    public class Order
    {
        /// <summary>
        /// Сумма всех заказов.
        /// </summary>
        private static int _allOrders = 0;
        /// <summary>
        /// Все id-шники, использованные при сохранении файлов.
        /// </summary>
        private static List<int> _allIds;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        private readonly DateTime _dateOfCreation;
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Состав заказа.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Сумма заказа.
        /// </summary>
        private double _amount = 0;
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
                foreach (Item item in _items)
                {
                    Amount += item.Cost;
                }
            }
        }
        /// <summary>
        /// Возвращает сумму заказа.
        /// </summary>
        public double Amount
        {
            get => _amount;
            private set
            {
                _amount = value;
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
            Items = items;
            _dateOfCreation = DateTime.Now;
            _id = _allOrders + 1;
            _allOrders += 1;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _dateOfCreation = DateTime.Now;
            _id += _allOrders + 1;
            _allOrders += 1;
        }

        /// <summary>
        /// Добавляет товар в список товаров.
        /// </summary>
        /// <param name="item">Добавляемый товар.</param>
        public void AddItem(Item item)
        {
            _items.Add(item);
            Amount += item.Cost;
        }
    }
}
