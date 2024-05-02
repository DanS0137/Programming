using Programming.Model;
using Programming.Model.Geometry;
using Programming.View;
using System.Globalization;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            seasonHandleGroupBox1.buttonClickedWinter += ChangeColorToWinter;
            seasonHandleGroupBox1.buttonClickedSpring += ChangeColorToSpring;
            seasonHandleGroupBox1.buttonClickedSummer += ChangeColorToSummer;
            seasonHandleGroupBox1.buttonClickedAutumn += ChangeColorToAutumn;
        }

        private void ChangeColorToWinter() => Enums.BackColor = System.Drawing.Color.FromArgb(122, 255, 255);
        private void ChangeColorToSpring() => Enums.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
        private void ChangeColorToSummer() => Enums.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
        private void ChangeColorToAutumn() => Enums.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
    }
}