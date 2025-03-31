namespace Programming.View
{
    partial class SeasonHandleGroupBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeasonHandleGroupBox));
            SeasonHandle = new GroupBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            Picture = new PictureBox();
            ChooseSeason = new Label();
            SeasonHandle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            SuspendLayout();
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(GoButton);
            SeasonHandle.Controls.Add(SeasonsComboBox);
            SeasonHandle.Controls.Add(Picture);
            SeasonHandle.Controls.Add(ChooseSeason);
            SeasonHandle.Location = new Point(0, 0);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(292, 408);
            SeasonHandle.TabIndex = 18;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(190, 47);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 15;
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
            // Picture
            // 
            Picture.Image = (Image)resources.GetObject("Picture.Image");
            Picture.Location = new Point(45, 121);
            Picture.Name = "Picture";
            Picture.Size = new Size(204, 201);
            Picture.TabIndex = 14;
            Picture.TabStop = false;
            Picture.Visible = false;
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
            // SeasonHandleGroupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandle);
            Name = "SeasonHandleGroupBox";
            Size = new Size(292, 408);
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonHandle;
        private ComboBox SeasonsComboBox;
        private Label ChooseSeason;
        public PictureBox Picture;
        private Button GoButton;
    }
}
