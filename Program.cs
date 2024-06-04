
using C969MatthewSmith.Forms.Home;
using C969MatthewSmith.Forms.Login;
using C969MatthewSmith.Repositories;
using System;

using System.Configuration;

using System.Windows.Forms;

namespace C969MatthewSmith
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
    
            var customerRepository = new CustomerRepository(connectionString);
            var appointmentRepository = new AppointmentRepository(connectionString);

            var loginForm = new LoginForm(connectionString);
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                var homeForm = new HomeScreen(customerRepository, appointmentRepository);
                Application.Run(homeForm);
            } else
            {
                Application.Exit();
            }
   
        }
    }
}
