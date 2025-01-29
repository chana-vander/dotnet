using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IPrescriptionService
    {
        List<Prescription> GetList();
        Prescription? GetById(int id);
        Task<Prescription> AddAsync(Prescription prescription);
        Prescription Update(Prescription prescription);
        void Delete(int id);
    }
}
