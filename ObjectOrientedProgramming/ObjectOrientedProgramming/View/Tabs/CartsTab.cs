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
        public event EventHandler AddedOrder;

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
            ReCalcDiscount();
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

            DiscountsCheckedListBox.Items.Clear();
            foreach (IDiscount discount in SelectedCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info, true);
            }
            ReCalcDiscount();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1) return;
            SelectedCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            AmountLabel.Text = SelectedCustomer.Cart.Amount.ToString();
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            ReCalcDiscount();
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

            double currentDiscount = 0;
            foreach (int checkedIndex in DiscountsCheckedListBox.CheckedIndices)
            {
                currentDiscount += SelectedCustomer.Discounts[checkedIndex].Apply(SelectedCustomer.Cart.Items);
            }
            foreach (IDiscount discount in SelectedCustomer.Discounts)
            {
                discount.Update(SelectedCustomer.Cart.Items);
            }
            order.DiscontAmount = currentDiscount;
            SelectedCustomer.Orders.Add(order);

            ClearCart();
            DiscountsCheckedListBox.Items.Clear();
            foreach (IDiscount discount in SelectedCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info, true);
            }

            AddedOrder?.Invoke(this, new EventArgs());
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

        public void RefreshData(object sender, EventArgs e)
        {
            ItemsListBox.Items.Clear();
            CustomersComboBox.Items.Clear();
            DiscountsCheckedListBox.Items.Clear();
            DiscountLabel.Text = "0";

            Items = Items;
            Customers = Customers;

            if (SelectedCustomer == null) return;
            foreach (IDiscount discount in SelectedCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info, true);
            }
            ReCalcDiscount();
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, EventArgs e)
        {
            ReCalcDiscount();
        }

        private void ReCalcDiscount()
        {
            double currentDiscount = 0;
            foreach (int checkedIndex in DiscountsCheckedListBox.CheckedIndices)
            {
                currentDiscount += SelectedCustomer.Discounts[checkedIndex].Calculate(SelectedCustomer.Cart.Items);
            }
            DiscountLabel.Text = currentDiscount.ToString();
        }
    }
}
