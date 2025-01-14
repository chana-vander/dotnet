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
    public class PrescriptionService : IPrescriptionService
    {
        private IPrescriptionRepository _prescriptinRepository;
        public PrescriptionService(IPrescriptionRepository p)
        {
            _prescriptinRepository = p;
        }
        public List<Prescription> GetList()
        {
            return _prescriptinRepository.GetAll();
        }
        public Prescription? GetById(int id)
        {
            return _prescriptinRepository.GetById(id);
        }

        public Prescription Add(Prescription prescription)
        {
            return _prescriptinRepository.Add(prescription);
        }
        public Prescription Update(Prescription prescription)
        {
            return _prescriptinRepository.Update(prescription);
        }
        public void Delete(int id)
        {
            _prescriptinRepository.Delete(id);
        }
    }
}
