using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> GetAll();
        Patient? GetById(int id);
        Task<Patient> AddAsync(Patient patient);
        Patient Update(Patient patient);
        void Delete(int id);
    }
}
