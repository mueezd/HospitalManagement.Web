using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.ViewModels
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int HospitalId { get; set; }

        public RoomViewModel()
        {

        }
        public RoomViewModel(Room Model)
        {
            Id = Model.Id;
            RoomNumber = Model.RoomNumber;
            Type = Model.Type;
            Status = Model.Status;
            HospitalId = Model.HospitalId;
        }   

        public Room ConvertViewModel(RoomViewModel model)
        {
            return new Room
            {
                Id = model.Id,
                RoomNumber = model.RoomNumber,
                Type = model.Type,
                Status = model.Status,
                HospitalId = model.HospitalId
            };
        }
    }
}
