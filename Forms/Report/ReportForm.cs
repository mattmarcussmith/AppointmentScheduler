using C969MatthewSmith.Models;
using C969MatthewSmith.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace C969MatthewSmith.Forms.Report
{
    public partial class ReportForm : Form
    {
        private readonly AppointmentRepository _appointmentRepository;
        public ReportForm(AppointmentRepository appointmentRepository)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
       
            reportGrid.ColumnCount = 3;
            reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportGrid.MultiSelect = false;
            reportGrid.ReadOnly = true;

       
            comboBox3.DataSource = _appointmentRepository.GetUsers();
            comboBox3.DisplayMember = "userName";
            comboBox3.ValueMember = "userId";

            
            reportGridAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportGridAppointment.MultiSelect = false;
            reportGridAppointment.ReadOnly = true;
            reportGridAppointment.AutoGenerateColumns = false;

            reportGridAppointment.ColumnCount = 4;
           
            DataGridLeaders.AutoGenerateColumns = false;
            var leaders = _appointmentRepository.GetLeaderShip();
            DataGridLeaders.DataSource = leaders;
        }
        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
          
            reportGrid.Rows.Clear();
            List<(string, int, DateTime)> appointmentsData = _appointmentRepository.GetAppointmentsByTypeAndMonth();

            // Populate DataGridView
            foreach (var data in appointmentsData)
            {
                reportGrid.Rows.Add(data.Item1, data.Item2, data.Item3.ToString("MMMM yyyy"));
            }
        }


        private void ReportAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                int userId = (int)comboBox3.SelectedValue;
                var appointments = _appointmentRepository.GetAppointmentsByUserId(userId);

                reportGridAppointment.Rows.Clear();

                // This Lambda expression is used to add the data to the grid
                // I used it becaue it is a more concise way to add data to the grid
                // It is also more readable than a for loop
                appointments.ForEach(appointment =>
                {
                    reportGridAppointment.Rows.Add(appointment.Type, appointment.Start, appointment.UserName, appointment.UserId);
                });
            }
            else
            {
                reportGridAppointment.Rows.Clear();
            }
        }

    }
}
