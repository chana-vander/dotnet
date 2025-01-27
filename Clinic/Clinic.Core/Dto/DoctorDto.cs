using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Dto
{
    public class DoctorDto
    {
        public int id { get; set; }
        public string Doctor_name { get; set; }
        public string occupation { get; set; }
        public string phone { get; set; }
    }
}
