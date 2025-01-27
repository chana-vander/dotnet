using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Dto
{
    public class PrescriptionDto
    {
        public int Id { get; set; }
        public bool Date_passed { get; set; }
        public string Desecription { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
