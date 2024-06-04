using C969MatthewSmith.Forms.CreateAppointment;
using C969MatthewSmith.Forms.Report;
using C969MatthewSmith.Forms.UpdateAppointment;
using C969MatthewSmith.Forms.UpdateCustomer;
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

namespace C969MatthewSmith.Forms.Home
{
    public partial class HomeScreen : Form
    {
        private CustomerRepository _customerRepository;
        private AppointmentRepository _appointmentRepository;

        public HomeScreen()
        {
            InitializeComponent();
        }
        public HomeScreen(CustomerRepository customerRepository, AppointmentRepository appointmentRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _appointmentRepository = appointmentRepository;

            GridPresents();
            RefreshData();
        }

        // ******** DataGrid Predefined settings ********//
        public void GridPresents()
        {
            //******** Customer DataGrid ********//
            DataGridCustomers.AutoGenerateColumns = false;
            DataGridCustomers.ColumnCount = 5;
            DataGridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCustomers.MultiSelect = false;
            DataGridCustomers.ReadOnly = true;
            DataGridCustomers.ClearSelection();

            //******** Appointment DataGrid ********//
            DataGridAppointments.AutoGenerateColumns = false;
            DataGridAppointments.ColumnCount = 6;
            DataGridAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridAppointments.MultiSelect = false;
            DataGridAppointments.ReadOnly = true;
            DataGridAppointments.ClearSelection();



        }
        private void DataGridCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                DataGridCustomers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            }
            else
            {
                DataGridCustomers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;
            }
        }
        private void DataGridAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                DataGridAppointments.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            }
            else
            {
                DataGridAppointments.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;
            }
        }
        private void DataGridBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridCustomers.ClearSelection();
            DataGridAppointments.ClearSelection();
        }

        // ******** DataGrid Refresh ********//
        public void RefreshData()
        {
            List<Customer> updateCustomers = _customerRepository.GetCustomers();
            DataGridCustomers.DataSource = updateCustomers;
            
            string filterAppointments = string.Empty;
            if(CurrentWeekAppRadioButton.Checked)
            {
                filterAppointments = "CurrentWeek";
            } else if(CurrentMonthRadioButton.Checked)
            {
                filterAppointments = "CurrentMonth";
            }

            List<Appointment> updateAppointments = _appointmentRepository.GetAppointments(filterAppointments);
            DataGridAppointments.DataSource = updateAppointments;
        }
        // ******** Appointment Radio Events ********//
        private void AllAppRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CurrentWeekAppRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CurrentMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
        // ******** Appointment Button Click Events ********//
        private void CreateAppointmentButton_Click(object sender, EventArgs e)
        {
            
            var createAppointmentForm = new CreateAppointmentForm(_appointmentRepository, this);
            createAppointmentForm.ShowDialog();
        }

        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            var selectedAppointment = (Appointment)DataGridAppointments.CurrentRow.DataBoundItem;
            if (selectedAppointment == null)
            {
                MessageBox.Show("Please select an appointment to update.");
                return;
            }

            var updateAppointmentForm = new UpdateAppointmentForm(_appointmentRepository, selectedAppointment, this);
            updateAppointmentForm.ShowDialog();

        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            int selectedRow = DataGridAppointments.SelectedRows.Count;
            if (selectedRow == 0)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }
            var selected = (Appointment)DataGridAppointments.CurrentRow.DataBoundItem;
            var result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _appointmentRepository.DeleteAppointment(selected.CustomerId);
                RefreshData();
            }

        }


        // ******** Customer Button Click Events ********//
        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            var createCustomerForm = new CreateCustomerForm(_customerRepository, this);
            createCustomerForm.ShowDialog();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer)DataGridCustomers.CurrentRow.DataBoundItem;
            if(selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            var updateCustomerForm = new UpdateCustomerForm(_customerRepository, selectedCustomer, this);
            updateCustomerForm.ShowDialog();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedRow = DataGridCustomers.SelectedRows.Count;
            if (selectedRow == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }
            var selectedCustomer = (Customer)DataGridCustomers.CurrentRow.DataBoundItem;
            var result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _customerRepository.DeleteCustomer(selectedCustomer.CustomerId);
                RefreshData();
            }

        }


        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm(_appointmentRepository);
            reportForm.ShowDialog();

        }

        private void ExitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
