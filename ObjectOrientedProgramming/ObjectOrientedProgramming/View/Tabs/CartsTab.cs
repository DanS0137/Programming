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
    public partial class CartsTab : UserControl
    {
        private List<Item> _itemsList;
        private List<Customer> _customersList;
        private Customer _selectedCustomer;

        public List<Item> Items
        {
            get => _itemsList;
            set
            {
                _itemsList = value;
                if (value != null)
                {
                    foreach (Item item in value)
                    {
                        ItemsListBox.Items.Add(item.Name + $" ID: {item.Id}");
                    }
                }
            }
        }

        public List<Customer> Customers
        {
            get => _customersList;
            set
            {
                _customersList = value;
                if (value != null)
                {
                    foreach (Customer customer in value)
                    {
                        CustomersComboBox.Items.Add(customer.FullName + $" ID: {customer.Id}");
                    }
                }
            }
        }

        private Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
            }
        }


        public CartsTab()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer == null || ItemsListBox.SelectedIndex == -1) return;
            SelectedCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            CartListBox.Items.Add(ItemsListBox.SelectedItem);
            AmountLabel.Text = SelectedCustomer.Cart.Amount.ToString();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1) return;
            CartListBox.Items.Clear();
            AmountLabel.Text = "0";
            SelectedCustomer = Customers[CustomersComboBox.SelectedIndex];
            Cart cart = SelectedCustomer.Cart;
            if (cart != null)
            {
                foreach (Item item in cart.Items)
                {
                    CartListBox.Items.Add($"{item.Name} ID: {item.Id}");
                }
            }
            AmountLabel.Text = cart.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1) return;
            SelectedCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            AmountLabel.Text = SelectedCustomer.Cart.Amount.ToString();
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order;
            if (SelectedCustomer.IsPriority)
            {
                order = new PriorityOrder(TimeOfDelivery.NineToEleven, DateTime.Today, SelectedCustomer.Address, SelectedCustomer.Cart.Items);
            }
            else
            {
                order = new Order(SelectedCustomer.Address, SelectedCustomer.Cart.Items);
            }
            SelectedCustomer.Orders.Add(order);
            ClearCart();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void ClearCart()
        {
            if (SelectedCustomer == null) return;
            SelectedCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            AmountLabel.Text = "0";
        }

        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            CustomersComboBox.Items.Clear();

            Items = Items;
            Customers = Customers;

            SelectedCustomer = null;
        }
    }
}
