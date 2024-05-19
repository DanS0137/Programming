namespace ListOfNotes.View
{
    partial class MainScreen
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
            NotesListBox = new ListBox();
            AddNewNoteButton = new Button();
            SaveNoteButton = new Button();
            DeleteNoteButton = new Button();
            ThemeLabel = new Label();
            TextLabel = new Label();
            NameLabel = new Label();
            SelectedNoteGroupBox = new GroupBox();
            ThemeComboBox = new ComboBox();
            NameTextBox = new TextBox();
            TextTextBox = new TextBox();
            CreationTimeLabel = new Label();
            SelectedNoteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NotesListBox
            // 
            NotesListBox.FormattingEnabled = true;
            NotesListBox.ItemHeight = 25;
            NotesListBox.Location = new Point(4, 5);
            NotesListBox.Margin = new Padding(4, 5, 4, 5);
            NotesListBox.Name = "NotesListBox";
            NotesListBox.Size = new Size(394, 779);
            NotesListBox.TabIndex = 0;
            NotesListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // AddNewNoteButton
            // 
            AddNewNoteButton.Location = new Point(4, 797);
            AddNewNoteButton.Margin = new Padding(4, 5, 4, 5);
            AddNewNoteButton.Name = "AddNewNoteButton";
            AddNewNoteButton.Size = new Size(107, 38);
            AddNewNoteButton.TabIndex = 1;
            AddNewNoteButton.Text = "New";
            AddNewNoteButton.UseVisualStyleBackColor = true;
            AddNewNoteButton.Click += AddNewNoteButton_Click;
            // 
            // SaveNoteButton
            // 
            SaveNoteButton.Location = new Point(149, 797);
            SaveNoteButton.Margin = new Padding(4, 5, 4, 5);
            SaveNoteButton.Name = "SaveNoteButton";
            SaveNoteButton.Size = new Size(107, 38);
            SaveNoteButton.TabIndex = 2;
            SaveNoteButton.Text = "Save";
            SaveNoteButton.UseVisualStyleBackColor = true;
            SaveNoteButton.Click += SaveNoteButton_Click;
            // 
            // DeleteNoteButton
            // 
            DeleteNoteButton.Location = new Point(293, 797);
            DeleteNoteButton.Margin = new Padding(4, 5, 4, 5);
            DeleteNoteButton.Name = "DeleteNoteButton";
            DeleteNoteButton.Size = new Size(107, 38);
            DeleteNoteButton.TabIndex = 3;
            DeleteNoteButton.Text = "Delete";
            DeleteNoteButton.UseVisualStyleBackColor = true;
            DeleteNoteButton.Click += DeleteNoteButton_Click;
            // 
            // ThemeLabel
            // 
            ThemeLabel.AutoSize = true;
            ThemeLabel.Location = new Point(9, 48);
            ThemeLabel.Margin = new Padding(4, 0, 4, 0);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.Size = new Size(56, 25);
            ThemeLabel.TabIndex = 4;
            ThemeLabel.Text = "Тема:";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(9, 158);
            TextLabel.Margin = new Padding(4, 0, 4, 0);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(58, 25);
            TextLabel.TabIndex = 5;
            TextLabel.Text = "Текст:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(9, 103);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(94, 25);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Название:";
            // 
            // SelectedNoteGroupBox
            // 
            SelectedNoteGroupBox.Controls.Add(CreationTimeLabel);
            SelectedNoteGroupBox.Controls.Add(ThemeComboBox);
            SelectedNoteGroupBox.Controls.Add(NameTextBox);
            SelectedNoteGroupBox.Controls.Add(TextTextBox);
            SelectedNoteGroupBox.Controls.Add(ThemeLabel);
            SelectedNoteGroupBox.Controls.Add(TextLabel);
            SelectedNoteGroupBox.Controls.Add(NameLabel);
            SelectedNoteGroupBox.Location = new Point(409, 5);
            SelectedNoteGroupBox.Margin = new Padding(4, 5, 4, 5);
            SelectedNoteGroupBox.Name = "SelectedNoteGroupBox";
            SelectedNoteGroupBox.Padding = new Padding(4, 5, 4, 5);
            SelectedNoteGroupBox.Size = new Size(909, 830);
            SelectedNoteGroupBox.TabIndex = 7;
            SelectedNoteGroupBox.TabStop = false;
            SelectedNoteGroupBox.Text = "Выбранная заметка:";
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Items.AddRange(new object[] { "Дом", "Работа", "Спорт", "Финансы" });
            ThemeComboBox.Location = new Point(71, 43);
            ThemeComboBox.Margin = new Padding(4, 5, 4, 5);
            ThemeComboBox.Name = "ThemeComboBox";
            ThemeComboBox.Size = new Size(171, 33);
            ThemeComboBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(106, 98);
            NameTextBox.Margin = new Padding(4, 5, 4, 5);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(793, 31);
            NameTextBox.TabIndex = 9;
            // 
            // TextTextBox
            // 
            TextTextBox.Location = new Point(9, 188);
            TextTextBox.Margin = new Padding(4, 5, 4, 5);
            TextTextBox.Multiline = true;
            TextTextBox.Name = "TextTextBox";
            TextTextBox.Size = new Size(890, 581);
            TextTextBox.TabIndex = 8;
            // 
            // CreationTimeLabel
            // 
            CreationTimeLabel.AutoSize = true;
            CreationTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            CreationTimeLabel.Location = new Point(9, 799);
            CreationTimeLabel.Name = "CreationTimeLabel";
            CreationTimeLabel.Size = new Size(146, 25);
            CreationTimeLabel.TabIndex = 11;
            CreationTimeLabel.Text = "Время создания:";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedNoteGroupBox);
            Controls.Add(DeleteNoteButton);
            Controls.Add(SaveNoteButton);
            Controls.Add(AddNewNoteButton);
            Controls.Add(NotesListBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainScreen";
            Size = new Size(1321, 840);
            SelectedNoteGroupBox.ResumeLayout(false);
            SelectedNoteGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox NotesListBox;
        private Button AddNewNoteButton;
        private Button SaveNoteButton;
        private Button DeleteNoteButton;
        private Label ThemeLabel;
        private Label TextLabel;
        private Label NameLabel;
        private GroupBox SelectedNoteGroupBox;
        private ComboBox ThemeComboBox;
        private TextBox NameTextBox;
        private TextBox TextTextBox;
        private Label CreationTimeLabel;
    }
}
