namespace ObjectOrientedProgramming.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdLabel = new System.Windows.Forms.Label();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.SelectedItemInfoLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCategoryLabel = new System.Windows.Forms.Label();
            this.SelectedItemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.OpenSIFormButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SortsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(7, 11);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(37, 13);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(10, 53);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(266, 238);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(10, 325);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(80, 28);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Location = new System.Drawing.Point(96, 325);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(80, 28);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(298, 11);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // SelectedItemIdLabel
            // 
            this.SelectedItemIdLabel.AutoSize = true;
            this.SelectedItemIdLabel.Location = new System.Drawing.Point(298, 40);
            this.SelectedItemIdLabel.Name = "SelectedItemIdLabel";
            this.SelectedItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedItemIdLabel.TabIndex = 5;
            this.SelectedItemIdLabel.Text = "ID:";
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.AutoSize = true;
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(298, 69);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.SelectedItemCostLabel.TabIndex = 6;
            this.SelectedItemCostLabel.Text = "Cost:";
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.AutoSize = true;
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(298, 125);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedItemNameLabel.TabIndex = 7;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemInfoLabel
            // 
            this.SelectedItemInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemInfoLabel.AutoSize = true;
            this.SelectedItemInfoLabel.Location = new System.Drawing.Point(298, 206);
            this.SelectedItemInfoLabel.Name = "SelectedItemInfoLabel";
            this.SelectedItemInfoLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectedItemInfoLabel.TabIndex = 8;
            this.SelectedItemInfoLabel.Text = "Description:";
            // 
            // SelectedItemIdTextBox
            // 
            this.SelectedItemIdTextBox.Location = new System.Drawing.Point(356, 40);
            this.SelectedItemIdTextBox.Name = "SelectedItemIdTextBox";
            this.SelectedItemIdTextBox.ReadOnly = true;
            this.SelectedItemIdTextBox.Size = new System.Drawing.Size(117, 20);
            this.SelectedItemIdTextBox.TabIndex = 9;
            // 
            // SelectedItemCostTextBox
            // 
            this.SelectedItemCostTextBox.Location = new System.Drawing.Point(356, 66);
            this.SelectedItemCostTextBox.Name = "SelectedItemCostTextBox";
            this.SelectedItemCostTextBox.Size = new System.Drawing.Size(117, 20);
            this.SelectedItemCostTextBox.TabIndex = 10;
            // 
            // SelectedItemNameTextBox
            // 
            this.SelectedItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemNameTextBox.Location = new System.Drawing.Point(301, 141);
            this.SelectedItemNameTextBox.Multiline = true;
            this.SelectedItemNameTextBox.Name = "SelectedItemNameTextBox";
            this.SelectedItemNameTextBox.Size = new System.Drawing.Size(491, 62);
            this.SelectedItemNameTextBox.TabIndex = 11;
            // 
            // SelectedItemInfoTextBox
            // 
            this.SelectedItemInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemInfoTextBox.Location = new System.Drawing.Point(301, 222);
            this.SelectedItemInfoTextBox.Multiline = true;
            this.SelectedItemInfoTextBox.Name = "SelectedItemInfoTextBox";
            this.SelectedItemInfoTextBox.Size = new System.Drawing.Size(491, 95);
            this.SelectedItemInfoTextBox.TabIndex = 12;
            // 
            // SelectedItemCategoryLabel
            // 
            this.SelectedItemCategoryLabel.AutoSize = true;
            this.SelectedItemCategoryLabel.Location = new System.Drawing.Point(298, 95);
            this.SelectedItemCategoryLabel.Name = "SelectedItemCategoryLabel";
            this.SelectedItemCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.SelectedItemCategoryLabel.TabIndex = 14;
            this.SelectedItemCategoryLabel.Text = "Category:";
            // 
            // SelectedItemCategoryComboBox
            // 
            this.SelectedItemCategoryComboBox.FormattingEnabled = true;
            this.SelectedItemCategoryComboBox.Location = new System.Drawing.Point(356, 92);
            this.SelectedItemCategoryComboBox.Name = "SelectedItemCategoryComboBox";
            this.SelectedItemCategoryComboBox.Size = new System.Drawing.Size(117, 21);
            this.SelectedItemCategoryComboBox.TabIndex = 15;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.Location = new System.Drawing.Point(694, 325);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(98, 28);
            this.SaveChangesButton.TabIndex = 16;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // OpenSIFormButton
            // 
            this.OpenSIFormButton.Location = new System.Drawing.Point(656, 0);
            this.OpenSIFormButton.Name = "OpenSIFormButton";
            this.OpenSIFormButton.Size = new System.Drawing.Size(150, 23);
            this.OpenSIFormButton.TabIndex = 17;
            this.OpenSIFormButton.Text = "Standard Interfaces";
            this.OpenSIFormButton.UseVisualStyleBackColor = true;
            this.OpenSIFormButton.Click += new System.EventHandler(this.OpenSIFormButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(44, 27);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(232, 20);
            this.SearchTextBox.TabIndex = 19;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Find:";
            // 
            // SortsComboBox
            // 
            this.SortsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SortsComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Name",
            "Cost (Ascending)",
            "Cost (Descending)"});
            this.SortsComboBox.FormattingEnabled = true;
            this.SortsComboBox.Items.AddRange(new object[] {
            "Name",
            "Cost (Ascending)",
            "Cost (Descending)"});
            this.SortsComboBox.Location = new System.Drawing.Point(65, 297);
            this.SortsComboBox.Name = "SortsComboBox";
            this.SortsComboBox.Size = new System.Drawing.Size(211, 21);
            this.SortsComboBox.TabIndex = 21;
            this.SortsComboBox.SelectedIndexChanged += new System.EventHandler(this.SortsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sort by:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.SortsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenSIFormButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.SelectedItemCategoryComboBox);
            this.Controls.Add(this.SelectedItemCategoryLabel);
            this.Controls.Add(this.SelectedItemInfoTextBox);
            this.Controls.Add(this.SelectedItemNameTextBox);
            this.Controls.Add(this.SelectedItemCostTextBox);
            this.Controls.Add(this.SelectedItemIdTextBox);
            this.Controls.Add(this.SelectedItemInfoLabel);
            this.Controls.Add(this.SelectedItemNameLabel);
            this.Controls.Add(this.SelectedItemCostLabel);
            this.Controls.Add(this.SelectedItemIdLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(806, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label SelectedItemIdLabel;
        private System.Windows.Forms.Label SelectedItemCostLabel;
        private System.Windows.Forms.Label SelectedItemNameLabel;
        private System.Windows.Forms.Label SelectedItemInfoLabel;
        private System.Windows.Forms.TextBox SelectedItemIdTextBox;
        private System.Windows.Forms.TextBox SelectedItemCostTextBox;
        private System.Windows.Forms.TextBox SelectedItemNameTextBox;
        private System.Windows.Forms.TextBox SelectedItemInfoTextBox;
        private System.Windows.Forms.Label SelectedItemCategoryLabel;
        private System.Windows.Forms.ComboBox SelectedItemCategoryComboBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button OpenSIFormButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortsComboBox;
        private System.Windows.Forms.Label label2;
    }
}
