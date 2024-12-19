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
using ObjectOrientedProgramming.Model.Enumerations;
using ObjectOrientedProgramming.Model.Orders;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orders = new List<Order>();
        private List<Customer> _customers = new List<Customer>();

        private Order _selectedOrder;
        private PriorityOrder _selectedPriorityOrder;

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
            OrderStatusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
            int hours = 9;
            for (int i = 0; i < 6; i++)
            {
                DeliveryTimeComboBox.Items.Add($"{hours}:00 - {hours + 2}:00");
                hours += 2;
            }
            DeliveryAddressControl.CloseAccess();
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
            TotalLabel.Text = "0";

            UpdateOrders();
            ChangeBoxes(0);
        }

        public void UpdateOrders()
        {
            if (Orders != null) Orders.Clear();
            Orders = new List<Order>();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders == null) continue;
                foreach (Order order in customer.Orders)
                {
                    string address = $"{order.Address.Index.ToString()} {order.Address.Country} {order.Address.City}" +
                        $" {order.Address.Street} {order.Address.Building}-{order.Address.Apartment}";
                    string[] row = { order.Id.ToString(), order.DateOfCreation.ToString(), customer.FullName,
                        address, order.Amount.ToString(), order.OrderStatus.ToString(), order.Total.ToString() };
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
            if (Orders.Count == 0 || Orders == null) return;
            if (Orders[index].GetType() == typeof(Order))
            {
                _selectedOrder = Orders[index];
                _selectedPriorityOrder = null;

                OrderIdTextBox.Text = _selectedOrder.Id.ToString();
                CreationTimeTextBox.Text = _selectedOrder.DateOfCreation.ToString();
                OrderStatusComboBox.SelectedItem = _selectedOrder.OrderStatus.ToString();
                DeliveryAddressControl.Address = _selectedOrder.Address;

                PriorityOptionsPanel.Visible = false;

                ItemsListBox.Items.Clear();
                foreach (Item item in _selectedOrder.Items)
                {
                    ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
                }

                AmountLabel.Text = _selectedOrder.Amount.ToString();
                TotalLabel.Text = _selectedOrder.Total.ToString();
            }
            else
            {
                _selectedOrder = null;
                _selectedPriorityOrder = (PriorityOrder)Orders[index];

                OrderIdTextBox.Text = _selectedPriorityOrder.Id.ToString();
                CreationTimeTextBox.Text = _selectedPriorityOrder.DateOfCreation.ToString();
                OrderStatusComboBox.SelectedItem = _selectedPriorityOrder.OrderStatus.ToString();
                DeliveryAddressControl.Address = _selectedPriorityOrder.Address;

                PriorityOptionsPanel.Visible = true;
                DeliveryTimeComboBox.SelectedIndex = (int)_selectedPriorityOrder.TimeOfDelivery;

                ItemsListBox.Items.Clear();
                foreach (Item item in _selectedPriorityOrder.Items)
                {
                    ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
                }

                AmountLabel.Text = _selectedPriorityOrder.Amount.ToString();
                TotalLabel.Text = _selectedPriorityOrder.Total.ToString();
            }
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderStatusComboBox.SelectedIndex == -1 || Orders.Count == 0) return;
            int selIndex = OrdersDataGridView.CurrentCell.RowIndex;
            OrdersDataGridView.Rows[selIndex].Cells[5].Value = OrderStatusComboBox.SelectedItem.ToString();
            Orders[selIndex].OrderStatus = (OrderStatus)OrderStatusComboBox.SelectedIndex;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.TimeOfDelivery = (TimeOfDelivery)DeliveryTimeComboBox.SelectedIndex;
        }
    }
}
