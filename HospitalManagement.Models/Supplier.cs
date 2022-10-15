using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public ICollection<MedicineReport> MedicineReports { get; set; }
    }
}
