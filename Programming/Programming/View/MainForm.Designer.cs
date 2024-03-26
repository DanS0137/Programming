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
            SeasonHandle = new GroupBox();
            SeasonsComboBox = new ComboBox();
            GoButton = new Button();
            ChooseSeason = new Label();
            WeekdayParsing = new GroupBox();
            TypeValueForParsing = new Label();
            ValueForParsingBox = new TextBox();
            ResultOfParsing = new Label();
            ParseButton = new Button();
            Enumerations = new GroupBox();
            EnumsListBox = new ListBox();
            Picture = new PictureBox();
            ValuesListBox = new ListBox();
            ValueOfSelectedValue = new TextBox();
            ChooseValue = new Label();
            IntValue = new Label();
            ChooseEnumeration = new Label();
            Classes = new TabPage();
            FilmsGroupBox = new GroupBox();
            RatingOfFilmLabel = new Label();
            GenreOfFilmLabel = new Label();
            RatingOfFilmTextBox = new TextBox();
            GenreOfFilmTextBox = new TextBox();
            FindFilmWithMaxRatingButton = new Button();
            YearOfFilmReleaseTextBox = new TextBox();
            NameOfFilmTextBox = new TextBox();
            DurationOfFilmTextBox = new TextBox();
            NameOfFilmLabel = new Label();
            DurationOfFilmLabel = new Label();
            YearOfFilmReleaseLabel = new Label();
            FilmsListBox = new ListBox();
            RectanglesGroupBox = new GroupBox();
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
            tabPage1 = new TabPage();
            IdOfRectangleTextBox = new TextBox();
            IdOfRectangleLabel = new Label();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            SeasonHandle.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            Enumerations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            Classes.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 476);
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
            Enums.Size = new Size(792, 448);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
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
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonsComboBox.Location = new Point(9, 47);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(140, 23);
            SeasonsComboBox.TabIndex = 12;
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
            // ChooseSeason
            // 
            ChooseSeason.AutoSize = true;
            ChooseSeason.Location = new Point(9, 29);
            ChooseSeason.Name = "ChooseSeason";
            ChooseSeason.Size = new Size(89, 15);
            ChooseSeason.TabIndex = 10;
            ChooseSeason.Text = "Choose season:";
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
            // ValueOfSelectedValue
            // 
            ValueOfSelectedValue.Location = new Point(375, 43);
            ValueOfSelectedValue.Name = "ValueOfSelectedValue";
            ValueOfSelectedValue.Size = new Size(140, 23);
            ValueOfSelectedValue.TabIndex = 5;
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
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.Location = new Point(375, 25);
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
            // Classes
            // 
            Classes.Controls.Add(FilmsGroupBox);
            Classes.Controls.Add(RectanglesGroupBox);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 448);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // FilmsGroupBox
            // 
            FilmsGroupBox.Controls.Add(RatingOfFilmLabel);
            FilmsGroupBox.Controls.Add(GenreOfFilmLabel);
            FilmsGroupBox.Controls.Add(RatingOfFilmTextBox);
            FilmsGroupBox.Controls.Add(GenreOfFilmTextBox);
            FilmsGroupBox.Controls.Add(FindFilmWithMaxRatingButton);
            FilmsGroupBox.Controls.Add(YearOfFilmReleaseTextBox);
            FilmsGroupBox.Controls.Add(NameOfFilmTextBox);
            FilmsGroupBox.Controls.Add(DurationOfFilmTextBox);
            FilmsGroupBox.Controls.Add(NameOfFilmLabel);
            FilmsGroupBox.Controls.Add(DurationOfFilmLabel);
            FilmsGroupBox.Controls.Add(YearOfFilmReleaseLabel);
            FilmsGroupBox.Controls.Add(FilmsListBox);
            FilmsGroupBox.Location = new Point(12, 233);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(380, 202);
            FilmsGroupBox.TabIndex = 1;
            FilmsGroupBox.TabStop = false;
            FilmsGroupBox.Text = "Films";
            // 
            // RatingOfFilmLabel
            // 
            RatingOfFilmLabel.AutoSize = true;
            RatingOfFilmLabel.Location = new Point(254, 66);
            RatingOfFilmLabel.Name = "RatingOfFilmLabel";
            RatingOfFilmLabel.Size = new Size(44, 15);
            RatingOfFilmLabel.TabIndex = 8;
            RatingOfFilmLabel.Text = "Rating:";
            // 
            // GenreOfFilmLabel
            // 
            GenreOfFilmLabel.AutoSize = true;
            GenreOfFilmLabel.Location = new Point(254, 22);
            GenreOfFilmLabel.Name = "GenreOfFilmLabel";
            GenreOfFilmLabel.Size = new Size(41, 15);
            GenreOfFilmLabel.TabIndex = 7;
            GenreOfFilmLabel.Text = "Genre:";
            // 
            // RatingOfFilmTextBox
            // 
            RatingOfFilmTextBox.Location = new Point(254, 84);
            RatingOfFilmTextBox.Name = "RatingOfFilmTextBox";
            RatingOfFilmTextBox.Size = new Size(100, 23);
            RatingOfFilmTextBox.TabIndex = 6;
            RatingOfFilmTextBox.TextChanged += RatingOfFilmTextBox_TextChanged;
            // 
            // GenreOfFilmTextBox
            // 
            GenreOfFilmTextBox.Location = new Point(254, 40);
            GenreOfFilmTextBox.Name = "GenreOfFilmTextBox";
            GenreOfFilmTextBox.Size = new Size(100, 23);
            GenreOfFilmTextBox.TabIndex = 5;
            GenreOfFilmTextBox.TextChanged += GenreOfFilmTextBox_TextChanged;
            // 
            // FindFilmWithMaxRatingButton
            // 
            FindFilmWithMaxRatingButton.AllowDrop = true;
            FindFilmWithMaxRatingButton.Location = new Point(132, 168);
            FindFilmWithMaxRatingButton.Name = "FindFilmWithMaxRatingButton";
            FindFilmWithMaxRatingButton.Size = new Size(100, 23);
            FindFilmWithMaxRatingButton.TabIndex = 1;
            FindFilmWithMaxRatingButton.Text = "Find";
            FindFilmWithMaxRatingButton.UseVisualStyleBackColor = true;
            FindFilmWithMaxRatingButton.Click += FindFilmWithMaxRatingButton_Click;
            // 
            // YearOfFilmReleaseTextBox
            // 
            YearOfFilmReleaseTextBox.Location = new Point(132, 128);
            YearOfFilmReleaseTextBox.Name = "YearOfFilmReleaseTextBox";
            YearOfFilmReleaseTextBox.Size = new Size(100, 23);
            YearOfFilmReleaseTextBox.TabIndex = 4;
            YearOfFilmReleaseTextBox.TextChanged += YearOfFilmReleaseTextBox_TextChanged;
            // 
            // NameOfFilmTextBox
            // 
            NameOfFilmTextBox.Location = new Point(132, 40);
            NameOfFilmTextBox.Name = "NameOfFilmTextBox";
            NameOfFilmTextBox.Size = new Size(100, 23);
            NameOfFilmTextBox.TabIndex = 2;
            NameOfFilmTextBox.TextChanged += NameOfFIlmTextBox_TextChanged;
            // 
            // DurationOfFilmTextBox
            // 
            DurationOfFilmTextBox.Location = new Point(132, 84);
            DurationOfFilmTextBox.Name = "DurationOfFilmTextBox";
            DurationOfFilmTextBox.Size = new Size(100, 23);
            DurationOfFilmTextBox.TabIndex = 3;
            DurationOfFilmTextBox.TextChanged += DurationOfFilmTextBox_TextChanged;
            // 
            // NameOfFilmLabel
            // 
            NameOfFilmLabel.AutoSize = true;
            NameOfFilmLabel.Location = new Point(132, 22);
            NameOfFilmLabel.Name = "NameOfFilmLabel";
            NameOfFilmLabel.Size = new Size(42, 15);
            NameOfFilmLabel.TabIndex = 2;
            NameOfFilmLabel.Text = "Name:";
            // 
            // DurationOfFilmLabel
            // 
            DurationOfFilmLabel.AutoSize = true;
            DurationOfFilmLabel.Location = new Point(132, 66);
            DurationOfFilmLabel.Name = "DurationOfFilmLabel";
            DurationOfFilmLabel.Size = new Size(56, 15);
            DurationOfFilmLabel.TabIndex = 1;
            DurationOfFilmLabel.Text = "Duration:";
            // 
            // YearOfFilmReleaseLabel
            // 
            YearOfFilmReleaseLabel.AutoSize = true;
            YearOfFilmReleaseLabel.Location = new Point(132, 110);
            YearOfFilmReleaseLabel.Name = "YearOfFilmReleaseLabel";
            YearOfFilmReleaseLabel.Size = new Size(49, 15);
            YearOfFilmReleaseLabel.TabIndex = 3;
            YearOfFilmReleaseLabel.Text = "Release:";
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 15;
            FilmsListBox.Location = new Point(6, 22);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(120, 169);
            FilmsListBox.TabIndex = 1;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(IdOfRectangleLabel);
            RectanglesGroupBox.Controls.Add(IdOfRectangleTextBox);
            RectanglesGroupBox.Controls.Add(YCentreOfRectangleTextBox);
            RectanglesGroupBox.Controls.Add(XCentreOfRectangleTextBox);
            RectanglesGroupBox.Controls.Add(YCentreOfRectangleLabel);
            RectanglesGroupBox.Controls.Add(XCentreOfRectangleLabel);
            RectanglesGroupBox.Controls.Add(FindRectangleWithMaxWidthButton);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(ColorLabel);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(6, 6);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(386, 221);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
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
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 448);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage";
            // 
            // IdOfRectangleTextBox
            // 
            IdOfRectangleTextBox.Location = new Point(260, 128);
            IdOfRectangleTextBox.Name = "IdOfRectangleTextBox";
            IdOfRectangleTextBox.ReadOnly = true;
            IdOfRectangleTextBox.Size = new Size(100, 23);
            IdOfRectangleTextBox.TabIndex = 9;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 476);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            Enumerations.ResumeLayout(false);
            Enumerations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            Classes.ResumeLayout(false);
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private TabPage Classes;
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
        private GroupBox RectanglesGroupBox;
        private Button FindRectangleWithMaxWidthButton;
        private TextBox ColorTextBox;
        private TextBox LengthTextBox;
        private TextBox WidthTextBox;
        private Label LengthLabel;
        private Label WidthLabel;
        private Label ColorLabel;
        private ListBox RectanglesListBox;
        private GroupBox FilmsGroupBox;
        private Button FindFilmWithMaxRatingButton;
        private TextBox YearOfFilmReleaseTextBox;
        private TextBox NameOfFilmTextBox;
        private TextBox DurationOfFilmTextBox;
        private Label NameOfFilmLabel;
        private Label DurationOfFilmLabel;
        private Label YearOfFilmReleaseLabel;
        private ListBox FilmsListBox;
        private Label RatingOfFilmLabel;
        private Label GenreOfFilmLabel;
        private TextBox RatingOfFilmTextBox;
        private TextBox GenreOfFilmTextBox;
        private TabPage tabPage1;
        private TextBox YCentreOfRectangleTextBox;
        private TextBox XCentreOfRectangleTextBox;
        private Label YCentreOfRectangleLabel;
        private Label XCentreOfRectangleLabel;
        private Label IdOfRectangleLabel;
        private TextBox IdOfRectangleTextBox;
    }
}