using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IPatientService
    {
        List<Patient> GetList();
        Patient? GetById(int id);
        Patient Add(Patient patient);
        Patient Update(Patient patient);
        void Delete(int id);
    }
}