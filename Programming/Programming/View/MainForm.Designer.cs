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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            Enums = new TabPage();
            Picture = new PictureBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            ChooseSeason = new Label();
            ParseButton = new Button();
            ResultOfParsing = new Label();
            ValueForParsingBox = new TextBox();
            TypeValueForParsing = new Label();
            ValueOfSelectedValue = new TextBox();
            IntValue = new Label();
            ChooseValue = new Label();
            ChooseEnumeration = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabPage2 = new TabPage();
            Enumerations = new GroupBox();
            WeekdayParsing = new GroupBox();
            SeasonHandle = new GroupBox();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            Enumerations.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            SeasonHandle.SuspendLayout();
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
            Enums.BackColor = Color.White;
            Enums.Controls.Add(SeasonHandle);
            Enums.Controls.Add(WeekdayParsing);
            Enums.Controls.Add(Enumerations);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 422);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            // 
            // Picture
            // 
            Picture.Image = (Image)resources.GetObject("Picture.Image");
            Picture.Location = new Point(557, 43);
            Picture.Name = "Picture";
            Picture.Size = new Size(204, 201);
            Picture.TabIndex = 14;
            Picture.TabStop = false;
            Picture.Visible = false;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(174, 46);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 13;
            GoButton.Text = "GO!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonsComboBox.Location = new Point(9, 47);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(140, 23);
            SeasonsComboBox.TabIndex = 12;
            // 
            // ChooseSeason
            // 
            ChooseSeason.AutoSize = true;
            ChooseSeason.Location = new Point(9, 29);
            ChooseSeason.Name = "ChooseSeason";
            ChooseSeason.Size = new Size(89, 15);
            ChooseSeason.TabIndex = 10;
            ChooseSeason.Text = "Choose season:";
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
            // ValueForParsingBox
            // 
            ValueForParsingBox.Location = new Point(15, 47);
            ValueForParsingBox.Name = "ValueForParsingBox";
            ValueForParsingBox.Size = new Size(140, 23);
            ValueForParsingBox.TabIndex = 7;
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
            // ValueOfSelectedValue
            // 
            ValueOfSelectedValue.Location = new Point(375, 43);
            ValueOfSelectedValue.Name = "ValueOfSelectedValue";
            ValueOfSelectedValue.Size = new Size(140, 23);
            ValueOfSelectedValue.TabIndex = 5;
            // 
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.Location = new Point(375, 25);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(55, 15);
            IntValue.TabIndex = 4;
            IntValue.Text = "Int value:";
            // 
            // ChooseValue
            // 
            ChooseValue.AutoSize = true;
            ChooseValue.Location = new Point(197, 25);
            ChooseValue.Name = "ChooseValue";
            ChooseValue.Size = new Size(81, 15);
            ChooseValue.TabIndex = 3;
            ChooseValue.Text = "Choose value:";
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
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Items.AddRange(new object[] { "White", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Black" });
            ValuesListBox.Location = new Point(197, 43);
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
            EnumsListBox.Location = new Point(15, 43);
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
            // Enumerations
            // 
            Enumerations.Controls.Add(EnumsListBox);
            Enumerations.Controls.Add(Picture);
            Enumerations.Controls.Add(ValuesListBox);
            Enumerations.Controls.Add(ValueOfSelectedValue);
            Enumerations.Controls.Add(ChooseValue);
            Enumerations.Controls.Add(IntValue);
            Enumerations.Controls.Add(ChooseEnumeration);
            Enumerations.Location = new Point(6, 6);
            Enumerations.Name = "Enumerations";
            Enumerations.Size = new Size(780, 263);
            Enumerations.TabIndex = 15;
            Enumerations.TabStop = false;
            Enumerations.Text = "Enumerations";
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Controls.Add(TypeValueForParsing);
            WeekdayParsing.Controls.Add(ValueForParsingBox);
            WeekdayParsing.Controls.Add(ResultOfParsing);
            WeekdayParsing.Controls.Add(ParseButton);
            WeekdayParsing.Location = new Point(6, 275);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Size = new Size(360, 139);
            WeekdayParsing.TabIndex = 16;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(SeasonsComboBox);
            SeasonHandle.Controls.Add(GoButton);
            SeasonHandle.Controls.Add(ChooseSeason);
            SeasonHandle.Location = new Point(372, 275);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(412, 139);
            SeasonHandle.TabIndex = 17;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            Enumerations.ResumeLayout(false);
            Enumerations.PerformLayout();
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
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
        private Label ChooseSeason;
        private ComboBox SeasonsComboBox;
        private Button GoButton;
        private PictureBox Picture;
        private GroupBox SeasonHandle;
        private GroupBox WeekdayParsing;
        private GroupBox Enumerations;
    }
}