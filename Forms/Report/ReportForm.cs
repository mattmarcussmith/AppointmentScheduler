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
        private Dictionary<string, Dictionary<string, List<(string, int)>>> data;
        private readonly AppointmentRepository _appointmentRepository;
        public ReportForm(AppointmentRepository appointmentRepository)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
            data = ReportDummyData.GetTypeMonthData();

            comboBox1.DataSource = ReportDummyData.GetMonths();
            comboBox2.DataSource = ReportDummyData.GetAppointmentTypes();

            reportGrid.ColumnCount = 2;
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
                string month = comboBox1.SelectedItem.ToString();
                string type = comboBox2.SelectedItem.ToString();

            // This lambda expression is used to get the appointments for the month and type by taking two params m and t
            // These params are key value pairs for the month and type
            
            Func<string, string, List<(string, int)>> getAppointments = (m, t) =>
            {
                return data.ContainsKey(m) && data[month].ContainsKey(t) ? data[m][t] : new List<(string, int)>();
            };

            var appointments = getAppointments(month, type);
            PopulateGrid(reportGrid, appointments);
        }
        private void PopulateGrid(DataGridView dataGridView, List<(string, int)> data)
        {

            dataGridView.Rows.Clear();
            // This Lambda expression is used to add the data to the grid
            // I used it becaue it is a more concise way to add data to the grid
            // It is also more readable than a for loop
            data.ForEach(appointment =>
            {
                dataGridView.Rows.Add(appointment.Item1, appointment.Item2);
            });
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
