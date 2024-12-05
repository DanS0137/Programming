namespace ObjectOrientedProgramming.View.Tabs
{
    partial class PriorityOrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedProgramming.Model.Address address1 = new ObjectOrientedProgramming.Model.Address();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CreationTimeTextBox = new System.Windows.Forms.TextBox();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeliveryAddressControl = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.DeliveryTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(457, 374);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 37);
            this.AmountLabel.TabIndex = 27;
            this.AmountLabel.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(461, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Amount:";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(457, 250);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(495, 108);
            this.ItemsListBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(454, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Order Items";
            // 
            // CreationTimeTextBox
            // 
            this.CreationTimeTextBox.Location = new System.Drawing.Point(507, 58);
            this.CreationTimeTextBox.Name = "CreationTimeTextBox";
            this.CreationTimeTextBox.ReadOnly = true;
            this.CreationTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreationTimeTextBox.TabIndex = 23;
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(507, 32);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.ReadOnly = true;
            this.OrderIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderIdTextBox.TabIndex = 22;
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(507, 84);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.OrderStatusComboBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id:";
            // 
            // DeliveryAddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.DeliveryAddressControl.Address = address1;
            this.DeliveryAddressControl.Location = new System.Drawing.Point(457, 114);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(495, 117);
            this.DeliveryAddressControl.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(454, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selected Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIdColumn,
            this.CreationTimeColumn,
            this.FullNameColumn,
            this.Address,
            this.AmountColumn,
            this.OrderStatusColumn,
            this.DeliveryTimeColumn});
            this.OrdersDataGridView.Location = new System.Drawing.Point(8, 27);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(443, 410);
            this.OrdersDataGridView.TabIndex = 14;
            // 
            // OrderIdColumn
            // 
            this.OrderIdColumn.HeaderText = "Id";
            this.OrderIdColumn.Name = "OrderIdColumn";
            this.OrderIdColumn.ReadOnly = true;
            // 
            // CreationTimeColumn
            // 
            this.CreationTimeColumn.HeaderText = "Created";
            this.CreationTimeColumn.Name = "CreationTimeColumn";
            this.CreationTimeColumn.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.HeaderText = "Customer Full Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "AddressColumn";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.HeaderText = "Order Status";
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.ReadOnly = true;
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.Location = new System.Drawing.Point(457, 414);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(75, 23);
            this.SaveOrderButton.TabIndex = 28;
            this.SaveOrderButton.Text = "Save Order";
            this.SaveOrderButton.UseVisualStyleBackColor = true;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(538, 414);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrderButton.TabIndex = 29;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(861, 414);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveItemButton.TabIndex = 31;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(764, 414);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(91, 23);
            this.AddItemButton.TabIndex = 30;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // DeliveryTimeColumn
            // 
            this.DeliveryTimeColumn.HeaderText = "TimeOfDelivery";
            this.DeliveryTimeColumn.Name = "DeliveryTimeColumn";
            this.DeliveryTimeColumn.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(686, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(776, 32);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(100, 21);
            this.DeliveryTimeComboBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Time of delivery:";
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreationTimeTextBox);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.OrderStatusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeliveryAddressControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersDataGridView);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(960, 446);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreationTimeTextBox;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Controls.AddressControl DeliveryAddressControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.Button SaveOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTimeColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label label9;
    }
}
