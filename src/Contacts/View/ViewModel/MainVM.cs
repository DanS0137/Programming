using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит данные о том, редактируется ли контакт.
        /// </summary>
        private bool _isEditting = false;

        /// <summary>
        /// Хранит список контактов пользователя.
        /// </summary>
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        /// <summary>
        /// Хранит выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Хранит введённые пользоваетлем данные о контакте.
        /// </summary>
        private ContactVM _currentContact;

        /// <summary>
        /// Команда добавления нового контакта.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    SelectedContact = null;
                    Contact contact = new Contact();
                    contact.Name = "Имя контакта";
                    Contacts.Insert(0, contact);
                });
            }
        }

        /// <summary>
        /// Команда редактирования выбранного контакта.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return new RelayCommand(obj =>
                    {
                        if (SelectedContact != null)
                        { 
                            IsEditting = true; 
                        }
                    });
            }
        }

        /// <summary>
        /// Команда удаления выбранного контакта.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Contacts.Remove(SelectedContact);
                    SelectedContact = null;
                    CurrentContact = null;
                });
            }
        }

        /// <summary>
        /// Команда сохранения отредактированного контакта.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedContact == null) { return; }
                    Contacts[Contacts.IndexOf(SelectedContact)] = new Contact(CurrentContact.CurrentContact);
                    SelectedContact = null;
                    IsEditting = false;
                    CurrentContact = new ContactVM();
                });
            }
        }

        /// <summary>
        /// Команда загрузки контактов.
        /// </summary>
        public RelayCommand LoadCommand => new RelayCommand(obj =>
                                                          {
                                                              Contacts = ContactSerializer.LoadContacts();
                                                          });

        /// <summary>
        /// Команда сохранения контактов.
        /// </summary>
        public RelayCommand SaveCommand => new RelayCommand(obj =>
                                                           {
                                                              ContactSerializer.SaveContacts(Contacts);
                                                           });

        /// <summary>
        /// Возвращает и задаёт выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                if (value != null)
                {
                    IsEditting = false;
                    CurrentContact = new ContactVM(value);
                }
                else
                {
                    //CurrentContact = new Contact();
                }
                ThisPropertyChanged(nameof(SelectedContact));
            }
        }

        /// <summary>
        /// Задаёт и возвращает значение текущего контакта, над которым работает пользователь.
        /// </summary>
        public ContactVM CurrentContact
        {
            get { return _currentContact; }
            set
            {
                _currentContact = value;
                ThisPropertyChanged(nameof(CurrentContact));
            }
        }

        /// <summary>
        /// Возвращает и задаёт статус редактирования контакта.
        /// </summary>
        public bool IsEditting
        {
            get
            {
                return _isEditting;
            }
            set
            {
                _isEditting = value;
                if (CurrentContact != null)
                {
                    CurrentContact.IsEditting = true;
                }
                ThisPropertyChanged(nameof(IsEditting));
            }
        }

        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
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
