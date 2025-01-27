using Clinic.Core.Dto;
using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core
{
    public class Mapping
    {
        public static DoctorDto MapToDoctorDto(Doctor doctor)
        {
            return new DoctorDto { id = doctor.id, Doctor_name = doctor.Doctor_name, occupation = doctor.occupation, phone = doctor.phone };
        }

        public static PatientDto MapToPatientDto(Patient patient)
        {
            return new PatientDto { id = patient.id, name = patient.name, phone = patient.phone, above18 = patient.above18, status = patient.status };
        }

        public static PrescriptionDto MapToPrescriptionDto(Prescription pres)
        {
            return new PrescriptionDto { Id = pres.Id, Date_passed = pres.Date_passed, Desecription = pres.Desecription, DoctorId = pres.DoctorId, PatientId = pres.PatientId };
        }
    }
}