using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.ViewModels
{
    public class HospitalInfoViewModel
    {
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public HospitalInfoViewModel()
        {

        }
        public HospitalInfoViewModel(HospitalInfo model)
        {
            Id = model.Id;
            HospitalName = model.HospitalName;
            Type = model.Type;
            Address = model.Address;
            City = model.City;
            PostalCode = model.PostalCode;
            Country = model.Country;
        }
        public HospitalInfo ConvertViewModel(HospitalInfoViewModel model)
        {
            return new HospitalInfo{
                Id = model.Id,
                HospitalName = model.HospitalName,
                Type = model.Type,
                Address = model.Address,
                City = model.City,
                PostalCode = model.PostalCode,
                Country = model.Country
            };
            
        }

    }
}
