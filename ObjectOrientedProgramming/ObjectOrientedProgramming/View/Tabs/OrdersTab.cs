using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orders = new List<Order>();
        private List<Customer> _customers = new List<Customer>();

        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        public List<Order> Orders
        {
            get => _orders;
            set => _orders = value;
        }

        public OrdersTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            ItemsListBox.Items.Clear();
            DeliveryAddressControl.Clear();

            OrderIdTextBox.Text = "";
            CreationTimeTextBox.Text = "";
            OrderStatusComboBox.SelectedIndex = -1;
            AmountLabel.Text = "0";
            
            UpdateOrders();
            ChangeBoxes(0);
        }

        public void UpdateOrders()
        {
            if (Orders != null) Orders.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders == null) continue;
                foreach (Order order in customer.Orders)
                {
                    string address = $"{order.Address.Index.ToString()} {order.Address.Country} {order.Address.City}" +
                        $" {order.Address.Street} {order.Address.Building}-{order.Address.Apartment}";
                    string[] row = { order.Id.ToString(), order.DateOfCreation.ToString(), customer.FullName, address, order.Amount.ToString(), order.OrderStatus.ToString() };
                    OrdersDataGridView.Rows.Add(row);
                    Orders.Add(order);
                }
            }
        }

        private void OrdersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeBoxes(OrdersDataGridView.SelectedCells[0].RowIndex);
        }

        private void ChangeBoxes(int index)
        {
            Order selOrder = Orders[index];

            OrderIdTextBox.Text = selOrder.Id.ToString();
            CreationTimeTextBox.Text = selOrder.DateOfCreation.ToString();
            OrderStatusComboBox.SelectedItem = selOrder.OrderStatus.ToString();
            DeliveryAddressControl.Address = selOrder.Address;

            ItemsListBox.Items.Clear();
            foreach (Item item in selOrder.Items)
            {
                ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
            }

            AmountLabel.Text = selOrder.Amount.ToString();
        }
    }
}
