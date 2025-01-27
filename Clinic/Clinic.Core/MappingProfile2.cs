using AutoMapper;
using Clinic.Core.Dto;
using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core
{
    public class MappingProfile2:Profile
    {
        public MappingProfile2()
        {
            CreateMap<Doctor, DoctorDto>().ReverseMap();
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<Prescription, PrescriptionDto>().ReverseMap();
        }
    }
}
