using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Email контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт телефонный номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт email контакта.
        /// </summary>
        public string Email
        {
            get 
            { 
                return _email; 
            }
            set 
            { 
                _email = value; 
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Телефонный номер контакта.</param>
        /// <param name="email">Email контакта.</param>
        Contact(string name, string phoneNumber, string email)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
        }
        /// <summary>
        /// Пустой конструктор класса <see cref="Contact"/>.
        /// Применяется для работы сериализатора.
        /// </summary>
        Contact() 
        {
            _name = "";
            _phoneNumber = "";
            _email = "";
        }
    }
}