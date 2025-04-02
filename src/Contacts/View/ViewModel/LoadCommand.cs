using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xaml;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Команда загрузки.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM"/>, из которого
        /// исходит команда загрузки.
        /// </summary>
        private readonly MainVM _vm;

        event EventHandler? ICommand.CanExecuteChanged
        {
            add { }
            remove { }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }
        public void Execute(object? parameter)
        {
            Contact contact = Model.Services.ContactSerializer.LoadContact();
            _vm.Email = contact.Email;
            _vm.Name = contact.Name;
            _vm.PhoneNumber = contact.PhoneNumber;
        }

        public LoadCommand(MainVM vM)
        {
            _vm = vM;
        }
    }
}
