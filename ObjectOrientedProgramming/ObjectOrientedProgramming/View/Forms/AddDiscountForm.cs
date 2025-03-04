using System;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.View
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            CategoryComboBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
