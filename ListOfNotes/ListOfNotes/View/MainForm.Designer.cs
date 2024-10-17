using ListOfNotes.View;

namespace ListOfNotes
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
            mainScreen = new MainScreen();
            SuspendLayout();
            // 
            // mainScreen
            // 
            mainScreen.Location = new Point(-1, 0);
            mainScreen.Name = "mainScreen";
            mainScreen.Size = new Size(925, 504);
            mainScreen.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 505);
            Controls.Add(mainScreen);
            Name = "MainForm";
            Text = "Заметки";
            ResumeLayout(false);
        }

        #endregion

        private MainScreen mainScreen;
    }
}