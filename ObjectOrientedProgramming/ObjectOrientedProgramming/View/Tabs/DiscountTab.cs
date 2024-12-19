using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;
using ObjectOrientedProgramming.Model.Discounts;

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class DiscountTab : UserControl
    {
        public List<Item> Items { get; set; }

        private PointsDiscount disc = new PointsDiscount();

        public DiscountTab()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            int dsc = (int)disc.Calculate(Items);
            InfoLabel.Text = disc.Info;
            double am = 0;
            foreach(Item item in Items)
            {
                am += item.Cost;
            }
            AmountLabel.Text = am.ToString();
            DiscountLabel.Text = dsc.ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int dsc = (int)disc.Apply(Items);
            double am = 0;
            foreach (Item item in Items)
            {
                am += item.Cost;
            }
            AmountLabel.Text = am.ToString();
            DiscountLabel.Text = dsc.ToString();
            InfoLabel.Text = disc.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            disc.Update(Items);

            InfoLabel.Text = disc.Info;
        }
    }
}
