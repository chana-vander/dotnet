using Clinic.Data.Repositories;
using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Models;
using Clinic.Core.Repositories;


namespace Clinic.Data.Repositories
{
    internal class RepositoryManager: IRepositoryManager
    {
        private readonly DataContext _context;
        public IDoctorsRepository doctors { get; set; }
        public IPatientRepository patients { get; set; }
        public IPrescriptionRepository prescriptions { get; set; }

        public RepositoryManager(DataContext context, IDoctorsRepository doctors, IPatientRepository patients, IPrescriptionRepository prescriptions)
        {
            _context = context;
            this.doctors = doctors;
            this.patients = patients;
            this.prescriptions = prescriptions;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}