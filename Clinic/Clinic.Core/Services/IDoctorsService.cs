using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IDoctorsService
    {
        List<Doctor> GetList();
        Doctor? GetById(int id);
        Doctor Add(Doctor doctor);
        Doctor Update(Doctor doctor);
        void Delete(int id);
    }
}
