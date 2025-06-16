using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Model;
using ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModel
{
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит данные о том, редактируется ли контакт.
        /// </summary>
        private bool _isEditting = false;

        /// <summary>
        /// Хранит список контактов пользователя.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        /// <summary>
        /// Хранит выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Хранит введённые пользоваетлем данные о контакте.
        /// </summary>
        [ObservableProperty]
        private ContactVM _currentContact;

        /// <summary>
        /// Команда добавления контакта в список контактов.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            SelectedContact = null;
            Contact contact = new Contact();
            contact.Name = "Имя контакта";
            Contacts.Insert(0, contact);
        }

        /// <summary>
        /// Команда, включающая/отключающая возможность редактирования текущего контакта.
        /// </summary>
        [RelayCommand]
        private void EditContact()
        {
            if (SelectedContact != null)
            {
                IsEditting = true;
            }
        }

        /// <summary>
        /// Команда удаления выбранного контакта из списка контактов.
        /// </summary>
        [RelayCommand]
        private void RemoveContact()
        {
            Contacts.Remove(SelectedContact);
            SelectedContact = null;
            CurrentContact = null;
        }

        /// <summary>
        /// Команда сохранения изменённого контакта в список контактов.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            if (SelectedContact == null) { return; }
            Contacts[Contacts.IndexOf(SelectedContact)] = new Contact(CurrentContact.CurrentContact);
            SelectedContact = null;
            IsEditting = false;
            CurrentContact = new ContactVM();
        }

        /// <summary>
        /// Команда загрузки списка контактов из папки, хранящей его.
        /// </summary>
        [RelayCommand]
        private void LoadContacts()
        {
            Contacts = ContactSerializer.LoadContacts();
            CurrentContact = new ContactVM();
            CurrentContact.IsEditting = false;
        }

        /// <summary>
        /// Команда сохранения контактов в папку.
        /// </summary>
        [RelayCommand]
        private void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

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
                OnPropertyChanged(nameof(SelectedContact));
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
                OnPropertyChanged(nameof(IsEditting));
            }
        }
    }
}
