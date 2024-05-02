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
            seasonHandleGroupBox1 = new View.SeasonHandleGroupBox();
            weekdayParsingGroupBox1 = new View.WeekdayParsingGroupBox();
            enumerationsGroupBox1 = new View.EnumerationsGroupBox();
            Classes = new TabPage();
            filmsGroupBox1 = new View.FilmsGroupBox();
            Rectangles = new TabPage();
            rectanglesCollisionControl = new View.RectanglesCollisionControl();
            newRectanglesGroupBox1 = new View.RectanglesGroupBox();
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
            Enums.Controls.Add(seasonHandleGroupBox1);
            Enums.Controls.Add(weekdayParsingGroupBox1);
            Enums.Controls.Add(enumerationsGroupBox1);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 448);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            // 
            // seasonHandleGroupBox1
            // 
            seasonHandleGroupBox1.Location = new Point(492, 6);
            seasonHandleGroupBox1.Name = "seasonHandleGroupBox1";
            seasonHandleGroupBox1.Size = new Size(292, 408);
            seasonHandleGroupBox1.TabIndex = 20;
            // 
            // weekdayParsingGroupBox1
            // 
            weekdayParsingGroupBox1.Location = new Point(6, 275);
            weekdayParsingGroupBox1.Name = "weekdayParsingGroupBox1";
            weekdayParsingGroupBox1.Size = new Size(480, 139);
            weekdayParsingGroupBox1.TabIndex = 19;
            // 
            // enumerationsGroupBox1
            // 
            enumerationsGroupBox1.Location = new Point(6, 6);
            enumerationsGroupBox1.Name = "enumerationsGroupBox1";
            enumerationsGroupBox1.Size = new Size(480, 263);
            enumerationsGroupBox1.TabIndex = 18;
            // 
            // Classes
            // 
            Classes.Controls.Add(newRectanglesGroupBox1);
            Classes.Controls.Add(filmsGroupBox1);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 448);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // filmsGroupBox1
            // 
            filmsGroupBox1.Location = new Point(6, 227);
            filmsGroupBox1.Name = "filmsGroupBox1";
            filmsGroupBox1.Size = new Size(386, 221);
            filmsGroupBox1.TabIndex = 2;
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
            // newRectanglesGroupBox1
            // 
            newRectanglesGroupBox1.Location = new Point(6, 6);
            newRectanglesGroupBox1.Name = "newRectanglesGroupBox1";
            newRectanglesGroupBox1.Size = new Size(386, 221);
            newRectanglesGroupBox1.TabIndex = 3;
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
        private View.EnumerationsGroupBox enumerationsGroupBox1;
        private View.WeekdayParsingGroupBox weekdayParsingGroupBox1;
        private View.SeasonHandleGroupBox seasonHandleGroupBox1;
        private View.FilmsGroupBox filmsGroupBox1;
        private View.RectanglesGroupBox newRectanglesGroupBox1;
    }
}