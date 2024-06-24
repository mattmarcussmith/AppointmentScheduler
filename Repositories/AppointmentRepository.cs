using C969MatthewSmith.Forms.Home;
using C969MatthewSmith.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969MatthewSmith.Repositories
{
    public class AppointmentRepository
    {
        private readonly string _connectionString;

        public AppointmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int? AuthenticateUser(string userName, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT userId FROM user WHERE userName = @userName AND password = @password";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);
                    var userId = command.ExecuteScalar();
                    if (userId != null && userName == "test" && password == "test")
                    {
                        return Convert.ToInt32(userId);
                    }
                    else
                    {
                        return null;
                    }
                }
            }

        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT userId, userName FROM user";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = (int)reader["userId"],
                                UserName = reader["userName"].ToString()
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

        public List<User> GetLeaderShip()
        {
            List<User> users = new List<User>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT u.userName, u.userId, ad.phone
                       FROM user u 
                       JOIN appointment a ON u.userId = a.userId
                       JOIN customer c ON a.customerId = c.customerId
                       JOIN address ad ON c.addressId = ad.addressId
                       ORDER BY u.userId
                       LIMIT 3";

                using (var command = new MySqlCommand(query, connection))
                {
                   
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {

                                UserId = (int)reader["userId"],
                                UserName = reader["userName"].ToString(),
                                Phone = reader["phone"].ToString()
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
        public List<Appointment> GetAppointmentsByUserId(int userId)
        {

            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
    

            List<Appointment> appointments = new List<Appointment>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT a.type, a.start, a.end,  u.userName, u.userId 
                                FROM appointment a 
                                JOIN user u ON a.userId = u.userId 
                                WHERE a.userId = @userId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {


                            Appointment appointment = new Appointment
                            {
                                Type = reader["type"].ToString(),
                                Start = TimeZoneInfo.ConvertTimeFromUtc((DateTime)reader["start"], localTimeZone),
                                End = TimeZoneInfo.ConvertTimeFromUtc((DateTime)reader["end"], localTimeZone),

                                UserName = reader["userName"].ToString(),
                                UserId = (int)reader["userId"]
                            };
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }


        public List<Appointment> GetAppointments(string filterAppointments)
        {
            // ***** Sets local and checks if its daylight savings *****//
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
   

            // ******** Get appointments from DB ********//
            List<Appointment> appointments = new List<Appointment>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                //******** Default appointments query ********//
                string appointmentsQuery =
                    @"SELECT c.customerId, u.userId, a.type, a.start, a.end, c.customerName
                        FROM appointment a
                        JOIN customer c ON a.customerId = c.customerId
                        JOIN user u ON a.userId = u.userId";

                //******** Filter appointments by day ********//
                if (filterAppointments == "CurrentDay")
                {
                    appointmentsQuery = @"SELECT c.customerId, u.userId, a.type, a.start, a.end, c.customerName
                        FROM appointment a
                        JOIN customer c ON a.customerId = c.customerId
                        JOIN user u ON a.userId = u.userId
                        WHERE DAY(a.start) = DAY(NOW()) AND MONTH(a.start) = MONTH(NOW()) AND YEAR(a.start) = YEAR(NOW())";
                }
                {
                    
                }
                //******** Filter appointments by week ********//
                if (filterAppointments == "CurrentWeek")
                {
                    appointmentsQuery = @"SELECT c.customerId, u.userId, a.type, a.start, a.end, c.customerName
                        FROM appointment a
                        JOIN customer c ON a.customerId = c.customerId
                        JOIN user u ON a.userId = u.userId
                        WHERE WEEK(a.start) = WEEK(NOW()) AND YEAR(a.start) = YEAR(NOW())";
                }
                //******** Filter appointments by month ********//
                if (filterAppointments == "CurrentMonth")
                {
                    appointmentsQuery = @"SELECT c.customerId, u.userId, a.type, a.start, a.end, c.customerName
                        FROM appointment a
                        JOIN customer c ON a.customerId = c.customerId
                        JOIN user u ON a.userId = u.userId
                        WHERE MONTH(a.start) = MONTH(NOW()) AND YEAR(a.start) = YEAR(NOW())";
                }
                using (var command = new MySqlCommand(appointmentsQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                         

                            Appointment appointment = new Appointment
                            {
                          
                                CustomerId = (int)reader["customerId"],
                                CustomerName = reader["customerName"].ToString(),
                                UserId = (int)reader["userId"],
                                Type = reader["type"].ToString(),
                                Start = TimeZoneInfo.ConvertTimeFromUtc((DateTime)reader["start"], localTimeZone),
                                End = TimeZoneInfo.ConvertTimeFromUtc((DateTime)reader["end"], localTimeZone),
                            };
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }
        public void CreateAppointment(string customerName, string type, DateTime start, DateTime end)
        {
            try
            {
                int customerId = GetOrCreateCustomer(customerName);

                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

             
                    DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(start, TimeZoneInfo.Local);
                    DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(end, TimeZoneInfo.Local);

                    // Insert Appointment
                    string insertAppointmentQuery =
                        @"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                  VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                    var insertAppointmentCmd = new MySqlCommand(insertAppointmentQuery, connection);
                    insertAppointmentCmd.Parameters.AddWithValue("@customerId", customerId);
                    insertAppointmentCmd.Parameters.AddWithValue("@userId", 1); 
                    insertAppointmentCmd.Parameters.AddWithValue("@title", "system");
                    insertAppointmentCmd.Parameters.AddWithValue("@description", "system");
                    insertAppointmentCmd.Parameters.AddWithValue("@location", "system");
                    insertAppointmentCmd.Parameters.AddWithValue("@contact", "system");
                    insertAppointmentCmd.Parameters.AddWithValue("@type", type);
                    insertAppointmentCmd.Parameters.AddWithValue("@url", "system");
                    insertAppointmentCmd.Parameters.AddWithValue("@start", startUtc);
                    insertAppointmentCmd.Parameters.AddWithValue("@end", endUtc);
                    insertAppointmentCmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    insertAppointmentCmd.Parameters.AddWithValue("@createdBy", "system");
                    insertAppointmentCmd.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                    insertAppointmentCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                    insertAppointmentCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private int GetOrCreateCustomer(string customerName)
        {
            int customerId = 0;

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                 
                    string getCustomerIdQuery =
                        @"SELECT customerId FROM customer WHERE customerName = @customerName";
                    var getCustomerIdCmd = new MySqlCommand(getCustomerIdQuery, connection);
                    getCustomerIdCmd.Parameters.AddWithValue("@customerName", customerName);

                    object result = getCustomerIdCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        customerId = Convert.ToInt32(result);
                    }
                    else
                    {
          
                        string insertCustomerQuery =
                            @"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) 
                      VALUES (@customerName, 0, 1, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                        var insertCustomerCmd = new MySqlCommand(insertCustomerQuery, connection);
                        insertCustomerCmd.Parameters.AddWithValue("@customerName", customerName);
                        insertCustomerCmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                        insertCustomerCmd.Parameters.AddWithValue("@createdBy", "system");
                        insertCustomerCmd.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                        insertCustomerCmd.Parameters.AddWithValue("@lastUpdateBy", "system");

                        insertCustomerCmd.ExecuteNonQuery();

                       
                        customerId = (int)insertCustomerCmd.LastInsertedId;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customerId;
        }

        public void UpdateAppointment(int customerId, string customerName, int userId, string type, DateTime start, DateTime end)
        {
           
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(start, TimeZoneInfo.Local);
                DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(end, TimeZoneInfo.Local);

                string updateAppointmentQuery =
                    @"UPDATE appointment a
                        JOIN customer c ON a.customerId = c.customerId
                        JOIN user u ON a.userId = u.userId
                        SET 
                            c.customerId = @customerId,
                            c.customerName = @customerName,
                            u.userId = @userId,
                            a.type = @type, 
                            a.start = @start, 
                            a.end = @end, 
                            a.createDate = @createDate,
                            a.createdBy = @createdBy,
                            a.lastUpdate = @lastUpdate, 
                            a.lastUpdateBy = @lastUpdateBy
                        WHERE c.customerId = @customerId";

                using (var command = new MySqlCommand(updateAppointmentQuery, connection))
                {

                    command.Parameters.AddWithValue("@customerId", customerId);

                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@start", startUtc);
                    command.Parameters.AddWithValue("@end", endUtc);
                    command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@createdBy", "system");
                    command.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@lastUpdateBy", "system");
                   
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool DeleteAppointment(int customerId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string deleteAppointmentQuery =
                        @"DELETE FROM appointment WHERE customerId = @customerId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteAppointmentQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@customerId", customerId);
                    deleteCmd.ExecuteNonQuery();

                    return true;

                }
            } catch(MySqlException ex)
            {
                MessageBox.Show($"Error deleting appointment: {ex.Message}");
                return false;
            }
        }
   
        public bool CheckForOverlappingAppointments(DateTime start, DateTime end)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(start, TimeZoneInfo.Local);
                DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(end, TimeZoneInfo.Local);

                string overlappingAppointmentsQuery =
                    @"SELECT COUNT(*) FROM appointment
                            WHERE 
                              (start >= @start AND start <= @end) OR
                              (end > @start AND end <=@end) OR
                              (start < @start AND end > @end)";
                MySqlCommand overlappingCommand = new MySqlCommand(overlappingAppointmentsQuery, connection);

                overlappingCommand.Parameters.AddWithValue("@start", startUtc);
                overlappingCommand.Parameters.AddWithValue("@end", endUtc);

                int conflict = Convert.ToInt32(overlappingCommand.ExecuteScalar());

                return conflict > 0;
            }
        }

    }
}
