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

      /*  public Patient(int id_tz, string name, string phone, bool above18, string status)
        {
            this.id_tz = id_tz;
            this.name = name;
            this.phone = phone;
            this.above18 = above18;
            this.status = status;
        }*/
    }
}
