namespace ObjectOrientedProgramming.View.Tabs
{
    partial class OrdersTab
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
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeliveryAddressControl = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.CreationTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.OrderStatusColumn});
            this.OrdersDataGridView.Location = new System.Drawing.Point(10, 27);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(443, 384);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(456, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Order";
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
            this.DeliveryAddressControl.Location = new System.Drawing.Point(459, 114);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(495, 117);
            this.DeliveryAddressControl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status:";
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(509, 84);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.OrderStatusComboBox.TabIndex = 7;
            this.OrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStatusComboBox_SelectedIndexChanged);
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(509, 32);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.ReadOnly = true;
            this.OrderIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderIdTextBox.TabIndex = 8;
            // 
            // CreationTimeTextBox
            // 
            this.CreationTimeTextBox.Location = new System.Drawing.Point(509, 58);
            this.CreationTimeTextBox.Name = "CreationTimeTextBox";
            this.CreationTimeTextBox.ReadOnly = true;
            this.CreationTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreationTimeTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(456, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Order Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(459, 250);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(495, 108);
            this.ItemsListBox.TabIndex = 11;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(459, 374);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 37);
            this.AmountLabel.TabIndex = 13;
            this.AmountLabel.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(463, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Amount:";
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(972, 420);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.AddressControl DeliveryAddressControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.TextBox CreationTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
    }
}
