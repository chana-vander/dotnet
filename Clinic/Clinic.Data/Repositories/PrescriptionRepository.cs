using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clinic.Core.Models;
using Clinic.Data.Repository;
using Clinic.Data;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly DataContext _context;
        public PrescriptionRepository(DataContext c)
        {
            _context = c;
        }
        public List<Prescription> GetAll()
        {
            return _context.prescriptions.Include(d=>d.doctor).Include(p=>p.patient).ToList();
        }
        public Prescription? GetById(int id)
        {
            return _context.prescriptions.FirstOrDefault(p => p.Id == id);
        }

        public Prescription Add(Prescription p)
        {
            _context.prescriptions.Add(p);
            _context.SaveChanges();
            return p;
        }
        public Prescription Update(Prescription p)
        {
            Prescription existP = GetById(p.Id);
            if (existP is null)
            {
                throw new Exception("Patient not found");
            }
            existP.Date_passed = p.Date_passed;
            _context.SaveChanges();
            return existP;
        }
        public void Delete(int id)
        {
            Prescription p = GetById(id);
            /*if (patient is not null)
            {
                _context.patients.Remove(patient);
            }*/
            _context.prescriptions.Remove(p);
            _context.SaveChanges();
        }
    }
}
