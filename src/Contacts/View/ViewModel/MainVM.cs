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

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private bool wasAdded = true;

        private bool _isEditting = false;
        /// <summary>
        /// Хранит данные о контакте, над которым работает пользователь.
        /// </summary>
        private Contact _currentContact = new Contact();

        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        private int _selectedIndex;

        public bool Visibility
        {
            get
            {
                return IsEditting;
            }
        }

        public bool IsEnabled
        {
            get
            {
                return !IsEditting;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return !IsEditting;
            }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    SelectedIndex = -1;
                    Contact cont = new Contact();
                    cont.Name = "Имя контакта";
                    Contacts.Insert(0, cont);
                });
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                if (SelectedIndex != -1)
                {
                    return new RelayCommand(obj =>
                    {
                        IsEditting = true;
                    });
                }
                else
                {
                    return null;
                }
            }
        }
        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Contacts.RemoveAt(SelectedIndex);
                    SelectedIndex = -1;
                });
            }
        }
        public RelayCommand ApplyCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (_selectedIndex == -1) { return; }
                    IsEditting = false;
                    Contacts[_selectedIndex] = new Contact(Name, PhoneNumber, Email);
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
                    IsEditting = false;
                    Name = Contacts[value].Name;
                    PhoneNumber = Contacts[value].PhoneNumber;
                    Email = Contacts[value].Email;
                }
                else
                {
                    Name = "";
                    PhoneNumber = "";
                    Email = "";
                }
                _selectedIndex = value;
                ThisPropertyChanged(nameof(SelectedIndex));
            }
        }

        public bool IsEditting
        {
            get
            {
                return _isEditting;
            }
            set
            {
                _isEditting = value;
                ThisPropertyChanged(nameof(IsEnabled));
                ThisPropertyChanged(nameof(IsReadOnly));
                ThisPropertyChanged(nameof(Visibility));
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
                ThisPropertyChanged(nameof(Name));
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
                ThisPropertyChanged(nameof(PhoneNumber));
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
                ThisPropertyChanged(nameof(Email));
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
                ThisPropertyChanged(nameof(Contacts));
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
