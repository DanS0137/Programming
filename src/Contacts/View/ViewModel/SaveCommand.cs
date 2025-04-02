using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Команда сохранения.
    /// </summary>
    public class SaveCommand : ICommand
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
            Model.Services.ContactSerializer.SaveContact(new Contact(_vm.Name, _vm.PhoneNumber, _vm.Email));
        }

        public SaveCommand(MainVM vm)
        {
            _vm = vm;
        }
    }
}
