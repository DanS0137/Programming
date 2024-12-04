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

            ItemsTab.Items = Store.Items;
            CustomersTab.Customers = Store.Customers;

            CartsTab.Customers = Store.Customers;
            CartsTab.Items = Store.Items;

            OrdersTab.Customers = Store.Customers;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Services.StoreSerializer.SaveStore(Store);
        }

        private void TabControl_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            else if (tabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
        }
    }
}
