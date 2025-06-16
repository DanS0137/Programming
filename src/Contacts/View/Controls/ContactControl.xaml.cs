using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {

        /// <summary>
        /// Допустимые значения в поле PhoneNumber класса <see cref="Contact"/>.
        /// </summary>
        readonly string _acceptableValues = "01234567890-+()";

        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для проверки введённого в поле PhoneNumber класса <see cref="Contact"/> текста.
        /// </summary>
        /// <param name="parameter">Параметры события PreviewTextInput класса <see cref="TextCompositionEventArgs"/>.</param>
        private void PreviewTextInputEvent(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!_acceptableValues.Contains(e.Text))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод для проверки содержимого вставки в поле PhoneNumber класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="parameter">Параметры события DataObject.Pasting класса <see cref="DataObjectPastingEventArgs"/>.</param>
        private void PastingEvent(object sender, DataObjectPastingEventArgs e)
        {
            int val;
            string text = (string)e.DataObject.GetData(typeof(string)); ;
            foreach (char c in text)
            {
                if (!_acceptableValues.Contains(c))
                {
                    e.CancelCommand();
                }
            }
        }
    }
}
