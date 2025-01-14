using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//here!
using Clinic.Core.Models;
//using Clinic.Core.Repositories;
using Clinic.Core.Services;
using Clinic.Service;

namespace Clinic.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientService;
        public PatientService(IPatientRepository p)
        {
            _patientService = p;
        }
        public List<Patient> GetList()
        {
            return _patientService.GetAll();
        }
        public Patient? GetById(int id)
        {
            return _patientService.GetById(id);
        }

        public Patient Add(Patient patient)
        {
            return _patientService.Add(patient);
        }
        public Patient Update(Patient patient)
        {
            return _patientService.Update(patient);
        }
        public void Delete(int id)
        {
            _patientService.Delete(id);
        }
    }
}