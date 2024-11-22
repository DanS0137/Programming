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
using ObjectOrientedProgramming.Services;

namespace ObjectOrientedProgramming.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private bool isAddressDeleted = false;

        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                isAddressDeleted = true;
                PostIndexTextBox.Text = value.Index.ToString();
                CountryTextBox.Text = value.Country;
                CityTextBox.Text = value.City;
                StreetTextBox.Text = value.Street;
                BuildingTextBox.Text = value.Building;
                ApartmentTextBox.Text = value.Apartment;
                isAddressDeleted = false;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isAddressDeleted) return;
            try
            {
                if (PostIndexTextBox.Text.Length > 6) throw new ArgumentException();
                if (PostIndexTextBox.Text.Length == 6)
                {
                    Convert.ToInt32(PostIndexTextBox.Text);
                    PostIndexTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Post Index введено неправильное значение.\nЗначение должно быть шестизначным целым числом.");
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isAddressDeleted) return;
            try
            {
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 50, "AddressControl.Address.Country");
                CountryTextBox.BackColor = Color.White;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Country введено неправильное значение.\nЗначение должно быть равно или меньше 50 символов.");
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isAddressDeleted) return;
            try
            {
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 50, "AddressControl.Address.City");
                CityTextBox.BackColor = Color.White;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле City введено неправильное значение.\nЗначение должно быть равно или меньше 50 символов.");
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isAddressDeleted) return;
            try
            {
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 100, "AddressControl.Address.Street");
                StreetTextBox.BackColor = Color.White;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Street введено неправильное значение.\nЗначение должно быть равно или меньше 100 символов.");
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isAddressDeleted) return;
            try
            {
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 10, "AddressControl.Address.Building");
                BuildingTextBox.BackColor = Color.White;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Building введено неправильное значение.\nЗначение должно быть равно или меньше 10 символов.");
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isAddressDeleted) return;
            try
            {
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 10, "AddressControl.Address.Apartment");
                ApartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Apartment введено неправильное значение.\nЗначение должно быть равно или меньше 10 символов.");
            }
        }

        public void Clear()
        {
            isAddressDeleted = true;
            PostIndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";
        }

        public void SaveChanges()
        {
            _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
            _address.Country = CountryTextBox.Text;
            _address.City = CityTextBox.Text;
            _address.Street = StreetTextBox.Text;
            _address.Building = BuildingTextBox.Text;
            _address.Apartment = ApartmentTextBox.Text;
        }
    }
}
