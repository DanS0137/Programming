using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _itemsList;
        Item _selectedItem;

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

        public ItemsTab()
        {
            InitializeComponent();
            SelectedItemCategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _selectedItem = _itemsList[ItemsListBox.SelectedIndex];
            SelectedItemIdTextBox.Text = Convert.ToString(_selectedItem.Id);
            SelectedItemCostTextBox.Text = Convert.ToString(_selectedItem.Cost);
            SelectedItemNameTextBox.Text = _selectedItem.Name;
            SelectedItemInfoTextBox.Text = _selectedItem.Info;
            SelectedItemCategoryComboBox.SelectedItem = _selectedItem.Category.ToString();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _itemsList.Insert(0, new Item());
            _itemsList[0].Name = "New item";
            ItemsListBox.Items.Insert(0, $"New item ID: { _itemsList[0].Id}");
            ItemsListBox.SelectedIndex = 0;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _itemsList.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            SelectedItemIdTextBox.Text = "";
            SelectedItemCostTextBox.Text = "";
            SelectedItemNameTextBox.Text = "";
            SelectedItemInfoTextBox.Text = "";
            SelectedItemCategoryComboBox.SelectedItem = "Другое";
            Services.StoreSerializer.DeleteElement(_selectedItem);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            double newCost;
            string newName, newInfo;
            try
            {
                newCost = Convert.ToDouble(SelectedItemCostTextBox.Text.Replace('.', ','));
                if (newCost < 0)
                {
                    SelectedItemCostTextBox.BackColor = Color.LightPink;
                    return;
                }
            }
            catch
            {
                SelectedItemCostTextBox.BackColor = Color.LightPink;
                return;
            }
            if (SelectedItemNameTextBox.Text.Length > 199 || string.IsNullOrEmpty(SelectedItemNameTextBox.Text))
            {
                SelectedItemNameTextBox.BackColor = Color.LightPink;
                return;
            }
            else newName = SelectedItemNameTextBox.Text;
            if (SelectedItemInfoTextBox.Text.Length > 999 || string.IsNullOrEmpty(SelectedItemInfoTextBox.Text))
            {
                SelectedItemInfoTextBox.BackColor = Color.LightPink;
                return;
            }
            else newInfo = SelectedItemInfoTextBox.Text;
            SelectedItemCostTextBox.BackColor = Color.White;
            SelectedItemNameTextBox.BackColor = Color.White;
            SelectedItemInfoTextBox.BackColor = Color.White;
            _selectedItem.Cost = newCost;
            _selectedItem.Name = newName;
            _selectedItem.Info = newInfo;
            _selectedItem.Category = (Category)Enum.Parse(typeof(Category), SelectedItemCategoryComboBox.SelectedItem.ToString());
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"{_selectedItem.Name} ID: {_selectedItem.Id}";
        }

        private void SelectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem.Category = (Category)Enum.Parse(typeof(Category), SelectedItemCategoryComboBox.SelectedItem.ToString());
        }

        private void OpenSIFormButton_Click(object sender, EventArgs e)
        {
            StandardInterfacesTestForm form = new StandardInterfacesTestForm();
            form.Show();
        }
    }
}
