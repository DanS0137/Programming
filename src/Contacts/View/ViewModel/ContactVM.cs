using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace View.ViewModel
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
        /// Допустимые значения в поле PhoneNumber класса <see cref="Contact"/>.
        /// </summary>
        readonly string _acceptableValues = "01234567890-+()";

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

        /// <summary>
        /// Метод для проверки введённого в поле PhoneNumber класса <see cref="Contact"/> текста.
        /// </summary>
        /// <param name="parameter">Параметры события PreviewTextInput класса <see cref="TextCompositionEventArgs"/>.</param>
        [RelayCommand]
        private void PreviewTextInputEvent(object parameter)
        {
            int val;
            TextCompositionEventArgs e = (TextCompositionEventArgs)parameter;
            if(!_acceptableValues.Contains(e.Text))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод для проверки содержимого вставки в поле PhoneNumber класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="parameter">Параметры события DataObject.Pasting класса <see cref="DataObjectPastingEventArgs"/>.</param>
        [RelayCommand]
        private void PastingEvent(object parameter)
        {
            int val;
            string text = (string)(parameter as DataObjectPastingEventArgs).DataObject.GetData(typeof(string)); ;
            foreach(char c in text)
            {
                if (!!_acceptableValues.Contains(c))
                {
                    (parameter as DataObjectPastingEventArgs).CancelCommand();
                }
            }
        }
    }
}
