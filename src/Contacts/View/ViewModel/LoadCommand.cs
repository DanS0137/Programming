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
        private MainVM _vM;

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
            _vM.Email = contact.Email;
            _vM.Name = contact.Name;
            _vM.PhoneNumber = contact.PhoneNumber;
        }

        public LoadCommand(MainVM vM)
        {
            _vM = vM;
        }
    }
}
