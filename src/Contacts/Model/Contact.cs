using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Windows;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        [JsonIgnore]
        private static string _symbols = "0123456789+-()";
        //[JsonIgnore]
        //public static readonly DependencyProperty NameProperty;
        //[JsonIgnore]
        //public static readonly DependencyProperty EmailProperty;
        //[JsonIgnore]
        //public static readonly DependencyProperty PhoneNumberProperty;
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
        [JsonIgnore]
        public string Error => throw new NotImplementedException();

        public string this[string propertyName]
        {
            get
            {
                string error = "";
                switch (propertyName)
                {
                    case "Name":
                        if (Name.Length > 100)
                        {
                            error = "Длина имени не должна превышать 100 символов";
                            Name = Name.Substring(0, 100);
                        }
                        break;
                    case "Email":
                        if (Email.Length > 100)
                        {
                            error = "Длина email не должна превышать 100 символов.";
                            Email = Email.Substring(0, 100);
                        }
                        else if (!Email.Contains('@'))
                        {
                            error = "Email должен содержать символ '@'.";
                            Email = "";
                        }
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber.Length > 100)
                        {
                            error = "Длина телефонного номера не должна превышать 100 символов.";
                            PhoneNumber = PhoneNumber.Substring(0, 100);
                        }
                        else
                        {
                            foreach(char symbol in PhoneNumber)
                            {
                                if (!_symbols.Contains(symbol))
                                {
                                    error = "Телефонный номер может содержать только цифры и символы '+()-'.";
                                    PhoneNumber = PhoneNumber.Replace(symbol.ToString(), "");
                                }
                            }
                        }
                        break;
                }
                return error;
            }
        }

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
            Email = "@";
        }

        public Contact(Contact contact)
        {
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ThisPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return Name;
        }
    }
}