using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public Store Store
        {
            get => _store;
            set
            {
                _store = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Store = Services.StoreSerializer.LoadStore();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Services.StoreSerializer.SaveStore(_store);
        }
    }
}
