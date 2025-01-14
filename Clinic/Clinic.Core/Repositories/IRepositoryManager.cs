using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IRepositoryManager
    {
        IDoctorsRepository doctors { get; }
        IPatientRepository patients { get; }
        IPrescriptionRepository prescriptions { get; }

        void Save();
    }
}
