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
            Model.Services.ContactSerializer.SaveContact(new Contact(_vM.Name, _vM.PhoneNumber, _vM.Email));
        }

        public SaveCommand(MainVM vM)
        {
            _vM = vM;
        }
    }
}
