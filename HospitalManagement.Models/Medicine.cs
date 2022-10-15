﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class Medicine
    {
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public ICollection<MedicineReport> MedicineReports { get; set; }
        public ICollection<PrescribedMedicine> PrescribedMedicines { get; set; }

    }
}
