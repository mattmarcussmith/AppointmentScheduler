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
        public readonly TimeZoneInfo _centralTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");

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
            string customerName = InputCustomerNameAppoinment.Text.Trim();

        

            string type = InputCustomerAppointmentType.Text.Trim();

            DateTime startLocal = InputAppointmentDateTime.Value;
            DateTime endLocal = InputAppointmentEndTime.Value;
            DateTime startCt = TimeZoneInfo.ConvertTime(startLocal, TimeZoneInfo.Local, _centralTimeZone);
            DateTime endCt = TimeZoneInfo.ConvertTime(endLocal, TimeZoneInfo.Local, _centralTimeZone);

            // Validate times against Central Time (CT) hours of operation (9 AM to 5 PM)
            TimeSpan startTimeCt = new TimeSpan(9, 0, 0); // 9:00 AM CT
            TimeSpan endTimeCt = new TimeSpan(17, 0, 0); // 5:00 PM CT


            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer name cannot be empty.");
                return;
            }
            if(startCt > endCt)
            {
                MessageBox.Show("Appointment start time cannot be after the end time.");
                return;
            }

            // Check if the appointment is within 9 AM - 5 PM CT
            if (startCt.TimeOfDay < startTimeCt || endCt.TimeOfDay > endTimeCt)
            {
                MessageBox.Show("Appointment start and end times must be between 9:00 AM and 5:00 PM Central Time (CT)");
                return;
            }

            DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(startCt, _centralTimeZone);
            DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(endCt, _centralTimeZone);

            if (_appointmentRepository.CheckForOverlappingAppointments(startUtc, endUtc))
            {
                MessageBox.Show("Appointment times cannot overlap with existing appointments");
                return;
            }
            try
            {
                _appointmentRepository.CreateAppointment( customerName, type, startUtc, endUtc);
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
    }

}
