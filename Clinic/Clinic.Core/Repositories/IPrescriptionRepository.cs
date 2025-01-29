using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IPrescriptionRepository
    {
        List<Prescription> GetAll();
        Prescription? GetById(int id);
        Task<Prescription> AddAsync(Prescription p);
        Prescription Update(Prescription p);
        void Delete(int id);
    }
}
