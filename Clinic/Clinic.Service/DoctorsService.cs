using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class DoctorsService: IDoctorsService
    {
        private readonly IDoctorsRepository _doctorRepository;
        public DoctorsService(IDoctorsRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public List<Doctor> GetList()
        {
            return _doctorRepository.GetAll();
        }
        public Doctor? GetById(int id)
        {
            return _doctorRepository.GetById(id);
        }

        public Doctor Add(Doctor doctor)
        {
            return _doctorRepository.Add(doctor);
        }
        public Doctor Update(Doctor doctor)
        {
            return _doctorRepository.Update(doctor);
        }
        public void Delete(int id) 
        { 
            _doctorRepository.Delete(id);
        }
    }
}
