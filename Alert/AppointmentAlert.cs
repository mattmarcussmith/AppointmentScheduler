using C969MatthewSmith.Models;
using C969MatthewSmith.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969MatthewSmith.Alert
{
   
    public class AppointmentAlert
    {

        private readonly AppointmentRepository _appointmentRepostiory;
       
        public AppointmentAlert(AppointmentRepository appointmentRepostiory )
        {
            _appointmentRepostiory = appointmentRepostiory;
        }
        public void GetAppointmentAlert(int userId)
        {
            DateTime currentTime = System.DateTime.Now;
            List<Appointment> upcomingAppointments = _appointmentRepostiory.GetAppointmentsByUserId(userId);

            foreach (var appointment in upcomingAppointments)
            {
                TimeSpan timeUntilAppointment = appointment.Start - currentTime;
                if(timeUntilAppointment.TotalMinutes < 15 && timeUntilAppointment.TotalMinutes > 0)
                {
                    MessageBox.Show($"Appointment with {appointment.UserName} is scheduled for {appointment.Start}.");
                    return;
                }


            }
        }

    }
}
