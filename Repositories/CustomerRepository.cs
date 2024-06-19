using C969MatthewSmith.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    string insertCountryQuery =
                        @"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) 
                                          VALUES (@country, NOW(), @createdBy, NOW(), @lastUpdateBy)";
                    MySqlCommand insertCountryCmd = new MySqlCommand(insertCountryQuery, connection);
                    insertCountryCmd.Parameters.AddWithValue("@country", country);
                    insertCountryCmd.Parameters.AddWithValue("@createdBy", "system");
                    insertCountryCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                    insertCountryCmd.ExecuteNonQuery();


                    //****** The ID that links country with city  *****//
                    int countryId = (int)insertCountryCmd.LastInsertedId;
                    string insertCityQuery =
                        @"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) 
                                       VALUES (@city, @countryId, NOW(), @createdBy, NOW(), @lastUpdateBy)";
                    MySqlCommand insertCityCmd = new MySqlCommand(insertCityQuery, connection);
                    insertCityCmd.Parameters.AddWithValue("@city", city);
                    insertCityCmd.Parameters.AddWithValue("@countryId", countryId);
                    insertCityCmd.Parameters.AddWithValue("@createdBy", "system");
                    insertCityCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                    insertCityCmd.ExecuteNonQuery();

                    //****** The ID that links city with address  *****//
                    int cityId = (int)insertCityCmd.LastInsertedId;
                    string insertAddressQuery = @"INSERT INTO address (address, cityId, phone, createDate, createdBy, lastUpdate, lastUpdateBy) 
                                          VALUES (@address, @cityId, @phone, NOW(), @createdBy, NOW(), @lastUpdateBy)";
                    MySqlCommand insertAddressCmd = new MySqlCommand(insertAddressQuery, connection);
                    insertAddressCmd.Parameters.AddWithValue("@address", address);
                    insertAddressCmd.Parameters.AddWithValue("@cityId", cityId);
                    insertAddressCmd.Parameters.AddWithValue("@phone", phone);
                    insertAddressCmd.Parameters.AddWithValue("@createdBy", "system");
                    insertAddressCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                    insertAddressCmd.ExecuteNonQuery();


                    //****** The ID that links address with customer  *****//
                    int addressId = (int)insertAddressCmd.LastInsertedId;
                    string insertCustomerQuery =
                        @"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) 
                                           VALUES ( @customerName, @addressId, @active, NOW(), @createdBy, NOW(), @lastUpdateBy)";
                    MySqlCommand insertCustomerCmd = new MySqlCommand(insertCustomerQuery, connection);


                    insertCustomerCmd.Parameters.AddWithValue("@customerName", customerName);
                    insertCustomerCmd.Parameters.AddWithValue("@addressId", addressId);
                    insertCustomerCmd.Parameters.AddWithValue("@active", 1);
                    insertCustomerCmd.Parameters.AddWithValue("@createdBy", "system");
                    insertCustomerCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                    insertCustomerCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

            } catch(Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    
                    string deleteQuery =
                        @"DELETE c, a, ci, co
                          FROM customer c
                          JOIN address a ON c.addressId = a.addressId
                          JOIN city ci ON a.cityId = ci.cityId
                          JOIN country co ON ci.countryId = co.countryId
                          WHERE c.customerId = @customerId";

                    
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@customerId", customerId);

                    deleteCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
     }
    }

}

