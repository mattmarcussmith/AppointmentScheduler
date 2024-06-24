using C969MatthewSmith.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace C969MatthewSmith.Repositories
{
    public class CustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query =
                    @"SELECT c.customerId, c.customerName, a.phone, a.address, co.country, ci.city 
                           FROM customer c
                           JOIN address a ON c.addressId = a.addressId
                           JOIN city ci ON a.cityId = ci.cityId
                           JOIN country co ON ci.countryId = co.countryId";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerId = (int)reader["customerId"],
                                CustomerName = reader["customerName"].ToString(),
                                Phone = reader["phone"].ToString(),
                                AddressName = reader["address"].ToString(),
                                CountryName = reader["country"].ToString(),
                                CityName = reader["city"].ToString()

                            };

                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;
        }
        public void CreateCustomer(string customerName, string address, string city, string country, string phone)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                
                    int countryId = GetOrCreateCountry(country, connection);
                    int cityId = GetOrCreateCity(city, countryId, connection);
                    int addressId = InsertAddress(address, cityId, phone, connection);

                    // Insert Customer
                    string insertCustomerQuery =
                        @"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) 
                   VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                    MySqlCommand insertCustomerCmd = new MySqlCommand(insertCustomerQuery, connection);
                    insertCustomerCmd.Parameters.AddWithValue("@customerName", customerName);
                    insertCustomerCmd.Parameters.AddWithValue("@addressId", addressId);
                    insertCustomerCmd.Parameters.AddWithValue("@active", 1);
                    insertCustomerCmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow); 
                    insertCustomerCmd.Parameters.AddWithValue("@createdBy", "system");
                    insertCustomerCmd.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                    insertCustomerCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                    insertCustomerCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private int GetOrCreateCountry(string country, MySqlConnection connection)
        {
            string selectCountryQuery = "SELECT countryId FROM country WHERE country = @country";
            MySqlCommand selectCountryCmd = new MySqlCommand(selectCountryQuery, connection);
            selectCountryCmd.Parameters.AddWithValue("@country", country);

            object result = selectCountryCmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                // Insert Country
                string insertCountryQuery =
                    @"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) 
              VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                MySqlCommand insertCountryCmd = new MySqlCommand(insertCountryQuery, connection);
                insertCountryCmd.Parameters.AddWithValue("@country", country);
                insertCountryCmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                insertCountryCmd.Parameters.AddWithValue("@createdBy", "system");
                insertCountryCmd.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                insertCountryCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                insertCountryCmd.ExecuteNonQuery();
                return (int)insertCountryCmd.LastInsertedId;
            }
        }

        private int GetOrCreateCity(string city, int countryId, MySqlConnection connection)
        {
            string selectCityQuery = "SELECT cityId FROM city WHERE city = @city AND countryId = @countryId";
            MySqlCommand selectCityCmd = new MySqlCommand(selectCityQuery, connection);
            selectCityCmd.Parameters.AddWithValue("@city", city);
            selectCityCmd.Parameters.AddWithValue("@countryId", countryId);
      


            object result = selectCityCmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                // Insert City
                string insertCityQuery =
                    @"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) 
              VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                MySqlCommand insertCityCmd = new MySqlCommand(insertCityQuery, connection);
                insertCityCmd.Parameters.AddWithValue("@city", city);
                insertCityCmd.Parameters.AddWithValue("@countryId", countryId);
                insertCityCmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                insertCityCmd.Parameters.AddWithValue("@createdBy", "system");
                insertCityCmd.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                insertCityCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                insertCityCmd.ExecuteNonQuery();
                return (int)insertCityCmd.LastInsertedId;
            }
        }

        private int InsertAddress(string address, int cityId, string phone, MySqlConnection connection)
        {
            string insertAddressQuery =
                @"INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) 
          VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
            MySqlCommand insertAddressCmd = new MySqlCommand(insertAddressQuery, connection);
            insertAddressCmd.Parameters.AddWithValue("@address", address);
            insertAddressCmd.Parameters.AddWithValue("@address2", "test");
            insertAddressCmd.Parameters.AddWithValue("@cityId", cityId);
            insertAddressCmd.Parameters.AddWithValue("@postalCode", "12345"); 
            insertAddressCmd.Parameters.AddWithValue("@phone", phone);
            insertAddressCmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
            insertAddressCmd.Parameters.AddWithValue("@createdBy", "system");
            insertAddressCmd.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
            insertAddressCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

            insertAddressCmd.ExecuteNonQuery();
            return (int)insertAddressCmd.LastInsertedId;
        }

        public void UpdateCustomer(int customerId, string customerName, string address, string city, string country, string phone)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string updateQuery =
                        @"UPDATE customer c
                          JOIN address a ON c.addressId = a.addressId
                          JOIN city ci ON a.cityId = ci.cityId
                          JOIN country co ON ci.countryId = co.countryId
                          SET
                             c.customerName = @customerName,
                             a.address = @address,
                             a.phone = @phone,
                             ci.city = @city,
                             co.country = @country,
                             c.lastUpdate = NOW(),
                             c.lastUpdateBy = 'system',
                             a.lastUpdate = NOW(),
                             a.lastUpdateBy = 'system',
                             ci.lastUpdate = NOW(),
                             ci.lastUpdateBy = 'system',
                             co.lastUpdate = NOW(),
                             co.lastUpdateBy = 'system'
                            WHERE c.customerId = @customerId";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@customerId", customerId);
                    updateCmd.Parameters.AddWithValue("@customerName", customerName);
                    updateCmd.Parameters.AddWithValue("@address", address);
                    updateCmd.Parameters.AddWithValue("@phone", phone);
                    updateCmd.Parameters.AddWithValue("@city", city);
                    updateCmd.Parameters.AddWithValue("@country", country);

                    updateCmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM customer WHERE customerId = @customerId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@customerId", customerId);

                    deleteCmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}");
                return false;
            }
        }
        public bool CheckCustomerHasAppointments(int customerId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    // Query to check if there are any appointments for the given customer
                    string query = "SELECT COUNT(*) FROM appointment WHERE customerId = @customerId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerId", customerId);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error checking appointments: {ex.Message}");
                return true;
            }
        }
    }
}