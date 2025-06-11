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

namespace View.ViewModel
{
    public class ContactVM : INotifyPropertyChanged
    {
        private Contact _currentContact;

        private bool _isEditting;

        public bool IsEditting
        {
            get { return _isEditting; }
            set
            {
                _isEditting = value;
                ThisPropertyChanged(nameof(IsEditting));
            }
        }

        public Contact CurrentContact 
        { get 
            { 
                return _currentContact; 
            }
            set
            {
                _currentContact = value;
                ThisPropertyChanged(nameof(CurrentContact));
            }
        }

        public RelayCommand PreviewTextInputCommand => new RelayCommand(PreviewTextInputEvent);

        public RelayCommand PastingCommand => new RelayCommand(PastingEvent);

        public event PropertyChangedEventHandler? PropertyChanged;

        public void ThisPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ContactVM(Contact contact)
        {
            CurrentContact = new Contact(contact);
            IsEditting = false;
        }

        public ContactVM()
        {
            CurrentContact = new Contact();
            IsEditting = false;
        }

        private void PreviewTextInputEvent(object parameter)
        {
            string values = "01234567890-+()";
            int val;
            TextCompositionEventArgs e = (TextCompositionEventArgs)parameter;
            if(!values.Contains(e.Text))
            { 
                e.Handled = true;
            }
        }

        private void PastingEvent(object parameter)
        {
            string values = "01234567890-+()";
            int val;
            string text = (string)(parameter as DataObjectPastingEventArgs).DataObject.GetData(typeof(string)); ;
            foreach(char c in text)
            {
                if (!values.Contains(c))
                {
                    (parameter as DataObjectPastingEventArgs).CancelCommand();
                }
            }
        }
    }
}
