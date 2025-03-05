namespace Programming.View
{
    partial class RectanglesGroupBox
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
            groupBox1 = new GroupBox();
            IdOfRectangleLabel = new Label();
            IdOfRectangleTextBox = new TextBox();
            YCentreOfRectangleTextBox = new TextBox();
            XCentreOfRectangleTextBox = new TextBox();
            YCentreOfRectangleLabel = new Label();
            XCentreOfRectangleLabel = new Label();
            FindRectangleWithMaxWidthButton = new Button();
            ColorTextBox = new TextBox();
            LengthTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthLabel = new Label();
            WidthLabel = new Label();
            ColorLabel = new Label();
            RectanglesListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IdOfRectangleLabel);
            groupBox1.Controls.Add(IdOfRectangleTextBox);
            groupBox1.Controls.Add(YCentreOfRectangleTextBox);
            groupBox1.Controls.Add(XCentreOfRectangleTextBox);
            groupBox1.Controls.Add(YCentreOfRectangleLabel);
            groupBox1.Controls.Add(XCentreOfRectangleLabel);
            groupBox1.Controls.Add(FindRectangleWithMaxWidthButton);
            groupBox1.Controls.Add(ColorTextBox);
            groupBox1.Controls.Add(LengthTextBox);
            groupBox1.Controls.Add(WidthTextBox);
            groupBox1.Controls.Add(LengthLabel);
            groupBox1.Controls.Add(WidthLabel);
            groupBox1.Controls.Add(ColorLabel);
            groupBox1.Controls.Add(RectanglesListBox);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 221);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // IdOfRectangleLabel
            // 
            IdOfRectangleLabel.AutoSize = true;
            IdOfRectangleLabel.Location = new Point(260, 110);
            IdOfRectangleLabel.Name = "IdOfRectangleLabel";
            IdOfRectangleLabel.Size = new Size(20, 15);
            IdOfRectangleLabel.TabIndex = 10;
            IdOfRectangleLabel.Text = "Id:";
            // 
            // IdOfRectangleTextBox
            // 
            IdOfRectangleTextBox.Location = new Point(260, 128);
            IdOfRectangleTextBox.Name = "IdOfRectangleTextBox";
            IdOfRectangleTextBox.ReadOnly = true;
            IdOfRectangleTextBox.Size = new Size(100, 23);
            IdOfRectangleTextBox.TabIndex = 9;
            // 
            // YCentreOfRectangleTextBox
            // 
            YCentreOfRectangleTextBox.Location = new Point(260, 84);
            YCentreOfRectangleTextBox.Name = "YCentreOfRectangleTextBox";
            YCentreOfRectangleTextBox.ReadOnly = true;
            YCentreOfRectangleTextBox.Size = new Size(100, 23);
            YCentreOfRectangleTextBox.TabIndex = 8;
            // 
            // XCentreOfRectangleTextBox
            // 
            XCentreOfRectangleTextBox.Location = new Point(260, 40);
            XCentreOfRectangleTextBox.Name = "XCentreOfRectangleTextBox";
            XCentreOfRectangleTextBox.ReadOnly = true;
            XCentreOfRectangleTextBox.Size = new Size(100, 23);
            XCentreOfRectangleTextBox.TabIndex = 7;
            // 
            // YCentreOfRectangleLabel
            // 
            YCentreOfRectangleLabel.AutoSize = true;
            YCentreOfRectangleLabel.Location = new Point(260, 66);
            YCentreOfRectangleLabel.Name = "YCentreOfRectangleLabel";
            YCentreOfRectangleLabel.Size = new Size(55, 15);
            YCentreOfRectangleLabel.TabIndex = 6;
            YCentreOfRectangleLabel.Text = "Centre Y:";
            // 
            // XCentreOfRectangleLabel
            // 
            XCentreOfRectangleLabel.AutoSize = true;
            XCentreOfRectangleLabel.Location = new Point(260, 22);
            XCentreOfRectangleLabel.Name = "XCentreOfRectangleLabel";
            XCentreOfRectangleLabel.Size = new Size(55, 15);
            XCentreOfRectangleLabel.TabIndex = 5;
            XCentreOfRectangleLabel.Text = "Centre X:";
            // 
            // FindRectangleWithMaxWidthButton
            // 
            FindRectangleWithMaxWidthButton.AllowDrop = true;
            FindRectangleWithMaxWidthButton.Location = new Point(132, 168);
            FindRectangleWithMaxWidthButton.Name = "FindRectangleWithMaxWidthButton";
            FindRectangleWithMaxWidthButton.Size = new Size(100, 23);
            FindRectangleWithMaxWidthButton.TabIndex = 1;
            FindRectangleWithMaxWidthButton.Text = "Find";
            FindRectangleWithMaxWidthButton.UseVisualStyleBackColor = true;
            FindRectangleWithMaxWidthButton.Click += FindRectangleWithMaxWidthButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(132, 128);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 4;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(132, 40);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 2;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(132, 84);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 3;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(132, 22);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(47, 15);
            LengthLabel.TabIndex = 2;
            LengthLabel.Text = "Length:";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(132, 66);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 1;
            WidthLabel.Text = "Width:";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(132, 110);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(39, 15);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(120, 169);
            RectanglesListBox.TabIndex = 1;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesGroupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "RectanglesGroupBox";
            Size = new Size(386, 221);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label IdOfRectangleLabel;
        private TextBox IdOfRectangleTextBox;
        private TextBox YCentreOfRectangleTextBox;
        private TextBox XCentreOfRectangleTextBox;
        private Label YCentreOfRectangleLabel;
        private Label XCentreOfRectangleLabel;
        private Button FindRectangleWithMaxWidthButton;
        private TextBox ColorTextBox;
        private TextBox LengthTextBox;
        private TextBox WidthTextBox;
        private Label LengthLabel;
        private Label WidthLabel;
        private Label ColorLabel;
        private ListBox RectanglesListBox;
    }
}
