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
        private readonly TimeZoneInfo _easternTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

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


            if (int.TryParse(_selectedAppointment.Type, out _))
            {
                MessageBox.Show("Type must be a letters.");
                return;
            }
            if (int.TryParse(_selectedAppointment.CustomerName, out _))
            {
                MessageBox.Show("Customer name must be a letters.");
                return;
            }
            if (_selectedAppointment.CustomerId <= 0)
            {
                MessageBox.Show("Customer ID must be greater than 0.");
                return;
            }
           
            if (string.IsNullOrEmpty(_selectedAppointment.CustomerName))
            {
                MessageBox.Show("Customer name cannot be empty.");
                return;
            }
           
            DateTime startEt = TimeZoneInfo.ConvertTime(_selectedAppointment.Start, TimeZoneInfo.Local, _easternTimeZone);
            DateTime endEt = TimeZoneInfo.ConvertTime(_selectedAppointment.End, TimeZoneInfo.Local, _easternTimeZone);

            TimeSpan startTimeEt = new TimeSpan(9, 0, 0); 
            TimeSpan endTimeEt = new TimeSpan(17, 0, 0); 

            if (startEt.TimeOfDay < startTimeEt || endEt.TimeOfDay > endTimeEt)
            {
                MessageBox.Show("Appointment start and end times must be between 9:00 AM and 5:00 PM Eastern Time (ET)");
                return;
            }

            if (_selectedAppointment.Start >= _selectedAppointment.End)
            {
                MessageBox.Show("Appointment start time must be before the end time.");
                return;
            }
            if(_selectedAppointment.Start < DateTime.Now)
            {

                MessageBox.Show("Appointment start time cannot be in the past or current time.");
            }
            

          
          
                if (_appointmentRepository.CheckForOverlappingAppointments(_selectedAppointment.Start, _selectedAppointment.End))
                {
                    MessageBox.Show("Appointment times cannot overlap with existing appointments");
                    return;
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
