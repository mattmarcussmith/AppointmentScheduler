using C969MatthewSmith.Forms.Home;
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

namespace C969MatthewSmith.Forms.CreateAppointment
{
    public partial class CreateAppointmentForm : Form
    {
        private readonly AppointmentRepository _appointmentRepository;
        private readonly HomeScreen _home;
        public readonly TimeZoneInfo _easternTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        public CreateAppointmentForm(AppointmentRepository appointmentRepository, HomeScreen home)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
            _home = home;

            InputAppointmentDateTime.Format = DateTimePickerFormat.Custom;
            InputAppointmentDateTime.CustomFormat = " hh:mm tt MM/dd/yyyy";
            InputAppointmentDateTime.ShowUpDown = true;

            InputAppointmentEndTime.Format = DateTimePickerFormat.Custom;
            InputAppointmentEndTime.CustomFormat = " hh:mm tt MM/dd/yyyy";
            InputAppointmentEndTime.ShowUpDown = true;
        }

        private void SaveCustomerAppointmentButton_Click(object sender, EventArgs e)
        {
            string customerName = InputCustomerNameAppointment.Text.Trim();
            string userName = InputAppointmentUserName.Text.Trim();
            string type = InputCustomerAppointmentType.Text.Trim();



            if(int.TryParse(type, out _))
            {
                MessageBox.Show("Type must be a letters.");
                return;
            }

            if (int.TryParse(InputAppointmentUserName.Text.Trim(), out _))
            {
                MessageBox.Show("User name must be a letters.");
                return;
            }
            if(int.TryParse(InputCustomerNameAppointment.Text.Trim(), out _))
            {
                MessageBox.Show("Customer name must be a letters.");
                return;
            }

        

            DateTime startLocal = InputAppointmentDateTime.Value;
            DateTime endLocal = InputAppointmentEndTime.Value;
            DateTime startEt = TimeZoneInfo.ConvertTime(startLocal, TimeZoneInfo.Local, _easternTimeZone);
            DateTime endEt = TimeZoneInfo.ConvertTime(endLocal, TimeZoneInfo.Local, _easternTimeZone);

            TimeSpan startTimeEt = new TimeSpan(9, 0, 0); 
            TimeSpan endTimeEt = new TimeSpan(17, 0, 0); 


            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer name cannot be empty.");
                return;
            }
            if(string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("User name cannot be empty.");
                return;
            }
            if(startEt < DateTime.Now)
            {

                MessageBox.Show("Appointment start time cannot be in the past.");
            }
         
                if (startEt > endEt)
            {
                MessageBox.Show("Appointment start time cannot be after the end time.");
                return;
            }
            if (startEt.TimeOfDay < startTimeEt || endEt.TimeOfDay > endTimeEt)
            {
                MessageBox.Show("Appointment start and end times must be between 9:00 AM and 5:00 PM Eastern Time (ET)");
                return;
            }

            DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(startEt, _easternTimeZone);
            DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(endEt, _easternTimeZone);

            if (_appointmentRepository.CheckForOverlappingAppointments(startUtc, endUtc))
            {
                MessageBox.Show("Appointment times cannot overlap with existing appointments");
                return;
            }
            try
            {
                _appointmentRepository.CreateAppointment(customerName, userName, type, startUtc, endUtc);
                _home.RefreshData();
                MessageBox.Show("Appointment created successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create appointment: {ex.Message}");
                // Consider logging the exception
            }
        }

        private void CancelCreateAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
