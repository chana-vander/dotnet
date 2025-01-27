using Clinic.Core.Models;

namespace Clinic.API.Models
{
    public class PrescriptionPostModel
    {
        public bool Date_passed { get; set; }
        public string Desecription { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
