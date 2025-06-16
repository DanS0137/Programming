using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModel
{
    public partial class ContactVM : ObservableObject
    {
        /// <summary>
        /// Хранит информацию о контакте, над которым работает пользователь.
        /// </summary>
        [ObservableProperty]
        private Contact _currentContact;

        /// <summary>
        /// Хранит информацию о том, возможно ли сейчас редактирование контакта.
        /// </summary>
        [ObservableProperty]
        private bool _isEditting;

        /// <summary>
        /// Создаёт объект класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            CurrentContact = new Contact(contact);
            IsEditting = false;
        }

        /// <summary>
        /// Создаёт объект класса <see cref="ContactVM"/>.
        /// </summary>
        public ContactVM()
        {
            CurrentContact = new Contact();
            IsEditting = false;
        }
    }
}
