using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Domain.Entities
{
    public sealed class Appointment
    {
        public Appointment() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Doctor? DoctorId { get; set; }
        public Patient? PatientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
