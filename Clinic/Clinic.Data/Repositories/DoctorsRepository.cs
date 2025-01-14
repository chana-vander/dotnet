using Clinic.Core;
using Clinic.Core.Models;
using Clinic.Core.Repositories;
//using Clinic.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repository
{
    public class DoctorsRepository : IDoctorsRepository
    {
        private readonly DataContext _context;
        public DoctorsRepository(DataContext con)
        {
            _context = con;
        }
        public List<Doctor> GetAll()
        {
            return _context.doctors.ToList();
        }
        public Doctor? GetById(int id)
        {
            return _context.doctors.FirstOrDefault(d => d.id == id);
        }
        public Doctor Add(Doctor doctor)
        {
            _context.doctors.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }
        public Doctor Update(Doctor doctor)
        {
            Doctor existDoctor = GetById(doctor.id);
            /*if (existDoctor is null)
            {
                return NotFound("doctor not found");
            }*/
            existDoctor.Doctor_name = doctor.Doctor_name;
            existDoctor.phone = doctor.phone;
            existDoctor.occupation = doctor.occupation;
            _context.SaveChanges();
            return existDoctor;
        }
        public void Delete(int id)
        {
            Doctor doctor = GetById(id);
            /*if (d is not null)
            {
                _context.doctors.Remove(d);
            }*/
            _context.doctors.Remove(doctor);
            _context.SaveChanges(); 

        }
    }
}
