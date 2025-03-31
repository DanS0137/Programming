namespace Programming.View
{
    partial class EnumerationsGroupBox
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
            Enumerations = new GroupBox();
            EnumsListBox = new ListBox();
            ValuesListBox = new ListBox();
            ValueOfSelectedValue = new TextBox();
            ChooseValue = new Label();
            IntValue = new Label();
            ChooseEnumeration = new Label();
            Enumerations.SuspendLayout();
            SuspendLayout();
            // 
            // Enumerations
            // 
            Enumerations.Controls.Add(EnumsListBox);
            Enumerations.Controls.Add(ValuesListBox);
            Enumerations.Controls.Add(ValueOfSelectedValue);
            Enumerations.Controls.Add(ChooseValue);
            Enumerations.Controls.Add(IntValue);
            Enumerations.Controls.Add(ChooseEnumeration);
            Enumerations.Location = new Point(0, 0);
            Enumerations.Name = "Enumerations";
            Enumerations.Size = new Size(480, 263);
            Enumerations.TabIndex = 16;
            Enumerations.TabStop = false;
            Enumerations.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufacture", "Season", "Weekday" });
            EnumsListBox.Location = new Point(15, 43);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(140, 139);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Items.AddRange(new object[] { "White", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Black" });
            ValuesListBox.Location = new Point(175, 43);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.ScrollAlwaysVisible = true;
            ValuesListBox.Size = new Size(140, 139);
            ValuesListBox.TabIndex = 1;
            // 
            // ValueOfSelectedValue
            // 
            ValueOfSelectedValue.Location = new Point(335, 43);
            ValueOfSelectedValue.Name = "ValueOfSelectedValue";
            ValueOfSelectedValue.Size = new Size(124, 23);
            ValueOfSelectedValue.TabIndex = 5;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ChooseValue
            // 
            ChooseValue.AutoSize = true;
            ChooseValue.Location = new Point(175, 25);
            ChooseValue.Name = "ChooseValue";
            ChooseValue.Size = new Size(81, 15);
            ChooseValue.TabIndex = 3;
            ChooseValue.Text = "Choose value:";
            // 
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.Location = new Point(335, 25);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(55, 15);
            IntValue.TabIndex = 4;
            IntValue.Text = "Int value:";
            // 
            // ChooseEnumeration
            // 
            ChooseEnumeration.AutoSize = true;
            ChooseEnumeration.Location = new Point(15, 25);
            ChooseEnumeration.Name = "ChooseEnumeration";
            ChooseEnumeration.Size = new Size(121, 15);
            ChooseEnumeration.TabIndex = 2;
            ChooseEnumeration.Text = "Choose enumeration:";
            // 
            // EnumerationsGroupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Enumerations);
            Name = "EnumerationsGroupBox";
            Size = new Size(480, 263);
            Enumerations.ResumeLayout(false);
            Enumerations.PerformLayout();
            ResumeLayout(false);
        }

        private void ValuesListBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EnumsListBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ValuesListBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox Enumerations;
        private ListBox EnumsListBox;
        public ListBox ValuesListBox;
        private TextBox ValueOfSelectedValue;
        private Label ChooseValue;
        private Label IntValue;
        private Label ChooseEnumeration;
    }
}
