using System;
using System.Drawing;
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

            ItemsTab.ItemsChanged += new EventHandler(CartsTab.RefreshData);
            ItemsTab.ItemsChanged += new EventHandler(OrdersTab.RefreshData);

            CartsTab.OrderAdded += new EventHandler(OrdersTab.RefreshData);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                ClientSize = new Size(820, 465);
            }
            else if (tabControl.SelectedIndex == 2)
            {
                ClientSize = new Size(806, 542);
            }
            else if (tabControl.SelectedIndex == 3)
            {
                Size = new Size(990, 535);
            }
            else if (tabControl.SelectedIndex == 4)
            {
                ClientSize = new Size(965, 468);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Services.StoreSerializer.SaveStore(Store);
        }
    }
}
