namespace Programming.View
{
    partial class WeekdayParsingGroupBox
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
            WeekdayParsing = new GroupBox();
            TypeValueForParsing = new Label();
            ValueForParsingBox = new TextBox();
            ResultOfParsing = new Label();
            ParseButton = new Button();
            WeekdayParsing.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Controls.Add(TypeValueForParsing);
            WeekdayParsing.Controls.Add(ValueForParsingBox);
            WeekdayParsing.Controls.Add(ResultOfParsing);
            WeekdayParsing.Controls.Add(ParseButton);
            WeekdayParsing.Location = new Point(0, 0);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Size = new Size(480, 139);
            WeekdayParsing.TabIndex = 17;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // TypeValueForParsing
            // 
            TypeValueForParsing.AutoSize = true;
            TypeValueForParsing.Location = new Point(15, 29);
            TypeValueForParsing.Name = "TypeValueForParsing";
            TypeValueForParsing.Size = new Size(127, 15);
            TypeValueForParsing.TabIndex = 6;
            TypeValueForParsing.Text = "Type value for parsing:";
            // 
            // ValueForParsingBox
            // 
            ValueForParsingBox.Location = new Point(15, 47);
            ValueForParsingBox.Name = "ValueForParsingBox";
            ValueForParsingBox.Size = new Size(140, 23);
            ValueForParsingBox.TabIndex = 7;
            // 
            // ResultOfParsing
            // 
            ResultOfParsing.AutoSize = true;
            ResultOfParsing.Location = new Point(15, 73);
            ResultOfParsing.Name = "ResultOfParsing";
            ResultOfParsing.Size = new Size(38, 15);
            ResultOfParsing.TabIndex = 8;
            ResultOfParsing.Text = "label1";
            ResultOfParsing.Visible = false;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(197, 46);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 23);
            ParseButton.TabIndex = 9;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // WeekdayParsingGroupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayParsing);
            Name = "WeekdayParsingGroupBox";
            Size = new Size(480, 139);
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private GroupBox WeekdayParsing;
        private Label TypeValueForParsing;
        private TextBox ValueForParsingBox;
        private Label ResultOfParsing;
        private Button ParseButton;
    }
}
