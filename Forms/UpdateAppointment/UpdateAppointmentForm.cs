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

namespace C969MatthewSmith.Forms.UpdateAppointment
{
    public partial class UpdateAppointmentForm : Form
    {
        private readonly AppointmentRepository _appointmentRepository;
        private readonly HomeScreen _home;
        private readonly Appointment _selectedAppointment;
        private readonly TimeZoneInfo _centralTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");

        public UpdateAppointmentForm(AppointmentRepository appointmentRepository, Appointment selectedAppointment, HomeScreen home)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
            _selectedAppointment = selectedAppointment;
            _home = home;

            // Initialize form fields with current appointment data
            InputAppointmentDateTime.Format = DateTimePickerFormat.Custom;
            InputAppointmentDateTime.CustomFormat = " hh:mm tt MM/dd/yyyy";
            InputAppointmentDateTime.ShowUpDown = true;
            InputAppointmentDateTime.Value = _selectedAppointment.Start;

            InputAppointmentEndTime.Format = DateTimePickerFormat.Custom;
            InputAppointmentEndTime.CustomFormat = " hh:mm tt MM/dd/yyyy";
            InputAppointmentEndTime.ShowUpDown = true;
            InputAppointmentEndTime.Value = _selectedAppointment.End;

            InputCustomerAppointmentType.Text = _selectedAppointment.Type.Trim();
            InputCustomerNameAppoinment.Text = _selectedAppointment.CustomerName.Trim();
            InputAppointmentCustomerId.Text = _selectedAppointment.CustomerId.ToString().Trim();
            InputUserIdAppointment.Text = _selectedAppointment.UserId.ToString().Trim();
        }

        private void SaveCustomerAppointmentButton_Click(object sender, EventArgs e)
        {
            // Update appointment fields with current form values
            _selectedAppointment.Type = InputCustomerAppointmentType.Text.Trim();
            _selectedAppointment.Start = InputAppointmentDateTime.Value;
            _selectedAppointment.End = InputAppointmentEndTime.Value;
            _selectedAppointment.CustomerName = InputCustomerNameAppoinment.Text.Trim();
            _selectedAppointment.CustomerId = int.Parse(InputAppointmentCustomerId.Text.Trim());
            _selectedAppointment.UserId = int.Parse(InputUserIdAppointment.Text.Trim());

            // Validate appointment fields
            if (string.IsNullOrEmpty(_selectedAppointment.Type))
            {
                MessageBox.Show("Appointment type cannot be empty.");
                return;
            }
          
            if(_selectedAppointment.CustomerId <= 0)
            {
                MessageBox.Show("Customer ID must be greater than 0.");
                return;
            }
           
            if (string.IsNullOrEmpty(_selectedAppointment.CustomerName))
            {
                MessageBox.Show("Customer name cannot be empty.");
                return;
            }
           
            // Validate appointment times against business rules
            DateTime startCt = TimeZoneInfo.ConvertTime(_selectedAppointment.Start, TimeZoneInfo.Local, _centralTimeZone);
            DateTime endCt = TimeZoneInfo.ConvertTime(_selectedAppointment.End, TimeZoneInfo.Local, _centralTimeZone);

            TimeSpan startTimeCt = new TimeSpan(9, 0, 0); // 9:00 AM CT
            TimeSpan endTimeCt = new TimeSpan(17, 0, 0); // 5:00 PM CT

            if (startCt.TimeOfDay < startTimeCt || endCt.TimeOfDay > endTimeCt)
            {
                MessageBox.Show("Appointment start and end times must be between 9:00 AM and 5:00 PM Central Time (CT)");
                return;
            }

            if (_selectedAppointment.Start >= _selectedAppointment.End)
            {
                MessageBox.Show("Appointment start time must be before the end time.");
                return;
            }

            if ((_selectedAppointment.Start == _selectedAppointment.Start && _selectedAppointment.End == _selectedAppointment.End )|| (_selectedAppointment.Start != _selectedAppointment.Start && _selectedAppointment.End != _selectedAppointment.End))
            {

            }
           
            else
            {
                // Check for overlapping appointments only if the times have changed
                if (_appointmentRepository.CheckForOverlappingAppointments(_selectedAppointment.Start, _selectedAppointment.End))
                {
                    MessageBox.Show("Appointment times cannot overlap with existing appointments");
                    return;
                }
            }

            // Update appointment in repository
            try
            {
                _appointmentRepository.UpdateAppointment(
                    _selectedAppointment.CustomerId,
                    _selectedAppointment.CustomerName,
                    _selectedAppointment.UserId,
                    _selectedAppointment.Type,
                    _selectedAppointment.Start,
                    _selectedAppointment.End);

                _home.RefreshData();
                MessageBox.Show("Appointment updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update appointment: {ex.Message}");
            }
        }

        private void CancelCreateAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
