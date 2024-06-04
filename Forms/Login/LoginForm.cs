using C969MatthewSmith.Forms.Home;
using C969MatthewSmith.ITranslation;
using C969MatthewSmith.Models;
using C969MatthewSmith.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969MatthewSmith.Forms.Login
{
    public partial class LoginForm : Form
    {
        private AppointmentRepository _appointmentRepository;

        public LoginForm(string connectionString)
        {
            InitializeComponent();
            _appointmentRepository = new AppointmentRepository(connectionString);

            UpdateTranslation();


        }
        public void UpdateTranslation()
        {
            TranslationManager translationManager = new TranslationManager();

            ITranslations translation = translationManager.GetTranslation();

            loginHeader.Text = translation.LabelHeader;
            loginLabel.Text = translation.LabelUsername;
            passwordLabel.Text = translation.LabelPassword;
            loginButton.Text = translation.ButtonLogin;
            Exit.Text = translation.ButtonExit;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void GetAppointmentAlert(int userId)
        {
            DateTime currentTime = System.DateTime.Now;
            List<Appointment> upcomingAppointments = _appointmentRepository.GetAppointmentsByUserId(userId);

            foreach (var appointment in upcomingAppointments)
            {
                TimeSpan timeUntilAppointment = appointment.Start - currentTime;
                if (timeUntilAppointment.TotalMinutes < 15 && timeUntilAppointment.TotalMinutes > 0)
                {
                    MessageBox.Show($"Appointment with {appointment.UserName} is scheduled for {appointment.Start}.");
                    return;
                }


            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = inputLogin.Text;
            string password = inputPassword.Text;
           

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password", "Error");
                return;
            }

            var userId = _appointmentRepository.AuthenticateUser(userName, password);
            if (userId != null)
            {
     
                LoginLogger(userName, true);
                GetAppointmentAlert(userId.Value);
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                LoginLogger(userName, false);
                MessageBox.Show("Invalid username or password", "Please try again....");
            }
           
        }
        public void LoginLogger(string username, bool successful)
        {
            try
            {
                DateTime now = DateTime.Now;
                string loginStatus = successful ? "Success" : "Failed login";
                string user = $"Username {username} : {loginStatus} at {now}";
                File.AppendAllText("C:\\Users\\mattm\\source\\repos\\C969MatthewSmith\\Logger\\Login_History.txt", user + Environment.NewLine);

            } catch(Exception ex)
            {
                
                MessageBox.Show("Error logging in: " + ex.Message);

            }
        }
    }
}
