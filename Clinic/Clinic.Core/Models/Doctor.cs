﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Models
{
    public class Doctor
    {
        public int id { get; set; }
        public string Doctor_name { get; set; }
        public string occupation { get; set; }
        public string phone { get; set; }
        //public int PatientId { get; set; }
        //public Patient patient { get; set; }
        //public Patient Patient { get; set; }
        public Patient Patient { get; set; }
    }
}