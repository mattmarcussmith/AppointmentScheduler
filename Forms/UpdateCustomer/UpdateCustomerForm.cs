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
            // ******** Update customer fields ********//

            string updateCustomerName = this.updateCustomerName.Text.Trim();
            string updateCustomerAddress = this.updateCustomerAddress.Text.Trim();
            string updateCustomerCity = this.updateCustomerCity.Text.Trim();
            string updateCustomerCountry = this.updateCustomerCountry.Text.Trim();
            string updateCustomerPhone = this.updateCustomerPhone.Text.Trim();


            // ******** Validation for customer fields ********//
            if (string.IsNullOrEmpty(updateCustomerName) || string.IsNullOrEmpty(updateCustomerAddress) || string.IsNullOrEmpty(updateCustomerCity) || string.IsNullOrEmpty(updateCustomerCountry) || string.IsNullOrEmpty(updateCustomerPhone))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            if (int.TryParse(updateCustomerName, out _))
            {
                MessageBox.Show("Name field cannot contain numbers.", "Please try again..");
                return;
            }
      
            if (int.TryParse(updateCustomerCity, out _))
            {
                MessageBox.Show("City field cannot contain numbers.", "Please try again..");
                return;
            }
            if (int.TryParse(updateCustomerCountry, out _))
            {
                MessageBox.Show("Country field cannot contain numbers.", "Please try again..");
                return;
            }
            if (updateCustomerPhone.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits.", "Please try again..");
                return;
            }


            foreach (char digit in updateCustomerPhone)
            {
                if (!char.IsDigit(digit) && digit != '-')
                {
                    MessageBox.Show("Phone number field allows only digits and dashes.", "Please try again..");
                    return;
                }
            }

            try
            {
                // ******** Update customer in the database ********//
                _customerRepository.UpdateCustomer(

                    _selectedCustomer.CustomerId,
                    updateCustomerName,
                    updateCustomerAddress,
                    updateCustomerCity,
                    updateCustomerCountry,
                    updateCustomerPhone
                    );
                // ******** Update customer in the grid ********//
                _selectedCustomer.CustomerName = updateCustomerName;
                _selectedCustomer.AddressName = updateCustomerAddress;
                _selectedCustomer.CityName = updateCustomerCity;
                _selectedCustomer.CountryName = updateCustomerCountry;
                _selectedCustomer.Phone = updateCustomerPhone;

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
