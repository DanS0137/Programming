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
        List<Customer> _customersList = new List<Customer>();
        Customer _selectedCustomer;

        public CustomersTab()
        {
            InitializeComponent();
            string path = Environment.ExpandEnvironmentVariables("%appdata%") + @"\OOP";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path + @"\Customers");
            }
            else if (!Directory.Exists(path + @"\Customers"))
            {
                Directory.CreateDirectory(path + @"\Customers");
            }
            var directory = new DirectoryInfo(path + @"\Customers");
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                StreamReader sr = new StreamReader(file.FullName);
                int id = Convert.ToInt16(file.Name);
                string fullName = sr.ReadLine();
                string address = sr.ReadToEnd();
                _selectedCustomer = new Customer(id, fullName, address);
                _customersList.Add(_selectedCustomer);
                CustomersListBox.Items.Add(_selectedCustomer.FullName + $" ID: {_selectedCustomer.Id}");
                sr.Close();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            _selectedCustomer = _customersList[CustomersListBox.SelectedIndex];
            SelectedCustomerIdTextBox.Text = Convert.ToString(_selectedCustomer.Id);
            SelectedCustomerFullNameTextBox.Text = _selectedCustomer.FullName;
            SelectedCustomerAddressTextBox.Text = _selectedCustomer.Address;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _customersList.Insert(0, new Customer());
            CustomersListBox.Items.Insert(0, $"New customer ID: { _customersList[0].Id}");
            CustomersListBox.SelectedIndex = 0;
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _customersList.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            SelectedCustomerIdTextBox.Text = "";
            SelectedCustomerFullNameTextBox.Text = "";
            SelectedCustomerAddressTextBox.Text = "";
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\OOP\Customers\" + $"{_selectedCustomer.Id}";
            File.Delete(path);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            string newFullName, newAddress;
            if (SelectedCustomerFullNameTextBox.Text.Length > 199 || string.IsNullOrEmpty(SelectedCustomerFullNameTextBox.Text))
            {
                SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                return;
            }
            else newFullName = SelectedCustomerFullNameTextBox.Text;
            if (SelectedCustomerAddressTextBox.Text.Length > 999 || string.IsNullOrEmpty(SelectedCustomerAddressTextBox.Text))
            {
                SelectedCustomerAddressTextBox.BackColor = Color.LightPink;
                return;
            }
            else newAddress = SelectedCustomerAddressTextBox.Text;
            SelectedCustomerFullNameTextBox.BackColor = Color.White;
            SelectedCustomerAddressTextBox.BackColor = Color.White;
            _selectedCustomer.FullName = newFullName;
            _selectedCustomer.Address = newAddress;
            CustomersListBox.Items[CustomersListBox.SelectedIndex] = $"{_selectedCustomer.FullName} ID: {_selectedCustomer.Id}";
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\OOP\Customers\" + $"{_selectedCustomer.Id}";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(_selectedCustomer.FullName + "\n");
                fs.Write(info, 0, info.Length);
                info = new UTF8Encoding(true).GetBytes(_selectedCustomer.Address);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
