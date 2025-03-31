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
        /// Принимает и возвращает имя контакта.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращет и задаёт email контакта.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Возвращает и задаёт телефонный номер контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Телефонный номер контакта.</param>
        /// <param name="email">Email контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        /// <summary>
        /// Пустой конструктор класса <see cref="Contact"/>.
        /// Применяется для работы сериализатора.
        /// </summary>
        public Contact() 
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }
    }
}