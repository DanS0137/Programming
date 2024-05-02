namespace Programming.View
{
    partial class RectanglesCollisionControl
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
            DeleteRectangleButton = new Button();
            AddRectangleButton = new Button();
            RectanglesPanel = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LengthOfRectangleTextBox = new TextBox();
            IdOfRectangleTextBox = new TextBox();
            XOfRectangleTextBox = new TextBox();
            YOfRectangleTextBox = new TextBox();
            WidthOfRectangleTextBox = new TextBox();
            SelectedRectangleLabel = new Label();
            RectanglesLabel = new Label();
            RectanglesListBox = new ListBox();
            SuspendLayout();
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.ForeColor = SystemColors.ControlText;
            DeleteRectangleButton.Location = new Point(147, 237);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(115, 29);
            DeleteRectangleButton.TabIndex = 31;
            DeleteRectangleButton.Text = "Delete Rectangle";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.ForeColor = SystemColors.ControlText;
            AddRectangleButton.Location = new Point(40, 237);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(101, 29);
            AddRectangleButton.TabIndex = 30;
            AddRectangleButton.Text = "Add Rectangle";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(281, 10);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(498, 430);
            RectanglesPanel.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 333);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 28;
            label5.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 362);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 27;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 391);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 26;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 420);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 25;
            label2.Text = "Length:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 304);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 24;
            label1.Text = "Id:";
            // 
            // LengthOfRectangleTextBox
            // 
            LengthOfRectangleTextBox.Location = new Point(127, 417);
            LengthOfRectangleTextBox.Name = "LengthOfRectangleTextBox";
            LengthOfRectangleTextBox.Size = new Size(100, 23);
            LengthOfRectangleTextBox.TabIndex = 23;
            LengthOfRectangleTextBox.TextChanged += LengthOfRectangleTextBox_TextChanged;
            // 
            // IdOfRectangleTextBox
            // 
            IdOfRectangleTextBox.Location = new Point(127, 301);
            IdOfRectangleTextBox.Name = "IdOfRectangleTextBox";
            IdOfRectangleTextBox.ReadOnly = true;
            IdOfRectangleTextBox.Size = new Size(100, 23);
            IdOfRectangleTextBox.TabIndex = 22;
            // 
            // XOfRectangleTextBox
            // 
            XOfRectangleTextBox.Location = new Point(127, 330);
            XOfRectangleTextBox.Name = "XOfRectangleTextBox";
            XOfRectangleTextBox.Size = new Size(100, 23);
            XOfRectangleTextBox.TabIndex = 21;
            XOfRectangleTextBox.TextChanged += XOfRectangleTextBox_TextChanged;
            // 
            // YOfRectangleTextBox
            // 
            YOfRectangleTextBox.Location = new Point(127, 359);
            YOfRectangleTextBox.Name = "YOfRectangleTextBox";
            YOfRectangleTextBox.Size = new Size(100, 23);
            YOfRectangleTextBox.TabIndex = 20;
            YOfRectangleTextBox.TextChanged += YOfRectangleTextBox_TextChanged;
            // 
            // WidthOfRectangleTextBox
            // 
            WidthOfRectangleTextBox.Location = new Point(127, 388);
            WidthOfRectangleTextBox.Name = "WidthOfRectangleTextBox";
            WidthOfRectangleTextBox.Size = new Size(100, 23);
            WidthOfRectangleTextBox.TabIndex = 19;
            WidthOfRectangleTextBox.TextChanged += WidthOfRectangleTextBox_TextChanged;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(15, 275);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(106, 15);
            SelectedRectangleLabel.TabIndex = 18;
            SelectedRectangleLabel.Text = "Selected rectangle:";
            // 
            // RectanglesLabel
            // 
            RectanglesLabel.AutoSize = true;
            RectanglesLabel.Location = new Point(3, 10);
            RectanglesLabel.Name = "RectanglesLabel";
            RectanglesLabel.Size = new Size(67, 15);
            RectanglesLabel.TabIndex = 17;
            RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(3, 28);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(272, 199);
            RectanglesListBox.TabIndex = 16;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteRectangleButton);
            Controls.Add(AddRectangleButton);
            Controls.Add(RectanglesPanel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LengthOfRectangleTextBox);
            Controls.Add(IdOfRectangleTextBox);
            Controls.Add(XOfRectangleTextBox);
            Controls.Add(YOfRectangleTextBox);
            Controls.Add(WidthOfRectangleTextBox);
            Controls.Add(SelectedRectangleLabel);
            Controls.Add(RectanglesLabel);
            Controls.Add(RectanglesListBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(789, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private Panel RectanglesPanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox LengthOfRectangleTextBox;
        private TextBox IdOfRectangleTextBox;
        private TextBox XOfRectangleTextBox;
        private TextBox YOfRectangleTextBox;
        private TextBox WidthOfRectangleTextBox;
        private Label SelectedRectangleLabel;
        private Label RectanglesLabel;
        private ListBox RectanglesListBox;
    }
}
