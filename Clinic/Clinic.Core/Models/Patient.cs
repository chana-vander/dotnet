using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public bool above18 { get; set; }
        public string status { get; set; }
        //יחיד לרבים
        public List<Prescription> prescriptionsList { get; set; }
    }
}
