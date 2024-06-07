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

        public List<User> GetLeaderShip(int userId)
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
                       WHERE u.userId = @userId LIMIT 1";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
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
            List<Appointment> appointments = new List<Appointment>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT a.type, a.start, u.userName, u.userId 
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
                                Start = (DateTime)reader["start"],
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
                else if (filterAppointments == "CurrentMonth")
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
                            // ******** Convert UTC to local time ********//
                            DateTime startUtcLocal = DateTime.SpecifyKind((DateTime)reader["start"], DateTimeKind.Utc);
                            DateTime endUtcLocal = DateTime.SpecifyKind((DateTime)reader["end"], DateTimeKind.Utc);
                            DateTime startTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(startUtcLocal, localTimeZone);
                            DateTime endTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(endUtcLocal, localTimeZone);

                            Appointment appointment = new Appointment
                            {
                                CustomerId = (int)reader["customerId"],
                                CustomerName = reader["customerName"].ToString(),
                                UserId = (int)reader["userId"],
                                Type = reader["type"].ToString(),
                                Start = startTimeLocal,
                                End = endTimeLocal
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
            DateTime StartTimeLocal = TimeZoneInfo.ConvertTimeToUtc(DateTime.SpecifyKind(start, DateTimeKind.Local), TimeZoneInfo.Local);
            DateTime EndTimeLocal = TimeZoneInfo.ConvertTimeToUtc(DateTime.SpecifyKind(end, DateTimeKind.Local), TimeZoneInfo.Local);
            // ******** Create appointment in DB ********//

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string insertCustomerQuery =
                    @"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                        VALUES (@customerName, @addressId, 1, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                var insertCustomerCmd = new MySqlCommand(insertCustomerQuery, connection);
                insertCustomerCmd.Parameters.AddWithValue("@customerName", customerName);
                insertCustomerCmd.Parameters.AddWithValue("@addressId", 1);
                insertCustomerCmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                insertCustomerCmd.Parameters.AddWithValue("@createdBy", "system");
                insertCustomerCmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                insertCustomerCmd.Parameters.AddWithValue("@lastUpdateBy", "system");
                insertCustomerCmd.ExecuteNonQuery();

                // ******** Get the customerId of the newly created customer ********//
                int customerId = (int)insertCustomerCmd.LastInsertedId;

                string insertUserId =
                     @"INSERT INTO user (userName, password, createDate, createdBy, lastUpdate, lastUpdateBy)
                        VALUES (@userName, @password, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                var insertUserIdCmd = new MySqlCommand(insertUserId, connection);
                insertUserIdCmd.Parameters.AddWithValue("@userName", "system");
                insertUserIdCmd.Parameters.AddWithValue("@password", "system");
                insertUserIdCmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                insertUserIdCmd.Parameters.AddWithValue("@createdBy", "system");
                insertUserIdCmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                insertUserIdCmd.Parameters.AddWithValue("@lastUpdateBy", "system");
                insertUserIdCmd.ExecuteNonQuery();




                // ******** Get the userId of the newly created user ********//
                int userId = (int)insertUserIdCmd.LastInsertedId;

                string insertAppointmentQuery =
                        @"INSERT INTO appointment (customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                            VALUES (@customerId, @userId, @type, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                var insertAppointmentCmd = new MySqlCommand(insertAppointmentQuery, connection);
                insertAppointmentCmd.Parameters.AddWithValue("@customerId", customerId);
                insertAppointmentCmd.Parameters.AddWithValue("@userId", userId);
                insertAppointmentCmd.Parameters.AddWithValue("@type", type);
                insertAppointmentCmd.Parameters.AddWithValue("@start", StartTimeLocal);
                insertAppointmentCmd.Parameters.AddWithValue("@end", EndTimeLocal);
                insertAppointmentCmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                insertAppointmentCmd.Parameters.AddWithValue("@createdBy", "system");
                insertAppointmentCmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                insertAppointmentCmd.Parameters.AddWithValue("@lastUpdateBy", "system");
                insertAppointmentCmd.ExecuteNonQuery();
            }
        }
        public void UpdateAppointment(int customerId, string customerName, int userId, string type, DateTime start, DateTime end)
        {
            DateTime StartTimeLocal = TimeZoneInfo.ConvertTimeToUtc(DateTime.SpecifyKind(start, DateTimeKind.Local), TimeZoneInfo.Local);
            DateTime EndTimeLocal = TimeZoneInfo.ConvertTimeToUtc(DateTime.SpecifyKind(end, DateTimeKind.Local), TimeZoneInfo.Local);
            // ******** Update appointment in DB ********//
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string updateAppointmentQuery =
                    @"UPDATE appointment a
                        JOIN customer c ON a.customerId = c.customerId
                        JOIN user u ON a.userId = u.userId
                        SET 
                            c.customerName = @customerName,
                            a.type = @type, 
                            a.start = @start, 
                            a.end = @end, 
                            a.lastUpdate = @lastUpdate, 
                            a.lastUpdateBy = @lastUpdateBy
                        WHERE c.customerId = @customerId";

                using (var command = new MySqlCommand(updateAppointmentQuery, connection))
                {

                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@start", StartTimeLocal);
                    command.Parameters.AddWithValue("@end", EndTimeLocal);
                    command.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    command.Parameters.AddWithValue("@lastUpdateBy", "system");
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteAppointment(int customerId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM appointment WHERE customerId = @customerId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@customerId", customerId);
                    deleteCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckForOverlappingAppointments(DateTime start, DateTime end)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string overlappingAppointmentsQuery =
                    @"SELECT COUNT(*) FROM appointment
                            WHERE 
                              (start >= @start AND start <= @end) OR
                              (end > @start AND end <=@end) OR
                              (start < @start AND end > @end)";
                MySqlCommand overlappingCommand = new MySqlCommand(overlappingAppointmentsQuery, connection);

                overlappingCommand.Parameters.AddWithValue("@start", start);
                overlappingCommand.Parameters.AddWithValue("@end", end);

                int conflict = Convert.ToInt32(overlappingCommand.ExecuteScalar());

                return conflict > 0;
            }
        }

    }
}
