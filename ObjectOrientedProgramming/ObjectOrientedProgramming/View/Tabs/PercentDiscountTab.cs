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

namespace ObjectOrientedProgramming.View.Tabs
{
    public partial class PercentDiscountTab : UserControl
    {
        public List<Item> Items { get; set; }
        private PercentsDiscount disc = new PercentsDiscount();

        public PercentDiscountTab()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double dsc = disc.Calculate(Items);
            double am = 0;
            foreach (Item item in Items)
            {
                am += item.Cost;
            }
            AmountLabel.Text = am.ToString();
            DiscountLabel.Text = dsc.ToString();
            SummaryLabel.Text = disc.Summary.ToString();
            InfoLabel.Text = disc.Info;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double dsc = disc.Apply(Items);
            double am = 0;
            foreach (Item item in Items)
            {
                am += item.Cost;
            }
            AmountLabel.Text = am.ToString();
            DiscountLabel.Text = dsc.ToString();
            SummaryLabel.Text = disc.Summary.ToString();
            InfoLabel.Text = disc.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            disc.Update(Items);

            InfoLabel.Text = disc.Info;
            SummaryLabel.Text = disc.Summary.ToString();
        }
    }
}
