using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит данные о контакте, над которым работает пользователь.
        /// </summary>
        private Contact _contact = new Contact();

        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                _contact.Name = value;
                ThisPropertyChanged("Name");
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                _contact.PhoneNumber = value;
                ThisPropertyChanged("PhoneNumber");
            }
        }
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                _contact.Email = value;
                ThisPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Событие для сообщения о том, что какое-то свойство изменилось.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Метод для зажигания события <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">Название свойства, вызвавшего метод.</param>
        public void ThisPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
