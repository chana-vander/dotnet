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
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor,DoctorDto>().ReverseMap();
            CreateMap<Patient,PatientDto>().ReverseMap();
            CreateMap<Prescription,PrescriptionDto>().ReverseMap();
        }
    }
}
