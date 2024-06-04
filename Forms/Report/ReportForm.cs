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



            int userId = 1;
            DataGridLeaders.AutoGenerateColumns = false;
            var leaders = _appointmentRepository.GetLeaderShip(userId);
            DataGridLeaders.DataSource = leaders;

        }


        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                string month = comboBox1.SelectedItem.ToString();
                string type = comboBox2.SelectedItem.ToString();

                if (data.ContainsKey(month) && data[month].ContainsKey(type))
                {
                    PopulateGrid(data[month][type]);
                }
                else
                {
                    reportGrid.DataSource = new List<(string, int)>();

                }
            }
            else 
            {

                reportGrid.DataSource = new List<(string, int)>();
            }
        }
        private void PopulateGrid(List<(string, int)> data)
        {

            reportGrid.Rows.Clear();
            foreach (var appointment in data)
            {
                reportGrid.Rows.Add(appointment.Item1, appointment.Item2);
                
            }
            foreach(DataGridViewRow row in reportGrid.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }
        }

        private void ReportAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                int userId = (int)comboBox3.SelectedValue;
                var appointments = _appointmentRepository.GetAppointmentsByUserId(userId);

                reportGridAppointment.Rows.Clear();
                foreach (var appointment in appointments)
                {
                    reportGridAppointment.Rows.Add(appointment.Type, appointment.Start, appointment.UserName, appointment.UserId);
                }
            }
            else
            {
                reportGridAppointment.Rows.Clear();
            }
        }

    }
}
