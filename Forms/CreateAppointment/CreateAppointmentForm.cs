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
            DateTime start = InputAppointmentDateTime.Value;
            DateTime end = InputAppointmentEndTime.Value;

            //******** Customer form field validation ********//
            if (int.TryParse(customerName, out _))
            {
                MessageBox.Show("Customer name cannot be a number");
                return;
            }
            if(int.TryParse(type, out _))
            {
                MessageBox.Show("Appointment type cannot be a number");
                return;
            }


            //******** Appointment form field validation ********//
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(17, 0, 0);

           if(start == end)
            {
                MessageBox.Show("Appointment start and end times cannot be the same");
                return;
            }
            if(start.TimeOfDay < startTime || end.TimeOfDay > endTime)
            {
                MessageBox.Show("Appointment start and end times must be between 9:00 AM and 5:00 PM");
                return;
            }
            if(start.TimeOfDay > end.TimeOfDay)
            {
                MessageBox.Show("Appointment start time cannot be after the end time");
                return;
            }
         
            if (start < DateTime.Now)
            {
                MessageBox.Show("Appointment start time cannot be in the past");
                return;
            }
            if (start > DateTime.Now.AddMonths(1) || end > DateTime.Now.AddMonths(1))
            {
                MessageBox.Show("Appointment start or end time cannot be more than 1 month in the future");
                return;
            }
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
         
            if(_appointmentRepository.CheckForOverlappingAppointments(start, end))
            {
                MessageBox.Show("Appointment times cannot overlap with existing appointments");
                return;
            }

            try
            {
                _appointmentRepository.CreateAppointment(customerName, type, start, end);
                _home.RefreshData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
