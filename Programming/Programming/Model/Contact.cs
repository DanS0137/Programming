using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные контакта.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        private int _phoneNumber;
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задаёт телефонный номер контакта. Должно быть числом с количеством цифр от 3 до 15 включительно.
        /// </summary>
        public int PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (Validator.AssertValueInRange(value.ToString().Length, 3, 15, "Contact.PhoneNumber")) _phoneNumber = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из букв латинского алфавита.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (Validator.AssertStringContainsOnlyLetters(value, "Contact.Name")) _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв латинского алфавита.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                if (Validator.AssertStringContainsOnlyLetters(value, "Contact.Surname")) _surname = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="phoneNumber">Телефонный номер. Число с количеством цифр от 3 до 15 включительно.</param>
        /// <param name="name">Имя. Должно состоять только из букв латинского алфавита.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв латинского алфавита.</param>
        public Contact(int phoneNumber, string name, string surname)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }
    }
}
