using C969MatthewSmith.Forms.Home;
using C969MatthewSmith.Models;
using C969MatthewSmith.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969MatthewSmith.Forms.UpdateCustomer
{

    public partial class UpdateCustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository;
        private readonly HomeScreen _home;
        private readonly Customer _selectedCustomer;
        public UpdateCustomerForm(CustomerRepository customerRepository, Customer selectedCustomer, HomeScreen home)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _home = home;
            _selectedCustomer = selectedCustomer;

            //******** Current form field values for the customer grid ********//
            updateCustomerName.Text = _selectedCustomer.CustomerName.Trim();
            updateCustomerAddress.Text = _selectedCustomer.AddressName.Trim();
            updateCustomerCountry.Text = _selectedCustomer.CountryName.Trim();
            updateCustomerCity.Text = _selectedCustomer.CityName.Trim();
            updateCustomerPhone.Text = _selectedCustomer.Phone.Trim();

        }


        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            // ******** Update customer form field values ********//

            _selectedCustomer.CustomerName = updateCustomerName.Text.Trim();
            _selectedCustomer.AddressName = updateCustomerAddress.Text.Trim();
            _selectedCustomer.CountryName = updateCustomerCountry.Text.Trim();
            _selectedCustomer.CityName = updateCustomerCity.Text.Trim();
            _selectedCustomer.Phone = updateCustomerPhone.Text.Trim();

            if(string.IsNullOrEmpty(_selectedCustomer.CustomerName) || string.IsNullOrEmpty(_selectedCustomer.AddressName) || string.IsNullOrEmpty(_selectedCustomer.CityName) || string.IsNullOrEmpty(_selectedCustomer.CountryName) || string.IsNullOrEmpty(_selectedCustomer.Phone))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            if(int.TryParse(_selectedCustomer.CustomerName, out _))
            {
                MessageBox.Show("Name field cannot contain numbers.", "Please try again..");
                return;
            }
            if(int.TryParse(_selectedCustomer.CityName, out _))
            {
                MessageBox.Show("City field cannot contain numbers.", "Please try again..");
                return;
            }
            if (int.TryParse(_selectedCustomer.CountryName, out _))
            {
                MessageBox.Show("Country field cannot contain numbers.", "Please try again..");
                return;
            }
            if(_selectedCustomer.Phone.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits.", "Please try again..");
                return;
            }
            foreach (char digit in _selectedCustomer.Phone)
            {
                if (!char.IsDigit(digit) && digit != '-')
                {
                    MessageBox.Show("Phone number field allows only digits and dashes.", "Please try again..");
                    return;
                }
            }

            try
            {
                // ******** Update customer in DB ********//
                _customerRepository.UpdateCustomer(
                     _selectedCustomer.CustomerId,
                     _selectedCustomer.CustomerName,
                     _selectedCustomer.AddressName,
                     _selectedCustomer.CityName,
                     _selectedCustomer.CountryName,
                     _selectedCustomer.Phone);

                _home.RefreshData();
            } 
            
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            this.Close();
        }

        private void CancelAddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
