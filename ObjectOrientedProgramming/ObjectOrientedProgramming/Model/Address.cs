using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Services;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;
        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;
        /// <summary>
        /// Населённый пункт.
        /// </summary>
        private string _city;
        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;
        /// <summary>
        /// Номер здания.
        /// </summary>
        private string _building;
        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс адреса.
        /// Должен быть 6-значным целым числом.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 6, 6, "Address.Index");
                _index = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт страну/регион адреса.
        /// Должно быть не более 50 символов.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 50, "Address.Country");
                _country = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт населённый пункт адреса.
        /// Должно быть не более 50 символов.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 50, "Address.City");
                _city = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт улицу адреса.
        /// Должно быть не более 100 символов.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 100, "Address.Street");
                _street = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт номер здания адреса.
        /// Должно быть не более 10 символов.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 10, "Address.Building");
                _building = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения адреса.
        /// Должно быть не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 10, "Address.Apartment");
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. 6-значное целое число.</param>
        /// <param name="country">Название страны/региона. Должно быть не более 50 символов.</param>
        /// <param name="city">Название города. Должно быть не более 50 символов.</param>
        /// <param name="street">Название улицы. Должно быть не более 100 символов.</param>
        /// <param name="building">Номер здания. Должно быть не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Должно быть не более 10 символов.</param>
        public Address(int index, string country, string city, 
            string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        /// <summary>
        /// Создаёт объект класса <see cref="Address"/>.
        /// </summary>
        public Address() { }
    }
}
