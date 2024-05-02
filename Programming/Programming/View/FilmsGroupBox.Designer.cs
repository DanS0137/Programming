namespace Programming.View
{
    partial class FilmsGroupBox
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RatingOfFilmLabel);
            groupBox1.Controls.Add(GenreOfFilmLabel);
            groupBox1.Controls.Add(RatingOfFilmTextBox);
            groupBox1.Controls.Add(GenreOfFilmTextBox);
            groupBox1.Controls.Add(FindFilmWithMaxRatingButton);
            groupBox1.Controls.Add(YearOfFilmReleaseTextBox);
            groupBox1.Controls.Add(NameOfFilmTextBox);
            groupBox1.Controls.Add(DurationOfFilmTextBox);
            groupBox1.Controls.Add(NameOfFilmLabel);
            groupBox1.Controls.Add(DurationOfFilmLabel);
            groupBox1.Controls.Add(YearOfFilmReleaseLabel);
            groupBox1.Controls.Add(FilmsListBox);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 221);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Films";
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
            NameOfFilmTextBox.TextChanged += NameOfFilmTextBox_TextChanged;
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
            // FilmsGroupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "FilmsGroupBox";
            Size = new Size(386, 221);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label RatingOfFilmLabel;
        private Label GenreOfFilmLabel;
        private TextBox RatingOfFilmTextBox;
        private TextBox GenreOfFilmTextBox;
        private Button FindFilmWithMaxRatingButton;
        private TextBox YearOfFilmReleaseTextBox;
        private TextBox NameOfFilmTextBox;
        private TextBox DurationOfFilmTextBox;
        private Label NameOfFilmLabel;
        private Label DurationOfFilmLabel;
        private Label YearOfFilmReleaseLabel;
        private ListBox FilmsListBox;
    }
}
