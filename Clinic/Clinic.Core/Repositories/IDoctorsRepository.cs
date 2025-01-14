using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Models;

namespace Clinic.Core.Repositories
{
    public interface IDoctorsRepository
    {
        List<Doctor> GetAll();
        Doctor? GetById(int id);
        Doctor Add(Doctor doctor);
        Doctor Update(Doctor doctor);
        void Delete(int id);
    }
}
