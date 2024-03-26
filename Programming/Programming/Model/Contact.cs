using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private int _phoneNumber;
        private string _name;
        private string _surname;

        public int PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (Validator.AssertValueInRange(value.ToString().Length, 3, 15, "Contact.PhoneNumber")) _phoneNumber = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (AssertStringContainsOnlyLetters(value, "Contact.Name")) _name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (AssertStringContainsOnlyLetters(value, "Contact.Surname")) _surname = value;
            }
        }

        public Contact(int phoneNumber, string name, string surname)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
        }
        public Contact() { }

        private bool AssertStringContainsOnlyLetters(string value, string call)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!(value[i] > 64 && value[i] < 91 || value[i] > 96 && value[i] < 123))
                {
                    throw new ArgumentException($"Некорректное значение в поле {call}");
                }
            }
            return true;
        }
    }
}
