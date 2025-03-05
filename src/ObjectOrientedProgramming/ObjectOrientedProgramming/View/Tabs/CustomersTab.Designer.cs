namespace ObjectOrientedProgramming.View.Tabs
{
    partial class CustomersTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersTab));
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SelectedCustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerFullNameLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerIdLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerAddressControl = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddDiscoundButton = new System.Windows.Forms.Button();
            this.RemoveDiscoundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.Location = new System.Drawing.Point(683, 391);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(104, 28);
            this.SaveChangesButton.TabIndex = 27;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // SelectedCustomerFullNameTextBox
            // 
            this.SelectedCustomerFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullNameTextBox.Location = new System.Drawing.Point(359, 68);
            this.SelectedCustomerFullNameTextBox.Multiline = true;
            this.SelectedCustomerFullNameTextBox.Name = "SelectedCustomerFullNameTextBox";
            this.SelectedCustomerFullNameTextBox.Size = new System.Drawing.Size(428, 20);
            this.SelectedCustomerFullNameTextBox.TabIndex = 25;
            // 
            // SelectedCustomerIdTextBox
            // 
            this.SelectedCustomerIdTextBox.Location = new System.Drawing.Point(359, 40);
            this.SelectedCustomerIdTextBox.Name = "SelectedCustomerIdTextBox";
            this.SelectedCustomerIdTextBox.ReadOnly = true;
            this.SelectedCustomerIdTextBox.Size = new System.Drawing.Size(117, 20);
            this.SelectedCustomerIdTextBox.TabIndex = 23;
            // 
            // SelectedCustomerFullNameLabel
            // 
            this.SelectedCustomerFullNameLabel.AutoSize = true;
            this.SelectedCustomerFullNameLabel.Location = new System.Drawing.Point(298, 71);
            this.SelectedCustomerFullNameLabel.Name = "SelectedCustomerFullNameLabel";
            this.SelectedCustomerFullNameLabel.Size = new System.Drawing.Size(55, 13);
            this.SelectedCustomerFullNameLabel.TabIndex = 21;
            this.SelectedCustomerFullNameLabel.Text = "Full name:";
            // 
            // SelectedCustomerIdLabel
            // 
            this.SelectedCustomerIdLabel.AutoSize = true;
            this.SelectedCustomerIdLabel.Location = new System.Drawing.Point(298, 43);
            this.SelectedCustomerIdLabel.Name = "SelectedCustomerIdLabel";
            this.SelectedCustomerIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedCustomerIdLabel.TabIndex = 19;
            this.SelectedCustomerIdLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(298, 11);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 13);
            this.SelectedCustomerLabel.TabIndex = 18;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCustomerButton.Location = new System.Drawing.Point(96, 391);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(80, 28);
            this.RemoveCustomerButton.TabIndex = 17;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCustomerButton.Location = new System.Drawing.Point(10, 391);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(80, 28);
            this.AddCustomerButton.TabIndex = 16;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(10, 27);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(266, 355);
            this.CustomersListBox.TabIndex = 15;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(7, 11);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 14;
            this.CustomersLabel.Text = "Customers";
            // 
            // SelectedCustomerAddressControl
            // 
            //this.SelectedCustomerAddressControl.Address = ((ObjectOrientedProgramming.Model.Address)(resources.GetObject("SelectedCustomerAddressControl.Address")));
            this.SelectedCustomerAddressControl.Location = new System.Drawing.Point(297, 121);
            this.SelectedCustomerAddressControl.Name = "SelectedCustomerAddressControl";
            this.SelectedCustomerAddressControl.Size = new System.Drawing.Size(495, 117);
            this.SelectedCustomerAddressControl.TabIndex = 28;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(359, 96);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(74, 17);
            this.IsPriorityCheckBox.TabIndex = 29;
            this.IsPriorityCheckBox.Text = "Is Priority?";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(298, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.Location = new System.Drawing.Point(301, 261);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(250, 121);
            this.DiscountsListBox.TabIndex = 31;
            this.DiscountsListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsListBox_SelectedIndexChanged);
            // 
            // AddDiscoundButton
            // 
            this.AddDiscoundButton.Location = new System.Drawing.Point(557, 261);
            this.AddDiscoundButton.Name = "AddDiscoundButton";
            this.AddDiscoundButton.Size = new System.Drawing.Size(102, 58);
            this.AddDiscoundButton.TabIndex = 32;
            this.AddDiscoundButton.Text = "Add";
            this.AddDiscoundButton.UseVisualStyleBackColor = true;
            this.AddDiscoundButton.Click += new System.EventHandler(this.AddDiscoundButton_Click);
            // 
            // RemoveDiscoundButton
            // 
            this.RemoveDiscoundButton.Location = new System.Drawing.Point(557, 325);
            this.RemoveDiscoundButton.Name = "RemoveDiscoundButton";
            this.RemoveDiscoundButton.Size = new System.Drawing.Size(102, 57);
            this.RemoveDiscoundButton.TabIndex = 33;
            this.RemoveDiscoundButton.Text = "Remove";
            this.RemoveDiscoundButton.UseVisualStyleBackColor = true;
            this.RemoveDiscoundButton.Click += new System.EventHandler(this.RemoveDiscoundButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveDiscoundButton);
            this.Controls.Add(this.AddDiscoundButton);
            this.Controls.Add(this.DiscountsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsPriorityCheckBox);
            this.Controls.Add(this.SelectedCustomerAddressControl);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.SelectedCustomerFullNameTextBox);
            this.Controls.Add(this.SelectedCustomerIdTextBox);
            this.Controls.Add(this.SelectedCustomerFullNameLabel);
            this.Controls.Add(this.SelectedCustomerIdLabel);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(806, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox SelectedCustomerFullNameTextBox;
        private System.Windows.Forms.TextBox SelectedCustomerIdTextBox;
        private System.Windows.Forms.Label SelectedCustomerFullNameLabel;
        private System.Windows.Forms.Label SelectedCustomerIdLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private Controls.AddressControl SelectedCustomerAddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button AddDiscoundButton;
        private System.Windows.Forms.Button RemoveDiscoundButton;
    }
}
