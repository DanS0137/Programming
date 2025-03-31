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
            CreationTimeLabel = new Label();
            ThemeComboBox = new ComboBox();
            NameTextBox = new TextBox();
            TextTextBox = new TextBox();
            SelectedNoteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NotesListBox
            // 
            NotesListBox.FormattingEnabled = true;
            NotesListBox.ItemHeight = 15;
            NotesListBox.Location = new Point(3, 3);
            NotesListBox.Name = "NotesListBox";
            NotesListBox.Size = new Size(277, 469);
            NotesListBox.TabIndex = 0;
            NotesListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // AddNewNoteButton
            // 
            AddNewNoteButton.Location = new Point(3, 478);
            AddNewNoteButton.Name = "AddNewNoteButton";
            AddNewNoteButton.Size = new Size(75, 23);
            AddNewNoteButton.TabIndex = 1;
            AddNewNoteButton.Text = "Новая";
            AddNewNoteButton.UseVisualStyleBackColor = true;
            AddNewNoteButton.Click += AddNewNoteButton_Click;
            // 
            // SaveNoteButton
            // 
            SaveNoteButton.Location = new Point(104, 478);
            SaveNoteButton.Name = "SaveNoteButton";
            SaveNoteButton.Size = new Size(75, 23);
            SaveNoteButton.TabIndex = 2;
            SaveNoteButton.Text = "Сохранить";
            SaveNoteButton.UseVisualStyleBackColor = true;
            SaveNoteButton.Click += SaveNoteButton_Click;
            // 
            // DeleteNoteButton
            // 
            DeleteNoteButton.Location = new Point(205, 478);
            DeleteNoteButton.Name = "DeleteNoteButton";
            DeleteNoteButton.Size = new Size(75, 23);
            DeleteNoteButton.TabIndex = 3;
            DeleteNoteButton.Text = "Удалить";
            DeleteNoteButton.UseVisualStyleBackColor = true;
            DeleteNoteButton.Click += DeleteNoteButton_Click;
            // 
            // ThemeLabel
            // 
            ThemeLabel.AutoSize = true;
            ThemeLabel.Location = new Point(6, 29);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.Size = new Size(38, 15);
            ThemeLabel.TabIndex = 4;
            ThemeLabel.Text = "Тема:";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(6, 95);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(40, 15);
            TextLabel.TabIndex = 5;
            TextLabel.Text = "Текст:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 62);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 15);
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
            SelectedNoteGroupBox.Location = new Point(286, 3);
            SelectedNoteGroupBox.Name = "SelectedNoteGroupBox";
            SelectedNoteGroupBox.Size = new Size(636, 498);
            SelectedNoteGroupBox.TabIndex = 7;
            SelectedNoteGroupBox.TabStop = false;
            SelectedNoteGroupBox.Text = "Выбранная заметка:";
            // 
            // CreationTimeLabel
            // 
            CreationTimeLabel.AutoSize = true;
            CreationTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            CreationTimeLabel.Location = new Point(6, 479);
            CreationTimeLabel.Margin = new Padding(2, 0, 2, 0);
            CreationTimeLabel.Name = "CreationTimeLabel";
            CreationTimeLabel.Size = new Size(97, 15);
            CreationTimeLabel.TabIndex = 11;
            CreationTimeLabel.Text = "Время создания:";
            CreationTimeLabel.Visible = false;
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Items.AddRange(new object[] { "Дом", "Работа", "Спорт", "Финансы" });
            ThemeComboBox.Location = new Point(50, 26);
            ThemeComboBox.Name = "ThemeComboBox";
            ThemeComboBox.Size = new Size(121, 23);
            ThemeComboBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(74, 59);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(556, 23);
            NameTextBox.TabIndex = 9;
            // 
            // TextTextBox
            // 
            TextTextBox.Location = new Point(6, 113);
            TextTextBox.Multiline = true;
            TextTextBox.Name = "TextTextBox";
            TextTextBox.Size = new Size(624, 350);
            TextTextBox.TabIndex = 8;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedNoteGroupBox);
            Controls.Add(DeleteNoteButton);
            Controls.Add(SaveNoteButton);
            Controls.Add(AddNewNoteButton);
            Controls.Add(NotesListBox);
            Name = "MainScreen";
            Size = new Size(925, 504);
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
