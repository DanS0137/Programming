namespace ObjectOrientedProgramming.View.Tabs
{
    partial class StandardInterfacesTab
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
            ObjectOrientedProgramming.Model.Address address2 = new ObjectOrientedProgramming.Model.Address();
            ObjectOrientedProgramming.Model.Address address3 = new ObjectOrientedProgramming.Model.Address();
            ObjectOrientedProgramming.Model.Address address4 = new ObjectOrientedProgramming.Model.Address();
            this.ICloneablePanel = new System.Windows.Forms.Panel();
            this.ClonedCartListBox = new System.Windows.Forms.ListBox();
            this.CloneCartButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.CloneAddressButton = new System.Windows.Forms.Button();
            this.ClonedAddressControl = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.OrigAddressControl = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.CloneItemButton = new System.Windows.Forms.Button();
            this.ClonedItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IEquatablesPanel = new System.Windows.Forms.Panel();
            this.AreAdressesEqualTextBox = new System.Windows.Forms.TextBox();
            this.AreAdressesEqualButton = new System.Windows.Forms.Button();
            this.AddressControl22 = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.AddressControl21 = new ObjectOrientedProgramming.View.Controls.AddressControl();
            this.AreItemsEqualTextBox = new System.Windows.Forms.TextBox();
            this.AreItemsEqualButton = new System.Windows.Forms.Button();
            this.ItemsListBox2 = new System.Windows.Forms.ListBox();
            this.ItemsListBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IComparablePanel = new System.Windows.Forms.Panel();
            this.AddDiscountButton22 = new System.Windows.Forms.Button();
            this.AddDiscountButton21 = new System.Windows.Forms.Button();
            this.ComparingPercentsTextBox = new System.Windows.Forms.TextBox();
            this.ComparePercentsButton = new System.Windows.Forms.Button();
            this.PercentsDiscountListBox2 = new System.Windows.Forms.ListBox();
            this.PercentsDiscountListBox1 = new System.Windows.Forms.ListBox();
            this.AddDiscountButton2 = new System.Windows.Forms.Button();
            this.AddDiscountButton1 = new System.Windows.Forms.Button();
            this.ComparingPointsTextBox = new System.Windows.Forms.TextBox();
            this.ComparePointsButton = new System.Windows.Forms.Button();
            this.PointsDiscountListBox2 = new System.Windows.Forms.ListBox();
            this.PointsDiscountListBox1 = new System.Windows.Forms.ListBox();
            this.ComparingCostsTextBox = new System.Windows.Forms.TextBox();
            this.CompareCostsButton = new System.Windows.Forms.Button();
            this.ItemsListBox22 = new System.Windows.Forms.ListBox();
            this.ItemsListBox21 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ICloneablePanel.SuspendLayout();
            this.IEquatablesPanel.SuspendLayout();
            this.IComparablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ICloneablePanel
            // 
            this.ICloneablePanel.Controls.Add(this.ClonedCartListBox);
            this.ICloneablePanel.Controls.Add(this.CloneCartButton);
            this.ICloneablePanel.Controls.Add(this.AddItemButton);
            this.ICloneablePanel.Controls.Add(this.CartListBox);
            this.ICloneablePanel.Controls.Add(this.CloneAddressButton);
            this.ICloneablePanel.Controls.Add(this.ClonedAddressControl);
            this.ICloneablePanel.Controls.Add(this.OrigAddressControl);
            this.ICloneablePanel.Controls.Add(this.CloneItemButton);
            this.ICloneablePanel.Controls.Add(this.ClonedItemsListBox);
            this.ICloneablePanel.Controls.Add(this.ItemsListBox);
            this.ICloneablePanel.Controls.Add(this.label1);
            this.ICloneablePanel.Location = new System.Drawing.Point(0, 0);
            this.ICloneablePanel.Name = "ICloneablePanel";
            this.ICloneablePanel.Size = new System.Drawing.Size(497, 600);
            this.ICloneablePanel.TabIndex = 0;
            // 
            // ClonedCartListBox
            // 
            this.ClonedCartListBox.FormattingEnabled = true;
            this.ClonedCartListBox.Location = new System.Drawing.Point(261, 432);
            this.ClonedCartListBox.Name = "ClonedCartListBox";
            this.ClonedCartListBox.Size = new System.Drawing.Size(166, 95);
            this.ClonedCartListBox.TabIndex = 10;
            // 
            // CloneCartButton
            // 
            this.CloneCartButton.Location = new System.Drawing.Point(180, 470);
            this.CloneCartButton.Name = "CloneCartButton";
            this.CloneCartButton.Size = new System.Drawing.Size(75, 23);
            this.CloneCartButton.TabIndex = 9;
            this.CloneCartButton.Text = "Clone Cart";
            this.CloneCartButton.UseVisualStyleBackColor = true;
            this.CloneCartButton.Click += new System.EventHandler(this.CloneCartButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(8, 533);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(166, 23);
            this.AddItemButton.TabIndex = 8;
            this.AddItemButton.Text = "Add Random Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(8, 432);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(166, 95);
            this.CartListBox.TabIndex = 7;
            // 
            // CloneAddressButton
            // 
            this.CloneAddressButton.Location = new System.Drawing.Point(223, 263);
            this.CloneAddressButton.Name = "CloneAddressButton";
            this.CloneAddressButton.Size = new System.Drawing.Size(91, 23);
            this.CloneAddressButton.TabIndex = 6;
            this.CloneAddressButton.Text = "Clone Address";
            this.CloneAddressButton.UseVisualStyleBackColor = true;
            this.CloneAddressButton.Click += new System.EventHandler(this.CloneAddressButton_Click);
            // 
            // ClonedAddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.ClonedAddressControl.Address = address1;
            this.ClonedAddressControl.Location = new System.Drawing.Point(2, 292);
            this.ClonedAddressControl.Name = "ClonedAddressControl";
            this.ClonedAddressControl.Size = new System.Drawing.Size(495, 117);
            this.ClonedAddressControl.TabIndex = 5;
            // 
            // OrigAddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            this.OrigAddressControl.Address = address2;
            this.OrigAddressControl.Location = new System.Drawing.Point(2, 132);
            this.OrigAddressControl.Name = "OrigAddressControl";
            this.OrigAddressControl.Size = new System.Drawing.Size(495, 117);
            this.OrigAddressControl.TabIndex = 4;
            // 
            // CloneItemButton
            // 
            this.CloneItemButton.Location = new System.Drawing.Point(178, 65);
            this.CloneItemButton.Name = "CloneItemButton";
            this.CloneItemButton.Size = new System.Drawing.Size(75, 23);
            this.CloneItemButton.TabIndex = 3;
            this.CloneItemButton.Text = "Clone Item";
            this.CloneItemButton.UseVisualStyleBackColor = true;
            this.CloneItemButton.Click += new System.EventHandler(this.CloneItemButton_Click);
            // 
            // ClonedItemsListBox
            // 
            this.ClonedItemsListBox.FormattingEnabled = true;
            this.ClonedItemsListBox.Location = new System.Drawing.Point(259, 31);
            this.ClonedItemsListBox.Name = "ClonedItemsListBox";
            this.ClonedItemsListBox.Size = new System.Drawing.Size(169, 95);
            this.ClonedItemsListBox.TabIndex = 2;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 31);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(169, 95);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ICloneable";
            // 
            // IEquatablesPanel
            // 
            this.IEquatablesPanel.Controls.Add(this.AreAdressesEqualTextBox);
            this.IEquatablesPanel.Controls.Add(this.AreAdressesEqualButton);
            this.IEquatablesPanel.Controls.Add(this.AddressControl22);
            this.IEquatablesPanel.Controls.Add(this.AddressControl21);
            this.IEquatablesPanel.Controls.Add(this.AreItemsEqualTextBox);
            this.IEquatablesPanel.Controls.Add(this.AreItemsEqualButton);
            this.IEquatablesPanel.Controls.Add(this.ItemsListBox2);
            this.IEquatablesPanel.Controls.Add(this.ItemsListBox1);
            this.IEquatablesPanel.Controls.Add(this.label2);
            this.IEquatablesPanel.Location = new System.Drawing.Point(501, 0);
            this.IEquatablesPanel.Name = "IEquatablesPanel";
            this.IEquatablesPanel.Size = new System.Drawing.Size(504, 413);
            this.IEquatablesPanel.TabIndex = 1;
            // 
            // AreAdressesEqualTextBox
            // 
            this.AreAdressesEqualTextBox.Location = new System.Drawing.Point(278, 265);
            this.AreAdressesEqualTextBox.Name = "AreAdressesEqualTextBox";
            this.AreAdressesEqualTextBox.ReadOnly = true;
            this.AreAdressesEqualTextBox.Size = new System.Drawing.Size(91, 20);
            this.AreAdressesEqualTextBox.TabIndex = 11;
            // 
            // AreAdressesEqualButton
            // 
            this.AreAdressesEqualButton.Location = new System.Drawing.Point(165, 263);
            this.AreAdressesEqualButton.Name = "AreAdressesEqualButton";
            this.AreAdressesEqualButton.Size = new System.Drawing.Size(91, 23);
            this.AreAdressesEqualButton.TabIndex = 10;
            this.AreAdressesEqualButton.Text = "Are Equal";
            this.AreAdressesEqualButton.UseVisualStyleBackColor = true;
            this.AreAdressesEqualButton.Click += new System.EventHandler(this.AreAdressesEqualButton_Click);
            // 
            // AddressControl22
            // 
            address3.Apartment = "";
            address3.Building = "";
            address3.City = "";
            address3.Country = "";
            address3.Index = 100000;
            address3.Street = "";
            this.AddressControl22.Address = address3;
            this.AddressControl22.Location = new System.Drawing.Point(6, 292);
            this.AddressControl22.Name = "AddressControl22";
            this.AddressControl22.Size = new System.Drawing.Size(495, 117);
            this.AddressControl22.TabIndex = 9;
            // 
            // AddressControl21
            // 
            address4.Apartment = "";
            address4.Building = "";
            address4.City = "";
            address4.Country = "";
            address4.Index = 100000;
            address4.Street = "";
            this.AddressControl21.Address = address4;
            this.AddressControl21.Location = new System.Drawing.Point(6, 132);
            this.AddressControl21.Name = "AddressControl21";
            this.AddressControl21.Size = new System.Drawing.Size(495, 117);
            this.AddressControl21.TabIndex = 8;
            // 
            // AreItemsEqualTextBox
            // 
            this.AreItemsEqualTextBox.Location = new System.Drawing.Point(181, 89);
            this.AreItemsEqualTextBox.Name = "AreItemsEqualTextBox";
            this.AreItemsEqualTextBox.ReadOnly = true;
            this.AreItemsEqualTextBox.Size = new System.Drawing.Size(75, 20);
            this.AreItemsEqualTextBox.TabIndex = 7;
            // 
            // AreItemsEqualButton
            // 
            this.AreItemsEqualButton.Location = new System.Drawing.Point(181, 44);
            this.AreItemsEqualButton.Name = "AreItemsEqualButton";
            this.AreItemsEqualButton.Size = new System.Drawing.Size(75, 23);
            this.AreItemsEqualButton.TabIndex = 6;
            this.AreItemsEqualButton.Text = "Are Equal";
            this.AreItemsEqualButton.UseVisualStyleBackColor = true;
            this.AreItemsEqualButton.Click += new System.EventHandler(this.AreItemsEqualButton_Click);
            // 
            // ItemsListBox2
            // 
            this.ItemsListBox2.FormattingEnabled = true;
            this.ItemsListBox2.Location = new System.Drawing.Point(262, 31);
            this.ItemsListBox2.Name = "ItemsListBox2";
            this.ItemsListBox2.Size = new System.Drawing.Size(169, 95);
            this.ItemsListBox2.TabIndex = 5;
            // 
            // ItemsListBox1
            // 
            this.ItemsListBox1.FormattingEnabled = true;
            this.ItemsListBox1.Location = new System.Drawing.Point(6, 31);
            this.ItemsListBox1.Name = "ItemsListBox1";
            this.ItemsListBox1.Size = new System.Drawing.Size(169, 95);
            this.ItemsListBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IEquatables";
            // 
            // IComparablePanel
            // 
            this.IComparablePanel.Controls.Add(this.AddDiscountButton22);
            this.IComparablePanel.Controls.Add(this.AddDiscountButton21);
            this.IComparablePanel.Controls.Add(this.ComparingPercentsTextBox);
            this.IComparablePanel.Controls.Add(this.ComparePercentsButton);
            this.IComparablePanel.Controls.Add(this.PercentsDiscountListBox2);
            this.IComparablePanel.Controls.Add(this.PercentsDiscountListBox1);
            this.IComparablePanel.Controls.Add(this.AddDiscountButton2);
            this.IComparablePanel.Controls.Add(this.AddDiscountButton1);
            this.IComparablePanel.Controls.Add(this.ComparingPointsTextBox);
            this.IComparablePanel.Controls.Add(this.ComparePointsButton);
            this.IComparablePanel.Controls.Add(this.PointsDiscountListBox2);
            this.IComparablePanel.Controls.Add(this.PointsDiscountListBox1);
            this.IComparablePanel.Controls.Add(this.ComparingCostsTextBox);
            this.IComparablePanel.Controls.Add(this.CompareCostsButton);
            this.IComparablePanel.Controls.Add(this.ItemsListBox22);
            this.IComparablePanel.Controls.Add(this.ItemsListBox21);
            this.IComparablePanel.Controls.Add(this.label3);
            this.IComparablePanel.Location = new System.Drawing.Point(1011, 0);
            this.IComparablePanel.Name = "IComparablePanel";
            this.IComparablePanel.Size = new System.Drawing.Size(461, 413);
            this.IComparablePanel.TabIndex = 2;
            // 
            // AddDiscountButton22
            // 
            this.AddDiscountButton22.Location = new System.Drawing.Point(323, 366);
            this.AddDiscountButton22.Name = "AddDiscountButton22";
            this.AddDiscountButton22.Size = new System.Drawing.Size(94, 23);
            this.AddDiscountButton22.TabIndex = 23;
            this.AddDiscountButton22.Text = "Add Discount";
            this.AddDiscountButton22.UseVisualStyleBackColor = true;
            this.AddDiscountButton22.Click += new System.EventHandler(this.AddDiscountButton22_Click);
            // 
            // AddDiscountButton21
            // 
            this.AddDiscountButton21.Location = new System.Drawing.Point(40, 366);
            this.AddDiscountButton21.Name = "AddDiscountButton21";
            this.AddDiscountButton21.Size = new System.Drawing.Size(94, 23);
            this.AddDiscountButton21.TabIndex = 22;
            this.AddDiscountButton21.Text = "Add Discount";
            this.AddDiscountButton21.UseVisualStyleBackColor = true;
            this.AddDiscountButton21.Click += new System.EventHandler(this.AddDiscountButton21_Click);
            // 
            // ComparingPercentsTextBox
            // 
            this.ComparingPercentsTextBox.Location = new System.Drawing.Point(181, 323);
            this.ComparingPercentsTextBox.Name = "ComparingPercentsTextBox";
            this.ComparingPercentsTextBox.ReadOnly = true;
            this.ComparingPercentsTextBox.Size = new System.Drawing.Size(94, 20);
            this.ComparingPercentsTextBox.TabIndex = 21;
            // 
            // ComparePercentsButton
            // 
            this.ComparePercentsButton.Location = new System.Drawing.Point(181, 278);
            this.ComparePercentsButton.Name = "ComparePercentsButton";
            this.ComparePercentsButton.Size = new System.Drawing.Size(94, 23);
            this.ComparePercentsButton.TabIndex = 20;
            this.ComparePercentsButton.Text = "Compare P-nts";
            this.ComparePercentsButton.UseVisualStyleBackColor = true;
            this.ComparePercentsButton.Click += new System.EventHandler(this.ComparePercentsButton_Click);
            // 
            // PercentsDiscountListBox2
            // 
            this.PercentsDiscountListBox2.FormattingEnabled = true;
            this.PercentsDiscountListBox2.Location = new System.Drawing.Point(281, 265);
            this.PercentsDiscountListBox2.Name = "PercentsDiscountListBox2";
            this.PercentsDiscountListBox2.Size = new System.Drawing.Size(169, 95);
            this.PercentsDiscountListBox2.TabIndex = 19;
            // 
            // PercentsDiscountListBox1
            // 
            this.PercentsDiscountListBox1.FormattingEnabled = true;
            this.PercentsDiscountListBox1.Location = new System.Drawing.Point(6, 265);
            this.PercentsDiscountListBox1.Name = "PercentsDiscountListBox1";
            this.PercentsDiscountListBox1.Size = new System.Drawing.Size(169, 95);
            this.PercentsDiscountListBox1.TabIndex = 18;
            // 
            // AddDiscountButton2
            // 
            this.AddDiscountButton2.Location = new System.Drawing.Point(323, 233);
            this.AddDiscountButton2.Name = "AddDiscountButton2";
            this.AddDiscountButton2.Size = new System.Drawing.Size(94, 23);
            this.AddDiscountButton2.TabIndex = 17;
            this.AddDiscountButton2.Text = "Add Discount";
            this.AddDiscountButton2.UseVisualStyleBackColor = true;
            this.AddDiscountButton2.Click += new System.EventHandler(this.AddDiscountButton2_Click);
            // 
            // AddDiscountButton1
            // 
            this.AddDiscountButton1.Location = new System.Drawing.Point(40, 233);
            this.AddDiscountButton1.Name = "AddDiscountButton1";
            this.AddDiscountButton1.Size = new System.Drawing.Size(94, 23);
            this.AddDiscountButton1.TabIndex = 16;
            this.AddDiscountButton1.Text = "Add Discount";
            this.AddDiscountButton1.UseVisualStyleBackColor = true;
            this.AddDiscountButton1.Click += new System.EventHandler(this.AddDiscountButton1_Click);
            // 
            // ComparingPointsTextBox
            // 
            this.ComparingPointsTextBox.Location = new System.Drawing.Point(181, 190);
            this.ComparingPointsTextBox.Name = "ComparingPointsTextBox";
            this.ComparingPointsTextBox.ReadOnly = true;
            this.ComparingPointsTextBox.Size = new System.Drawing.Size(94, 20);
            this.ComparingPointsTextBox.TabIndex = 15;
            // 
            // ComparePointsButton
            // 
            this.ComparePointsButton.Location = new System.Drawing.Point(181, 145);
            this.ComparePointsButton.Name = "ComparePointsButton";
            this.ComparePointsButton.Size = new System.Drawing.Size(94, 23);
            this.ComparePointsButton.TabIndex = 14;
            this.ComparePointsButton.Text = "Compare Points";
            this.ComparePointsButton.UseVisualStyleBackColor = true;
            this.ComparePointsButton.Click += new System.EventHandler(this.ComparePointsButton_Click);
            // 
            // PointsDiscountListBox2
            // 
            this.PointsDiscountListBox2.FormattingEnabled = true;
            this.PointsDiscountListBox2.Location = new System.Drawing.Point(281, 132);
            this.PointsDiscountListBox2.Name = "PointsDiscountListBox2";
            this.PointsDiscountListBox2.Size = new System.Drawing.Size(169, 95);
            this.PointsDiscountListBox2.TabIndex = 13;
            // 
            // PointsDiscountListBox1
            // 
            this.PointsDiscountListBox1.FormattingEnabled = true;
            this.PointsDiscountListBox1.Location = new System.Drawing.Point(6, 132);
            this.PointsDiscountListBox1.Name = "PointsDiscountListBox1";
            this.PointsDiscountListBox1.Size = new System.Drawing.Size(169, 95);
            this.PointsDiscountListBox1.TabIndex = 12;
            // 
            // ComparingCostsTextBox
            // 
            this.ComparingCostsTextBox.Location = new System.Drawing.Point(181, 85);
            this.ComparingCostsTextBox.Name = "ComparingCostsTextBox";
            this.ComparingCostsTextBox.ReadOnly = true;
            this.ComparingCostsTextBox.Size = new System.Drawing.Size(94, 20);
            this.ComparingCostsTextBox.TabIndex = 11;
            // 
            // CompareCostsButton
            // 
            this.CompareCostsButton.Location = new System.Drawing.Point(181, 40);
            this.CompareCostsButton.Name = "CompareCostsButton";
            this.CompareCostsButton.Size = new System.Drawing.Size(94, 23);
            this.CompareCostsButton.TabIndex = 10;
            this.CompareCostsButton.Text = "Compare Costs";
            this.CompareCostsButton.UseVisualStyleBackColor = true;
            this.CompareCostsButton.Click += new System.EventHandler(this.CompareCostsButton_Click);
            // 
            // ItemsListBox22
            // 
            this.ItemsListBox22.FormattingEnabled = true;
            this.ItemsListBox22.Location = new System.Drawing.Point(281, 27);
            this.ItemsListBox22.Name = "ItemsListBox22";
            this.ItemsListBox22.Size = new System.Drawing.Size(169, 95);
            this.ItemsListBox22.TabIndex = 9;
            // 
            // ItemsListBox21
            // 
            this.ItemsListBox21.FormattingEnabled = true;
            this.ItemsListBox21.Location = new System.Drawing.Point(6, 27);
            this.ItemsListBox21.Name = "ItemsListBox21";
            this.ItemsListBox21.Size = new System.Drawing.Size(169, 95);
            this.ItemsListBox21.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IComparables";
            // 
            // StandardInterfacesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IComparablePanel);
            this.Controls.Add(this.IEquatablesPanel);
            this.Controls.Add(this.ICloneablePanel);
            this.Name = "StandardInterfacesTab";
            this.Size = new System.Drawing.Size(1472, 603);
            this.ICloneablePanel.ResumeLayout(false);
            this.ICloneablePanel.PerformLayout();
            this.IEquatablesPanel.ResumeLayout(false);
            this.IEquatablesPanel.PerformLayout();
            this.IComparablePanel.ResumeLayout(false);
            this.IComparablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ICloneablePanel;
        private System.Windows.Forms.ListBox ClonedCartListBox;
        private System.Windows.Forms.Button CloneCartButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Button CloneAddressButton;
        private Controls.AddressControl ClonedAddressControl;
        private Controls.AddressControl OrigAddressControl;
        private System.Windows.Forms.Button CloneItemButton;
        private System.Windows.Forms.ListBox ClonedItemsListBox;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel IEquatablesPanel;
        private System.Windows.Forms.Button AreAdressesEqualButton;
        private Controls.AddressControl AddressControl22;
        private Controls.AddressControl AddressControl21;
        private System.Windows.Forms.TextBox AreItemsEqualTextBox;
        private System.Windows.Forms.Button AreItemsEqualButton;
        private System.Windows.Forms.ListBox ItemsListBox2;
        private System.Windows.Forms.ListBox ItemsListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel IComparablePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AreAdressesEqualTextBox;
        private System.Windows.Forms.Button AddDiscountButton22;
        private System.Windows.Forms.Button AddDiscountButton21;
        private System.Windows.Forms.TextBox ComparingPercentsTextBox;
        private System.Windows.Forms.Button ComparePercentsButton;
        private System.Windows.Forms.ListBox PercentsDiscountListBox2;
        private System.Windows.Forms.ListBox PercentsDiscountListBox1;
        private System.Windows.Forms.Button AddDiscountButton2;
        private System.Windows.Forms.Button AddDiscountButton1;
        private System.Windows.Forms.TextBox ComparingPointsTextBox;
        private System.Windows.Forms.Button ComparePointsButton;
        private System.Windows.Forms.ListBox PointsDiscountListBox2;
        private System.Windows.Forms.ListBox PointsDiscountListBox1;
        private System.Windows.Forms.TextBox ComparingCostsTextBox;
        private System.Windows.Forms.Button CompareCostsButton;
        private System.Windows.Forms.ListBox ItemsListBox22;
        private System.Windows.Forms.ListBox ItemsListBox21;
    }
}
