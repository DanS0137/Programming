using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            ValueOfSelectedValue.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    foreach (int i in Enum.GetValues(typeof(Model.Color)))
                    {
                        ValuesListBox.Items.Add((Model.Color)i);
                    }
                    break;
                case "EducationForm":
                    foreach (int i in Enum.GetValues(typeof(EducationForm)))
                    {
                        ValuesListBox.Items.Add((EducationForm)i);
                    }
                    break;
                case "Genre":
                    foreach (int i in Enum.GetValues(typeof(Genre)))
                    {
                        ValuesListBox.Items.Add((Genre)i);
                    }
                    break;
                case "Manufacture":
                    foreach (int i in Enum.GetValues(typeof(Manufacture)))
                    {
                        ValuesListBox.Items.Add((Manufacture)i);
                    }
                    break;
                case "Season":
                    foreach (int i in Enum.GetValues(typeof(Season)))
                    {
                        ValuesListBox.Items.Add((Season)i);
                    }
                    break;
                case "Weekday":
                    foreach (int i in Enum.GetValues(typeof(Weekday)))
                    {
                        ValuesListBox.Items.Add((Weekday)i);
                    }
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueOfSelectedValue.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string valueOfTextBox = ValueForParsingBox.Text;
            if (valueOfTextBox == "")
            {
                return;
            }
            if (Enum.TryParse(typeof(Weekday), valueOfTextBox, out object result))
            {
                ResultOfParsing.Text = $"Это день недели ({valueOfTextBox} = {(int)result + 1}).";
            }
            else
            {
                ResultOfParsing.Text = "Это не день недели.";
            }
            ResultOfParsing.Visible = true;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    Picture.Image = Image.FromFile(@"C:\Users\5731sda\source\repos\Programming\Programming\Programming\Properties\winter.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(122, 255, 255);
                    break;
                case "Spring":
                    Picture.Image = Image.FromFile(@"C:\Users\5731sda\source\repos\Programming\Programming\Programming\Properties\spring.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
                    break;
                case "Summer":
                    Picture.Image = Image.FromFile(@"C:\Users\5731sda\source\repos\Programming\Programming\Programming\Properties\summer.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    break;
                case "Autumn":
                    Picture.Image = Image.FromFile(@"C:\Users\5731sda\source\repos\Programming\Programming\Programming\Properties\autumn.jpg");
                    Picture.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture.Visible = true;
                    Enums.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
                    break;
            }
        }
    }
}