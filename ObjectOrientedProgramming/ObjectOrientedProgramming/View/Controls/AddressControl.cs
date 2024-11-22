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

        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                PostIndexTextBox.Text = value.Index.ToString();
                CountryTextBox.Text = value.Country;
                CityTextBox.Text = value.City;
                StreetTextBox.Text = value.Street;
                BuildingTextBox.Text = value.Building;
                ApartmentTextBox.Text = value.Apartment;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            PostIndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";
        }

        public void SaveChanges()
        {
            try
            {
                if (PostIndexTextBox.Text.Length != 6) throw new ArgumentException();
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = Color.White;
            }
            catch
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Post Index введено неправильное значение.\nЗначение должно быть шестизначным целым числом.");
            }

            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Country введено неправильное значение.\nЗначение должно быть равно или меньше 50 символов.");
            }

            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле City введено неправильное значение.\nЗначение должно быть равно или меньше 50 символов.");
            }

            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Street введено неправильное значение.\nЗначение должно быть равно или меньше 100 символов.");
            }

            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Building введено неправильное значение.\nЗначение должно быть равно или меньше 10 символов.");
            }

            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                MessageBox.Show("В поле Apartment введено неправильное значение.\nЗначение должно быть равно или меньше 10 символов.");
            }
        }
    }
}
