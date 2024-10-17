namespace ListOfNotes.View
{
    partial class MessageForm
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
            MessageLabel = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // MessageLabel
            // 
            MessageLabel.Dock = DockStyle.Top;
            MessageLabel.Location = new Point(0, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(531, 61);
            MessageLabel.TabIndex = 0;
            MessageLabel.Text = "label1";
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(225, 64);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 87);
            Controls.Add(OkButton);
            Controls.Add(MessageLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Предупреждение!";
            ResumeLayout(false);
        }

        #endregion

        public Label MessageLabel;
        private Button OkButton;
    }
}