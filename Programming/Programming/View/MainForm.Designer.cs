namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Enums = new TabPage();
            ValueOfSelectedValue = new TextBox();
            IntValue = new Label();
            ChooseValue = new Label();
            ChooseEnumeration = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabPage2 = new TabPage();
            TypeValueForParsing = new Label();
            ValueForParsingBox = new TextBox();
            ResultOfParsing = new Label();
            ParseButton = new Button();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(ParseButton);
            Enums.Controls.Add(ResultOfParsing);
            Enums.Controls.Add(ValueForParsingBox);
            Enums.Controls.Add(TypeValueForParsing);
            Enums.Controls.Add(ValueOfSelectedValue);
            Enums.Controls.Add(IntValue);
            Enums.Controls.Add(ChooseValue);
            Enums.Controls.Add(ChooseEnumeration);
            Enums.Controls.Add(ValuesListBox);
            Enums.Controls.Add(EnumsListBox);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 422);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // ValueOfSelectedValue
            // 
            ValueOfSelectedValue.Location = new Point(381, 35);
            ValueOfSelectedValue.Name = "ValueOfSelectedValue";
            ValueOfSelectedValue.Size = new Size(140, 23);
            ValueOfSelectedValue.TabIndex = 5;
            // 
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.Location = new Point(381, 17);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(55, 15);
            IntValue.TabIndex = 4;
            IntValue.Text = "Int value:";
            // 
            // ChooseValue
            // 
            ChooseValue.AutoSize = true;
            ChooseValue.Location = new Point(203, 17);
            ChooseValue.Name = "ChooseValue";
            ChooseValue.Size = new Size(81, 15);
            ChooseValue.TabIndex = 3;
            ChooseValue.Text = "Choose value:";
            // 
            // ChooseEnumeration
            // 
            ChooseEnumeration.AutoSize = true;
            ChooseEnumeration.Location = new Point(21, 17);
            ChooseEnumeration.Name = "ChooseEnumeration";
            ChooseEnumeration.Size = new Size(121, 15);
            ChooseEnumeration.TabIndex = 2;
            ChooseEnumeration.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Items.AddRange(new object[] { "White", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Black" });
            ValuesListBox.Location = new Point(201, 35);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.ScrollAlwaysVisible = true;
            ValuesListBox.Size = new Size(140, 139);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufacture", "Season", "Weekday" });
            EnumsListBox.Location = new Point(21, 35);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(140, 139);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TypeValueForParsing
            // 
            TypeValueForParsing.AutoSize = true;
            TypeValueForParsing.Location = new Point(21, 272);
            TypeValueForParsing.Name = "TypeValueForParsing";
            TypeValueForParsing.Size = new Size(127, 15);
            TypeValueForParsing.TabIndex = 6;
            TypeValueForParsing.Text = "Type value for parsing:";
            // 
            // ValueForParsingBox
            // 
            ValueForParsingBox.Location = new Point(21, 290);
            ValueForParsingBox.Name = "ValueForParsingBox";
            ValueForParsingBox.Size = new Size(140, 23);
            ValueForParsingBox.TabIndex = 7;
            // 
            // ResultOfParsing
            // 
            ResultOfParsing.AutoSize = true;
            ResultOfParsing.Location = new Point(21, 316);
            ResultOfParsing.Name = "ResultOfParsing";
            ResultOfParsing.Size = new Size(38, 15);
            ResultOfParsing.TabIndex = 8;
            ResultOfParsing.Text = "label1";
            ResultOfParsing.Visible = false;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(201, 290);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 23);
            ParseButton.TabIndex = 9;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
            Enums.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private TabPage tabPage2;
        private ListBox EnumsListBox;
        public ListBox ValuesListBox;
        private TextBox ValueOfSelectedValue;
        private Label IntValue;
        private Label ChooseValue;
        private Label ChooseEnumeration;
        private Button ParseButton;
        private Label ResultOfParsing;
        private TextBox ValueForParsingBox;
        private Label TypeValueForParsing;
    }
}