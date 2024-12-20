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
using ObjectOrientedProgramming.Services;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _itemsList;
        Item _selectedItem;
        string _searchingString = "";
        List<Item> _displayedItems;

        public List<Item> Items
        {
            get => _itemsList;
            set
            {
                _itemsList = value;
                _displayedItems = value;
                if (value != null)
                {
                    foreach (Item item in value)
                    {
                        ItemsListBox.Items.Add(item.Name + $" ID: {item.Id}");
                    }
                    SortsComboBox.SelectedItem = "Name";
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
            _selectedItem = _displayedItems[ItemsListBox.SelectedIndex];
            SelectedItemIdTextBox.Text = Convert.ToString(_selectedItem.Id);
            SelectedItemCostTextBox.Text = Convert.ToString(_selectedItem.Cost);
            SelectedItemNameTextBox.Text = _selectedItem.Name;
            SelectedItemInfoTextBox.Text = _selectedItem.Info;
            SelectedItemCategoryComboBox.SelectedItem = _selectedItem.Category.ToString();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Items.Insert(0, new Item());
            Items[0].Name = "New item";
            
            if (Items[0].Name.Contains(_searchingString))
            {
                ItemsListBox.Items.Insert(0, $"New item ID: { Items[0].Id}");
                _displayedItems.Insert(0, Items[0]);
                ItemsListBox.SelectedIndex = 0;
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Items.Remove(_selectedItem);
            _displayedItems.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            SelectedItemIdTextBox.Text = "";
            SelectedItemCostTextBox.Text = "";
            SelectedItemNameTextBox.Text = "";
            SelectedItemInfoTextBox.Text = "";
            SelectedItemCategoryComboBox.SelectedItem = "Другое";
            StoreSerializer.DeleteElement(_selectedItem);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;
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
            if (SelectedItemCategoryComboBox.SelectedIndex == -1)
            {
                SelectedItemCategoryComboBox.BackColor = Color.LightPink;
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
            int index = Items.IndexOf(_selectedItem);
            _selectedItem.Cost = newCost;
            _selectedItem.Name = newName;
            _selectedItem.Info = newInfo;
            _selectedItem.Category = (Category)Enum.Parse(typeof(Category), SelectedItemCategoryComboBox.SelectedItem.ToString());
            Items[index] = (Item)_selectedItem.Clone();
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"{_selectedItem.Name} ID: {_selectedItem.Id}";
        }

        //private void SelectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _selectedItem.Category = (Category)Enum.Parse(typeof(Category), SelectedItemCategoryComboBox.SelectedItem.ToString());
        //}

        private void OpenSIFormButton_Click(object sender, EventArgs e)
        {
            StandardInterfacesTestForm form = new StandardInterfacesTestForm();
            form.Show();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _searchingString = SearchTextBox.Text;
            _displayedItems = DataTools.Filter(Items, FilterByName);

            ItemsListBox.Items.Clear();
            foreach(Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
            }

            SelectedItemIdTextBox.Text = "";
            SelectedItemCostTextBox.Text = "";
            SelectedItemNameTextBox.Text = "";
            SelectedItemInfoTextBox.Text = "";
            SelectedItemCategoryComboBox.SelectedIndex = -1;
            _selectedItem = null;
        }

        public bool FilterByName(Item item)
        {
            return item.Name.Contains(_searchingString);
        }

        private void SortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortsComboBox.SelectedIndex == -1) return;
            switch (SortsComboBox.SelectedItem)
            {
                case "Name":
                    {
                        _displayedItems = DataTools.Sort(_displayedItems, DataTools.SortByName);
                        break;
                    }
                case "Cost (Ascending)":
                    {
                        _displayedItems = DataTools.Sort(_displayedItems, DataTools.SortByCost_Ascending);
                        break;
                    }
                case "Cost (Descending)":
                    {
                        _displayedItems = DataTools.Sort(_displayedItems, DataTools.SortByCost_Descending);
                        break;
                    }
            }

            ItemsListBox.Items.Clear();
            foreach(Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
            }
        }
    }
}
