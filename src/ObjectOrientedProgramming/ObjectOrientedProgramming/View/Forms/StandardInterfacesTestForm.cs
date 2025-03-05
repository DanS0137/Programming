using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.View
{
    public partial class StandardInterfacesTestForm : Form
    {
        public List<Item> Items { get; set; }

        public StandardInterfacesTestForm()
        {
            InitializeComponent();
        }
    }
}
