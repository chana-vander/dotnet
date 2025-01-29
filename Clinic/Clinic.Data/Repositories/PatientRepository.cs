using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Clinic.Data.Repository;
using Clinic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext con)
        {
            _context = con;
        }
        public List<Patient> GetAll()
        {
            return _context.patients.Include(p=>p.prescriptionsList).ToList();
        }
        public Patient? GetById(int id)
        {
            return _context.patients.SingleOrDefault(p => p.id == id);
        }
        public async Task<Patient> AddAsync(Patient patient)
        {
            _context.patients.Add(patient);
            await _context.SaveChangesAsync();

            return patient;
        }
        public Patient Update(Patient patient)
        {
            Patient existPatient = GetById(patient.id);
            if (existPatient is null)
            {
                throw new Exception("Patient not found");
            }
            existPatient.phone = patient.phone;
            existPatient.name = patient.name;
            existPatient.status = patient.status;
            _context.SaveChanges();
            return existPatient;
        }
        public void Delete(int id)
        {
            Patient patient = GetById(id);
            /*if (patient is not null)
            {
                _context.patients.Remove(patient);
            }*/
            _context.patients.Remove(patient);
            _context.SaveChanges();
        }
    }

}