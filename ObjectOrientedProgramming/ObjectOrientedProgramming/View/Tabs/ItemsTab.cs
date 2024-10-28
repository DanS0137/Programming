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
        List<Item> _itemsList = new List<Item>();
        Item _selectedItem;

        public ItemsTab()
        {
            InitializeComponent();
            string path = Environment.ExpandEnvironmentVariables("%appdata%") + @"\OOP";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path + @"\Items");
            }
            else if (!Directory.Exists(path + @"\Items"))
            {
                Directory.CreateDirectory(path + @"\Items");
            }
            var directory = new DirectoryInfo(path + @"\Items");
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                StreamReader sr = new StreamReader(file.FullName);
                int id = Convert.ToInt16(file.Name);
                double cost = Convert.ToDouble(sr.ReadLine());
                string name = sr.ReadLine();
                string info = sr.ReadToEnd();
                _selectedItem = new Item(id, name, info, cost);
                _itemsList.Add(_selectedItem);
                ItemsListBox.Items.Add(_selectedItem.Name + $" ID: {_selectedItem.Id}");
                sr.Close();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _selectedItem = _itemsList[ItemsListBox.SelectedIndex];
            SelectedItemIdTextBox.Text = Convert.ToString(_selectedItem.Id);
            SelectedItemCostTextBox.Text = Convert.ToString(_selectedItem.Cost);
            SelectedItemNameTextBox.Text = _selectedItem.Name;
            SelectedItemInfoTextBox.Text = _selectedItem.Info;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _itemsList.Insert(0, new Item());
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
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\OOP\Items\" + $"{_selectedItem.Id}";
            File.Delete(path);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            double newCost;
            string newName, newInfo;
            try
            {
                newCost = Convert.ToDouble(SelectedItemCostTextBox.Text.Replace('.', ','));
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
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"{_selectedItem.Name} ID: {_selectedItem.Id}";
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\OOP\Items\" + $"{_selectedItem.Id}";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(_selectedItem.Cost.ToString() + "\n");
                fs.Write(info, 0, info.Length);
                info = new UTF8Encoding(true).GetBytes(_selectedItem.Name + "\n");
                fs.Write(info, 0, info.Length);
                info = new UTF8Encoding(true).GetBytes(_selectedItem.Info);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
