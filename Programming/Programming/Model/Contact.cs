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
        private string Name { get; set; }
        private string Organization { get; set; }

        public int PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.ToString().Length > 15 || value.ToString().Length < 3) throw new ArgumentException();
                _phoneNumber = value;
            }
        }

        public Contact(int phoneNumber, string name, string organization)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Organization = organization;
        }
        public Contact() { }
    }
}
