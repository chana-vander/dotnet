using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public bool Date_passed { get; set; }
        public string Desecription { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

       /* public Prescription(int id, bool date_passed, string status, string from_doctor, string to_patient)
        {
            Id = id;
            Date_passed = date_passed;
            Status = status;
            From_doctor = from_doctor;
            To_patient = to_patient;
        }*/
    }
}
