using System;

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
            ObjectOrientedProgramming.Model.PriorityOrder priorityOrder1 = new ObjectOrientedProgramming.Model.PriorityOrder();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.PriorityOrdersTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedProgramming.View.Tabs.ItemsTab();
            this.CustomersTab = new ObjectOrientedProgramming.View.Tabs.CustomersTab();
            this.CartsTab = new ObjectOrientedProgramming.View.Tabs.CartsTab();
            this.OrdersTab = new ObjectOrientedProgramming.View.Tabs.OrdersTab();
            this.PriorityOrdersTab = new ObjectOrientedProgramming.View.Tabs.PriorityOrdersTab();
            this.tabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.PriorityOrdersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ItemsTabPage);
            this.tabControl.Controls.Add(this.CustomersTabPage);
            this.tabControl.Controls.Add(this.CartsTabPage);
            this.tabControl.Controls.Add(this.OrdersTabPage);
            this.tabControl.Controls.Add(this.PriorityOrdersTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(971, 471);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(963, 445);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(963, 445);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Size = new System.Drawing.Size(963, 445);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Size = new System.Drawing.Size(963, 445);
            this.OrdersTabPage.TabIndex = 3;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTabPage
            // 
            this.PriorityOrdersTabPage.Controls.Add(this.PriorityOrdersTab);
            this.PriorityOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.PriorityOrdersTabPage.Name = "PriorityOrdersTabPage";
            this.PriorityOrdersTabPage.Size = new System.Drawing.Size(963, 445);
            this.PriorityOrdersTabPage.TabIndex = 4;
            this.PriorityOrdersTabPage.Text = "Priority Orders";
            this.PriorityOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Items = null;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(957, 439);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Customers = null;
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(957, 439);
            this.CustomersTab.TabIndex = 0;
            // 
            // CartsTab
            // 
            this.CartsTab.Customers = null;
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Items = null;
            this.CartsTab.Location = new System.Drawing.Point(0, 0);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(963, 445);
            this.CartsTab.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Customers = null;
            this.OrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab.Location = new System.Drawing.Point(0, 0);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Orders = null;
            this.OrdersTab.Size = new System.Drawing.Size(963, 445);
            this.OrdersTab.TabIndex = 0;
            // 
            // PriorityOrdersTab
            // 
            priorityOrder1.Address = null;
            priorityOrder1.Date = new System.DateTime(((long)(0)));
            priorityOrder1.Items = ((System.Collections.Generic.List<ObjectOrientedProgramming.Model.Item>)(resources.GetObject("priorityOrder1.Items")));
            priorityOrder1.OrderStatus = ObjectOrientedProgramming.Model.Enumerations.OrderStatus.New;
            priorityOrder1.TimeOfDelivery = ObjectOrientedProgramming.Model.Enumerations.TimeOfDelivery.NineToEleven;
            this.PriorityOrdersTab.CurrentOrder = priorityOrder1;
            this.PriorityOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOrdersTab.Items = null;
            this.PriorityOrdersTab.Location = new System.Drawing.Point(0, 0);
            this.PriorityOrdersTab.Name = "PriorityOrdersTab";
            this.PriorityOrdersTab.Size = new System.Drawing.Size(963, 445);
            this.PriorityOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 471);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.PriorityOrdersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.CustomersTab CustomersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private View.Tabs.CartsTab CartsTab;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private System.Windows.Forms.TabPage PriorityOrdersTabPage;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab;
    }
}

