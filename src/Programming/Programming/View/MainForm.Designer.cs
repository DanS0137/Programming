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
            seasonHandleGroupBox = new View.SeasonHandleGroupBox();
            weekdayParsingGroupBox = new View.WeekdayParsingGroupBox();
            enumerationsGroupBox = new View.EnumerationsGroupBox();
            Classes = new TabPage();
            rectanglesGroupBox = new View.RectanglesGroupBox();
            filmsGroupBox = new View.FilmsGroupBox();
            Rectangles = new TabPage();
            rectanglesCollisionControl = new View.RectanglesCollisionControl();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            Classes.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(Rectangles);
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
            Enums.Controls.Add(seasonHandleGroupBox);
            Enums.Controls.Add(weekdayParsingGroupBox);
            Enums.Controls.Add(enumerationsGroupBox);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 448);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            // 
            // seasonHandleGroupBox
            // 
            seasonHandleGroupBox.Location = new Point(492, 6);
            seasonHandleGroupBox.Name = "seasonHandleGroupBox";
            seasonHandleGroupBox.Size = new Size(292, 408);
            seasonHandleGroupBox.TabIndex = 20;
            // 
            // weekdayParsingGroupBox
            // 
            weekdayParsingGroupBox.Location = new Point(6, 275);
            weekdayParsingGroupBox.Name = "weekdayParsingGroupBox";
            weekdayParsingGroupBox.Size = new Size(480, 139);
            weekdayParsingGroupBox.TabIndex = 19;
            // 
            // enumerationsGroupBox
            // 
            enumerationsGroupBox.Location = new Point(6, 6);
            enumerationsGroupBox.Name = "enumerationsGroupBox";
            enumerationsGroupBox.Size = new Size(480, 263);
            enumerationsGroupBox.TabIndex = 18;
            // 
            // Classes
            // 
            Classes.Controls.Add(rectanglesGroupBox);
            Classes.Controls.Add(filmsGroupBox);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 448);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // rectanglesGroupBox
            // 
            rectanglesGroupBox.Location = new Point(6, 6);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(386, 221);
            rectanglesGroupBox.TabIndex = 3;
            // 
            // filmsGroupBox
            // 
            filmsGroupBox.Location = new Point(6, 227);
            filmsGroupBox.Name = "filmsGroupBox";
            filmsGroupBox.Size = new Size(386, 221);
            filmsGroupBox.TabIndex = 2;
            // 
            // Rectangles
            // 
            Rectangles.AccessibleRole = AccessibleRole.None;
            Rectangles.BackColor = Color.White;
            Rectangles.Controls.Add(rectanglesCollisionControl);
            Rectangles.Location = new Point(4, 24);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(792, 448);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            // 
            // rectanglesCollisionControl
            // 
            rectanglesCollisionControl.AutoSize = true;
            rectanglesCollisionControl.Dock = DockStyle.Fill;
            rectanglesCollisionControl.Location = new Point(3, 3);
            rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            rectanglesCollisionControl.Size = new Size(786, 442);
            rectanglesCollisionControl.TabIndex = 0;
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
            Classes.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private TabPage Classes;
        private TabPage Rectangles;
        private View.RectanglesCollisionControl rectanglesCollisionControl;
        private View.EnumerationsGroupBox enumerationsGroupBox;
        private View.WeekdayParsingGroupBox weekdayParsingGroupBox;
        private View.SeasonHandleGroupBox seasonHandleGroupBox;
        private View.FilmsGroupBox filmsGroupBox;
        private View.RectanglesGroupBox rectanglesGroupBox;
    }
}