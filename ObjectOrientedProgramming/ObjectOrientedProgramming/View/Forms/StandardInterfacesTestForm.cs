using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.View
{
    public partial class StandardInterfacesTestForm : Form
    {
        public List<Item> Items { get; set; }

        public StandardInterfacesTestForm()
        {
            InitializeComponent();
        }
    }
}
