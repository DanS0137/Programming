namespace ObjectOrientedProgramming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedProgramming.View.Tabs.ItemsTab();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedProgramming.View.Tabs.CustomersTab();
            this.tabControl1.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ItemsTabPage);
            this.tabControl1.Controls.Add(this.CustomersTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.itemsTab1);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(813, 365);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(807, 359);
            this.itemsTab1.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.customersTab1);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(813, 365);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(807, 359);
            this.customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl1.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.CustomersTab customersTab1;
    }
}

