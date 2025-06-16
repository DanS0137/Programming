using System;
using System.Collections.Generic;
using System.Linq;
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
        public static readonly DependencyProperty IsEdittingProperty;

        static ContactControl()
        {
            IsEdittingProperty = DependencyProperty.Register(
                "IsEditting",
                typeof(bool),
                typeof(ContactControl)
                );
        }

        public bool IsEditting
        {
            get { return (bool)GetValue(IsEdittingProperty);}
            set { SetValue(IsEdittingProperty, value); }
        }

        public ContactControl()
        {
            InitializeComponent();
            IsEditting = false;
        }
    }
}
