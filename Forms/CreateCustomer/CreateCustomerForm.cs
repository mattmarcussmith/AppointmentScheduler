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

namespace C969MatthewSmith.Forms
{
    public partial class CreateCustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository;
        public readonly HomeScreen _homeScreen;


        public CreateCustomerForm(CustomerRepository customerRepository, HomeScreen home)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _homeScreen = home;
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
           
            string customerName = InputCustomerName.Text.Trim();
            string customerPhone = InputCustomerPhone.Text.Trim();
            string customerAddress = InputCustomerAddress.Text.Trim();
            string customerCity = InputCustomerCity.Text.Trim();
            string customerCountry = InputCustomerCountry.Text.Trim();

    
            
                if ( string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerPhone) || string.IsNullOrEmpty(customerAddress) || string.IsNullOrEmpty(customerCity) || string.IsNullOrEmpty(customerCountry))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

               if(int.TryParse(customerName, out _))
               {
                    MessageBox.Show("Name field cannot contain numbers.", "Please try again..");
                    return;
               }

            if (int.TryParse(customerCity, out _))
            {
                MessageBox.Show("City field cannot contain numbers.", "Please try again..");
                return;
            }
            if(int.TryParse(customerCountry, out _))
            {
                MessageBox.Show("Country field cannot contain numbers.", "Please try again..");
                return;
            }
            if(customerPhone.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits.", "Please try again..");
                return;
            }
            if (!int.TryParse(customerPhone, out _))
            {
                MessageBox.Show("Name field cannot contain characters.", "Please try again..");
                return;
            }
            foreach (char digit in customerPhone)
                {
                    if (!char.IsDigit(digit) && digit != '-')
                    {
                        MessageBox.Show("Phone number field allows only digits and dashes.", "Please try again..");
                        return;
                    }
                }
              
       
                _customerRepository.CreateCustomer(
                    customerName, 
                    customerAddress, 
                    customerCity, 
                    customerCountry, 
                    customerPhone);

            _homeScreen.RefreshData();
            this.Close();

        }

        private void CancelAddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
