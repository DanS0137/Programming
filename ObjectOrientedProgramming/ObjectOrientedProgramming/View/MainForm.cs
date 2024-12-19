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

            PriorityOrdersTab.Items = Store.Items;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Services.StoreSerializer.SaveStore(Store);
        }

        private void TabControl_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                CustomersTab.RefreshData();
                ClientSize = new Size(820, 465);
            }
            else if (tabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
                ClientSize = new Size(806, 542);
            }
            else if (tabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
                Size = new Size(990, 535);
            }
            else if (tabControl.SelectedIndex == 4)
            {
                ClientSize = new Size(965, 468);
            }
        }
    }
}
