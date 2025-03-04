using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;
using ObjectOrientedProgramming.Model.Discounts;
using ObjectOrientedProgramming.Services;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class StandardInterfacesTab : UserControl
    {
        private Item _itemForCloning;

        private Cart _cartForCloning;
        private Cart _clonedCart;

        private List<PointsDiscount> _pointsDiscounts1;
        private List<PointsDiscount> _pointsDiscounts2;

        private List<PercentsDiscount> _percentsDiscounts1;
        private List<PercentsDiscount> _percentsDiscounts2;

        private List<Item> _items;
        private List<Item> _clonedItems;

        public StandardInterfacesTab()
        {
            InitializeComponent();
            _items = StoreSerializer.LoadStore().Items;
            foreach(Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
                ItemsListBox1.Items.Add($"{item.Name} ID: {item.Id}");
                ItemsListBox2.Items.Add($"{item.Name} ID: {item.Id}");
                ItemsListBox21.Items.Add($"{item.Name} ID: {item.Id}");
                ItemsListBox22.Items.Add($"{item.Name} ID: {item.Id}");
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _itemForCloning = _items[ItemsListBox.SelectedIndex];
        }

        private void CloneItemButton_Click(object sender, EventArgs e)
        {
            if (_itemForCloning == null) return;
            if (_clonedItems == null) _clonedItems = new List<Item>();
            Item newItem = (Item)_itemForCloning.Clone();
            _clonedItems.Add(newItem);
            ClonedItemsListBox.Items.Add($"{newItem.Name} ID: {newItem.Id}");
        }

        private void CloneAddressButton_Click(object sender, EventArgs e)
        {
            Address addressForCloning;
            OrigAddressControl.SaveChanges();
            ClonedAddressControl.SaveChanges();
            try
            {
                addressForCloning = OrigAddressControl.Address;
            }
            catch
            {
                return;
            }
            Address clonedAddress = (Address)addressForCloning.Clone();
            ClonedAddressControl.Address = clonedAddress;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (_items == null) return;
            if (_cartForCloning == null) _cartForCloning = new Cart();
            Random rnd = new Random();
            Item rndItem = _items[rnd.Next(0, _items.Count)];
            CartListBox.Items.Add($"{rndItem.Name} ID: {rndItem.Id}");
            _cartForCloning.Items.Add(rndItem);
        }

        private void CloneCartButton_Click(object sender, EventArgs e)
        {
            if (_cartForCloning == null) return;
            if (_cartForCloning.Items.Count == 0) return;
            _clonedCart = (Cart)_cartForCloning.Clone();
            ClonedCartListBox.Items.Clear();
            foreach (Item item in _clonedCart.Items)
            {
                ClonedCartListBox.Items.Add($"{item.Name} ID: {item.Id}");
            }
        }

        private void AreItemsEqualButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox1.SelectedIndex == -1 || ItemsListBox2.SelectedIndex == -1) return;
            Item[] itemsForEquate = new Item[2];
            itemsForEquate[0] = _items[ItemsListBox1.SelectedIndex];
            itemsForEquate[1] = _items[ItemsListBox2.SelectedIndex];
            AreItemsEqualTextBox.Text = itemsForEquate[0].Equals(itemsForEquate[1]).ToString();
        }

        private void AreAdressesEqualButton_Click(object sender, EventArgs e)
        {
            Address[] addressesForEquate = new Address[2];
            AddressControl21.SaveChanges();
            AddressControl22.SaveChanges();
            try
            {
                addressesForEquate[0] = AddressControl21.Address;
                addressesForEquate[1] = AddressControl22.Address;
            }
            catch
            {
                return;
            }
            AreAdressesEqualTextBox.Text = addressesForEquate[0].Equals(addressesForEquate[1]).ToString();
        }

        private void CompareCostsButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox21.SelectedIndex == -1 || ItemsListBox22.SelectedIndex == -1) return;
            Item[] itemsForComparison= new Item[2];
            itemsForComparison[0] = _items[ItemsListBox21.SelectedIndex];
            itemsForComparison[1] = _items[ItemsListBox22.SelectedIndex];
            ComparingCostsTextBox.Text = itemsForComparison[0].CompareTo(itemsForComparison[1]).ToString();
        }

        private void AddDiscountButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PointsDiscount disc = new PointsDiscount();
            disc.Points = rnd.Next(0, 1001);
            if (_pointsDiscounts1 == null) _pointsDiscounts1 = new List<PointsDiscount>();
            _pointsDiscounts1.Add(disc);
            PointsDiscountListBox1.Items.Add(disc.Info);
        }

        private void AddDiscountButton2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PointsDiscount disc = new PointsDiscount();
            disc.Points = rnd.Next(0, 1001);
            if (_pointsDiscounts2 == null) _pointsDiscounts2 = new List<PointsDiscount>();
            _pointsDiscounts2.Add(disc);
            PointsDiscountListBox2.Items.Add(disc.Info);
        }

        private void ComparePointsButton_Click(object sender, EventArgs e)
        {
            if (PointsDiscountListBox1.SelectedIndex == -1 || PointsDiscountListBox2.SelectedIndex == -1) return;
            PointsDiscount[] discsForComparison = new PointsDiscount[2];
            discsForComparison[0] = _pointsDiscounts1[PointsDiscountListBox1.SelectedIndex];
            discsForComparison[1] = _pointsDiscounts2[PointsDiscountListBox2.SelectedIndex];
            ComparingPointsTextBox.Text = discsForComparison[0].CompareTo(discsForComparison[1]).ToString();
        }

        private void AddDiscountButton21_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PercentsDiscount disc = new PercentsDiscount();
            disc.Discount = rnd.Next(0, 11);
            disc.Category = (Category)rnd.Next(0, 5);
            if (_percentsDiscounts1 == null) _percentsDiscounts1 = new List<PercentsDiscount>();
            _percentsDiscounts1.Add(disc);
            PercentsDiscountListBox1.Items.Add(disc.Info);
        }

        private void AddDiscountButton22_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PercentsDiscount disc = new PercentsDiscount();
            disc.Discount = rnd.Next(0, 11);
            disc.Category = (Category)rnd.Next(0, 5);
            if (_percentsDiscounts2 == null) _percentsDiscounts2 = new List<PercentsDiscount>();
            _percentsDiscounts2.Add(disc);
            PercentsDiscountListBox2.Items.Add(disc.Info);
        }

        private void ComparePercentsButton_Click(object sender, EventArgs e)
        {
            if (PercentsDiscountListBox1.SelectedIndex == -1 || PercentsDiscountListBox2.SelectedIndex == -1) return;
            PercentsDiscount[] discsForComparison = new PercentsDiscount[2];
            discsForComparison[0] = _percentsDiscounts1[PercentsDiscountListBox1.SelectedIndex];
            discsForComparison[1] = _percentsDiscounts2[PercentsDiscountListBox2.SelectedIndex];
            ComparingPercentsTextBox.Text = discsForComparison[0].CompareTo(discsForComparison[1]).ToString();
        }
    }
}
