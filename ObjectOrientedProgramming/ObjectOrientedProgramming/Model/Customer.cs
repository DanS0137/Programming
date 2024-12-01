using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Все использованные уникальные идентификаторы.
        /// </summary>
        private static List<int> _allIds = new List<int>();

        /// <summary>
        /// Количество покупателей.
        /// </summary>
        private static int _allCustomers;

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullName = "";

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов пользователя.
        /// </summary>
        private List<Order> _orders;

        public int Id
        {
            get => _id;
        }
        /// <summary>
        /// Возвращает и задаёт полное имя покупателя.
        /// Должно состоять менее чем из 200 символов.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200, "Customer.FullName");
                _fullName = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт адрес доставки для покупателя.
        /// Должно состоять менее чем из 500 символов.
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
        /// Возвращает и задаёт товары в корзине покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">ФИО. Должно быть меньше 200 символов.</param>
        /// <param name="index">Почтовый индекс для доставки. Должен быть 6-значным целым числом.</param>
        /// <param name="country">Страна для доставки. Должно быть равно или меньше 50 символов.</param>
        /// <param name="city">Город для доставки. Должно быть равно или меньше 50 символов.</param>
        /// <param name="street">Улица для доставки. Должно быть равно или меньше 100 символов.</param>
        /// <param name="building">Номер здания для доставки. Должно быть равно или меньше 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения для доставки. Должно быть равно или меньше 10 символов.</param>
        public Customer(string fullName, int index, string country, string city,
            string street, string building, string apartment)
        {
            while (_allIds.Contains(_allCustomers)) _allCustomers += 1;
            _id = _allCustomers;
            _allCustomers += 1;
            FullName = fullName;
            Address = new Address(index, country, city, street, building, apartment);
            Cart = new Cart();
            Orders = new List<Order>();
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="id">Уникальный идентификатор. Уникальность не проверяется.</param>
        /// <param name="fullName">ФИО. Должно быть меньше 200 символов.</param>
        /// <param name="index">Почтовый индекс для доставки. Должен быть 6-значным целым числом.</param>
        /// <param name="country">Страна для доставки. Должно быть равно или меньше 50 символов.</param>
        /// <param name="city">Город для доставки. Должно быть равно или меньше 50 символов.</param>
        /// <param name="street">Улица для доставки. Должно быть равно или меньше 100 символов.</param>
        /// <param name="building">Номер здания для доставки. Должно быть равно или меньше 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения для доставки. Должно быть равно или меньше 10 символов.</param>
        public Customer(int id, string fullName, int index, string country, string city,
            string street, string building, string apartment)
        {
            _id = id;
            FullName = fullName;
            Address = new Address(index, country, city, street, building, apartment);
            Cart = new Cart();
            Orders = new List<Order>();
            _allIds.Add(id);
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            while (_allIds.Contains(_allCustomers)) _allCustomers += 1;
            _id = _allCustomers;
            _allCustomers += 1;
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}
