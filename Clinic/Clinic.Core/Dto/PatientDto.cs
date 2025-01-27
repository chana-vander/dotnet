using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Dto
{
    public class PatientDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public bool above18 { get; set; }
        public string status { get; set; }
    }
}
