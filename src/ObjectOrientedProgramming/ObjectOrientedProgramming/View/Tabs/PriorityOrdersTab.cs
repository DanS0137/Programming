using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;
using ObjectOrientedProgramming.Model.Enumerations;
using ObjectOrientedProgramming.Model.Orders;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        public List<Item> Items { get; set; }
        public List<PriorityOrder> PriorityOrders { get; set; }
        public PriorityOrder CurrentOrder { get; set; }

        public PriorityOrdersTab()
        {
            InitializeComponent();
            int hours = 9;
            for (int i = 0; i < 6; i++)
            {
                DeliveryTimeComboBox.Items.Add($"{hours}:00 - {hours + 2}:00");
                hours += 2;
            }
            OrderStatusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderStatusComboBox.SelectedIndex == -1) return;
            CurrentOrder.OrderStatus = (OrderStatus)OrderStatusComboBox.SelectedIndex;
            OrdersDataGridView.Rows[OrdersDataGridView.SelectedCells[0].RowIndex].Cells[5].Value = CurrentOrder.OrderStatus.ToString();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex == -1) return;
            CurrentOrder.TimeOfDelivery = (TimeOfDelivery)DeliveryTimeComboBox.SelectedIndex;
            OrdersDataGridView.Rows[OrdersDataGridView.SelectedCells[0].RowIndex].Cells[6].Value = DeliveryTimeComboBox.SelectedItem.ToString();
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            if (PriorityOrders == null) PriorityOrders = new List<PriorityOrder>();
            DeliveryAddressControl.SaveChanges();
            string deliveryTime = DeliveryTimeComboBox.SelectedItem.ToString();
            CurrentOrder.Address = DeliveryAddressControl.Address;
            string address = $"{CurrentOrder.Address.Index.ToString()} {CurrentOrder.Address.Country} {CurrentOrder.Address.City}" +
                        $" {CurrentOrder.Address.Street} {CurrentOrder.Address.Building}-{CurrentOrder.Address.Apartment}";
            string[] row = { CurrentOrder.Id.ToString(), CurrentOrder.DateOfCreation.ToString(), "-",
                address, CurrentOrder.Amount.ToString(), CurrentOrder.OrderStatus.ToString(), deliveryTime };
            OrdersDataGridView.Rows[OrdersDataGridView.SelectedCells[0].RowIndex].SetValues(row);
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            PriorityOrders.Remove(CurrentOrder);
            OrdersDataGridView.Rows.RemoveAt(OrdersDataGridView.SelectedCells[0].RowIndex);
            ClearBoxes();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (Items.Count == 0) return;
            if (CurrentOrder.Items == null) CurrentOrder.Items = new List<Item>();
            Random r = new Random();
            int rnd = r.Next(0, Items.Count);

            ItemsListBox.Items.Add($"{Items[rnd].Name} ID: {Items[rnd].Id}");
            CurrentOrder.Items.Add((Item)Items[rnd].Clone());
            AmountLabel.Text = CurrentOrder.Amount.ToString();
            OrdersDataGridView.Rows[OrdersDataGridView.SelectedCells[0].RowIndex].Cells[4].Value = CurrentOrder.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            CurrentOrder.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            AmountLabel.Text = CurrentOrder.Amount.ToString();
            OrdersDataGridView.Rows[OrdersDataGridView.SelectedCells[0].RowIndex].Cells[4].Value = CurrentOrder.Amount.ToString();
        }

        private void ClearBoxes()
        {
            DeliveryAddressControl.Clear();
            OrderIdTextBox.Clear();
            CreationTimeTextBox.Clear();
            AmountLabel.Text = "0";
            OrderStatusComboBox.SelectedIndex = -1;
            DeliveryTimeComboBox.SelectedIndex = -1;
            ItemsListBox.Items.Clear();
        }

        private void OrdersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
            CurrentOrder = PriorityOrders[selIndex];
            OrderIdTextBox.Text = CurrentOrder.Id.ToString();
            CreationTimeTextBox.Text = CurrentOrder.DateOfCreation.ToString();
            OrderStatusComboBox.SelectedItem = CurrentOrder.OrderStatus.ToString();
            DeliveryTimeComboBox.SelectedIndex = (int)CurrentOrder.TimeOfDelivery;
            DeliveryAddressControl.Clear();
            if (CurrentOrder.Address != null) DeliveryAddressControl.Address = CurrentOrder.Address;
            AmountLabel.Text = CurrentOrder.Amount.ToString();
            ItemsListBox.Items.Clear();
            foreach (Item item in CurrentOrder.Items)
            {
                ItemsListBox.Items.Add($"{item.Name} ID: {item.Id}");
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            if (PriorityOrders == null) PriorityOrders = new List<PriorityOrder>();
            ClearBoxes();
            CurrentOrder = new PriorityOrder();
            CurrentOrder.OrderStatus = OrderStatus.New;
            PriorityOrders.Add(CurrentOrder);
            OrdersDataGridView.Rows.Add($"{CurrentOrder.Id.ToString()}");
        }
    }
}
