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
    class Customer
    {
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
        private string _fullName;
        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private string _address;

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
        public string Address
        {
            get => _address;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 500, "Customer.Address");
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО. Должно быть меньше 200 символов.</param>
        /// <param name="address">Адрес доставки. Должен бфть меньше 500 символов.</param>
        public Customer(string fullName, string address)
        {
            _id = _allCustomers;
            _allCustomers += 1;
            FullName = fullName;
            Address = address;
        }
    }
}
