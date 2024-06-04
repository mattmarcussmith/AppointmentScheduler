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
        public UpdateAppointmentForm(AppointmentRepository appointmentRepository, Appointment selectedAppointment, HomeScreen home)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
            _selectedAppointment = selectedAppointment;
            _home = home;

            InputAppointmentDateTime.Format = DateTimePickerFormat.Custom;
            InputAppointmentDateTime.CustomFormat = " hh:mm tt MM/dd/yyyy";
            InputAppointmentDateTime.ShowUpDown = true;

            InputAppointmentEndTime.Format = DateTimePickerFormat.Custom;
            InputAppointmentEndTime.CustomFormat = " hh:mm tt MM/dd/yyyy";
            InputAppointmentEndTime.ShowUpDown = true;

            //******** Current form field values for the appointment grid ********//
            InputCustomerAppointmentType.Text = _selectedAppointment.Type.Trim();
            InputCustomerNameAppoinment.Text = _selectedAppointment.CustomerName.Trim();
            InputAppointmentDateTime.Value = _selectedAppointment.Start;
            InputAppointmentEndTime.Value = _selectedAppointment.End;
            InputAppointmentCustomerId.Text = _selectedAppointment.CustomerId.ToString().Trim();
            InputUserIdAppointment.Text = _selectedAppointment.UserId.ToString().Trim();

        }

        private void SaveCustomerAppointmentButton_Click(object sender, EventArgs e)
        {
            // ******** Update appointment form field values ********//

            _selectedAppointment.Type = InputCustomerAppointmentType.Text.Trim();
            _selectedAppointment.Start = InputAppointmentDateTime.Value;
            _selectedAppointment.End = InputAppointmentEndTime.Value;
            _selectedAppointment.CustomerName = InputCustomerNameAppoinment.Text.Trim();
            _selectedAppointment.CustomerId = int.Parse(InputAppointmentCustomerId.Text);
            _selectedAppointment.UserId = int.Parse(InputUserIdAppointment.Text.Trim());



            //******** Appointment form field validation ********//
            if (int.TryParse(_selectedAppointment.Type, out _))
            {
                MessageBox.Show("Appointment type cannot be a number.");
                return;
            }

            if (int.TryParse(_selectedAppointment.CustomerName, out _))
            {
                MessageBox.Show("Customer name cannot be a number.");
                return;
            }

            if (string.IsNullOrEmpty(_selectedAppointment.CustomerName) || string.IsNullOrEmpty(_selectedAppointment.Type))
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            if (_appointmentRepository.CheckForOverlappingAppointments(_selectedAppointment.Start, _selectedAppointment.End))
            {
                MessageBox.Show("Appointment times cannot overlap with existing appointments");
                return;
            }

            //******** Appointment time validation ********//
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(17, 0, 0);


            if (_selectedAppointment.Start == _selectedAppointment.End)
            {
                MessageBox.Show("Appointment start and end times cannot be the same");
                return;
            }
  
            if(_selectedAppointment.End.TimeOfDay < startTime || _selectedAppointment.End.TimeOfDay > endTime)
            {
                MessageBox.Show("Appointment must be between 9:00 AM and 5:00 PM");
                return;
            }
            if(_selectedAppointment.Start > _selectedAppointment.End)
            {
                MessageBox.Show("Appointment start time cannot be after the end time");
                return;
            }
            if(_selectedAppointment.Start < DateTime.Now)
            {
                MessageBox.Show("Appointment start time cannot be in the past");
                return;
            }
            if (_selectedAppointment.Start > DateTime.Now.AddMonths(1) || _selectedAppointment.End > DateTime.Now.AddMonths(1))
            {
                MessageBox.Show("Appointment start or end time cannot be more than 1 month in the future");
                return;
            }

            try
            {
                
                _appointmentRepository.UpdateAppointment(_selectedAppointment.CustomerId, _selectedAppointment.CustomerName, _selectedAppointment.UserId, _selectedAppointment.Type, _selectedAppointment.Start, _selectedAppointment.End);

                _home.RefreshData();
                this.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CancelCreateAppointmentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
