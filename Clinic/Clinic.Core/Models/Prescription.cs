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
        //רבים ליחיד
        public int DoctorId { get; set; }
        public Doctor doctor { get; set; }
        public int PatientId { get; set; }
        public Patient patient { get; set; }

    }
}
