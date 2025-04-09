using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private bool wasAdded = true;
        /// <summary>
        /// Хранит данные о контакте, над которым работает пользователь.
        /// </summary>
        private Contact _currentContact = new Contact();

        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        private int _selectedIndex;

        //private LoadCommand loadCommand;

        //private SaveCommand saveCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    SelectedIndex = -1;
                    wasAdded = true;
                });
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {

                });
            }
        }
        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Contacts.Remove(_currentContact);
                    Name = "";
                    PhoneNumber = "";
                    Email = "";
                });
            }
        }
        public RelayCommand ApplyCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (wasAdded)
                    {
                        Contacts.Add(new Contact(Name, PhoneNumber, Email));
                        wasAdded = false;
                    }
                    else
                    {
                        Contacts[_selectedIndex].Name = Name;
                        Contacts[_selectedIndex].PhoneNumber = PhoneNumber;
                        Contacts[_selectedIndex].Email = Email;
                    }
                    SelectedIndex = -1;
                });
            }
        }

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (value != -1)
                {
                    _selectedIndex = value;
                    Name = Contacts[value].Name;
                    PhoneNumber = Contacts[value].PhoneNumber;
                    Email = Contacts[value].Email;
                }
                else if (value == -1)
                {
                    Name = "";
                    PhoneNumber = "";
                    Email = "";
                }
                ThisPropertyChanged("SelectedIndex");
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _currentContact.Name;
            }
            set
            {
                _currentContact.Name = value;
                ThisPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Возвращает и задаёт телефонный номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _currentContact.PhoneNumber;
            }
            set
            {
                _currentContact.PhoneNumber = value;
                ThisPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// Возвращает и задаёт email контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _currentContact.Email;
            }
            set
            {
                _currentContact.Email = value;
                ThisPropertyChanged("Email");
            }
        }

        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                ThisPropertyChanged("Contacts");
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
