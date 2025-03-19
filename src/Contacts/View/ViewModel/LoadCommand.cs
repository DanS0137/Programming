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
    public class LoadCommand : ICommand
    {
        private Action<object> _execute;

        event EventHandler? ICommand.CanExecuteChanged
        {
            add { bool a = true; }
            remove { bool a = true; }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public LoadCommand(Action<object> execute)
        {
            _execute = execute;
        }
    }
}
