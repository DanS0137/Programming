namespace ObjectOrientedProgramming.View
{
    partial class StandardInterfacesTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardInterfacesTestForm));
            this.standardInterfacesTab = new ObjectOrientedProgramming.View.Tabs.StandardInterfacesTab();
            this.standardInterfacesTab1 = new ObjectOrientedProgramming.View.Tabs.StandardInterfacesTab();
            this.SuspendLayout();
            // 
            // standardInterfacesTab
            // 
            this.standardInterfacesTab.Location = new System.Drawing.Point(0, 0);
            this.standardInterfacesTab.Name = "standardInterfacesTab";
            this.standardInterfacesTab.Size = new System.Drawing.Size(1472, 603);
            this.standardInterfacesTab.TabIndex = 0;
            // 
            // standardInterfacesTab1
            // 
            this.standardInterfacesTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardInterfacesTab1.Location = new System.Drawing.Point(0, 0);
            this.standardInterfacesTab1.Name = "standardInterfacesTab1";
            this.standardInterfacesTab1.Size = new System.Drawing.Size(1468, 558);
            this.standardInterfacesTab1.TabIndex = 0;
            // 
            // StandardInterfacesTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 558);
            this.Controls.Add(this.standardInterfacesTab1);
            this.Name = "StandardInterfacesTestForm";
            this.Text = "StandardIntefacesTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private View.Tabs.StandardInterfacesTab standardInterfacesTab;
        private Tabs.StandardInterfacesTab standardInterfacesTab1;
    }
}