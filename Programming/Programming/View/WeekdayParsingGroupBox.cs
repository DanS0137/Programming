using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class WeekdayParsingGroupBox : UserControl
    {
        public WeekdayParsingGroupBox()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string valueOfTextBox = ValueForParsingBox.Text;
            if (valueOfTextBox == "")
            {
                return;
            }
            if (!Enum.TryParse(typeof(Weekday), valueOfTextBox, out object result) || int.TryParse(valueOfTextBox, out int value))
            {
                ResultOfParsing.Text = "Это не день недели.";
            }
            else
            {
                ResultOfParsing.Text = $"Это день недели ({valueOfTextBox} = {(int)result + 1}).";
            }
            ResultOfParsing.Visible = true;
        }
    }
}
