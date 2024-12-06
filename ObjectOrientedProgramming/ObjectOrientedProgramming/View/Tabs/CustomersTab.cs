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
using System.IO;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Customer> _customersList;
        Customer _selectedCustomer;

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
                        CustomersListBox.Items.Add(customer.FullName + $" ID: {customer.Id}");
                    }
                }
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            _selectedCustomer = _customersList[CustomersListBox.SelectedIndex];
            SelectedCustomerIdTextBox.Text = Convert.ToString(_selectedCustomer.Id);
            SelectedCustomerFullNameTextBox.Text = _selectedCustomer.FullName;
            SelectedCustomerAddressControl.Address = _selectedCustomer.Address;
            IsPriorityCheckBox.Checked = _selectedCustomer.IsPriority;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _customersList.Insert(0, new Customer());
            _customersList[0].FullName = "New customer";
            CustomersListBox.Items.Insert(0, $"New customer ID: { _customersList[0].Id}");
            CustomersListBox.SelectedIndex = 0;
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _customersList.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            SelectedCustomerIdTextBox.Text = "";
            SelectedCustomerFullNameTextBox.Text = "";
            SelectedCustomerAddressControl.Clear();
            Services.StoreSerializer.DeleteElement(_selectedCustomer);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            string newFullName;
            if (SelectedCustomerFullNameTextBox.Text.Length > 199 || string.IsNullOrEmpty(SelectedCustomerFullNameTextBox.Text))
            {
                SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Поле Full Name должно быть не пустым и состоять менее чем из 200 символов.");
                return;
            }
            else newFullName = SelectedCustomerFullNameTextBox.Text;
            SelectedCustomerFullNameTextBox.BackColor = Color.White;
            _selectedCustomer.FullName = newFullName;
            SelectedCustomerAddressControl.SaveChanges();
            _selectedCustomer.Address = SelectedCustomerAddressControl.Address;
            CustomersListBox.Items[CustomersListBox.SelectedIndex] = $"{_selectedCustomer.FullName} ID: {_selectedCustomer.Id}";
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer == null) return;
            if (IsPriorityCheckBox.Checked == true)
            {
                _selectedCustomer.IsPriority = true;
            }
            else
            {
                _selectedCustomer.IsPriority = false;
            }
        }
    }
}
