using HospitalManagement.Models;
using HospitalManagement.Repositories.Interfaces;
using HospitalManagement.Utilities;
using HospitalManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Services
{
    public class HospitalInfoService : IHospitalInfo
    {
        private IUnitOfWork _unitOfWork;

        public HospitalInfoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteHospitalInfo(int id)
        {
            var model = _unitOfWork.GenericRepository<HospitalInfo>().GetById(id);
            _unitOfWork.GenericRepository<HospitalInfo>().Delete(model);
            _unitOfWork.Save();
        }

        public PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize)
        {
            var vm = new HospitalInfoViewModel();
            int totalCount;
            List<HospitalInfoViewModel> vmList = new List<HospitalInfoViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;

                var modelList = _unitOfWork.GenericRepository<HospitalInfo>().GetAll().
                    Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<HospitalInfo>().GetAll().ToList().Count;

                vmList = ConvertModelToViewModelList(modelList);
            }
            catch (Exception)
            {

                throw;
            }
            var result = new PagedResult<HospitalInfoViewModel>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;

            var HospitalInfoViewModel = new HospitalInfoViewModel();
        }

        public HospitalInfoViewModel GetHospitalById(int HospitalId)
        {
            var model = _unitOfWork.GenericRepository<HospitalInfo>().GetById(HospitalId);
            var vm = new HospitalInfoViewModel(model);
            return vm;
        }

        public void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo)
        {
            var model = new HospitalInfoViewModel().ConvertViewModel(hospitalInfo);
            _unitOfWork.GenericRepository<HospitalInfo>().Add(model);
            _unitOfWork.Save();
        }

        public void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo)
        {
            var model = new HospitalInfoViewModel().ConvertViewModel(hospitalInfo);
            var modelById = _unitOfWork.GenericRepository<HospitalInfo>().GetById(model.Id);
            modelById.HospitalName = hospitalInfo.HospitalName;
            modelById.City = hospitalInfo.City;
            modelById.PostalCode = hospitalInfo.PostalCode;
            modelById.Country = hospitalInfo.Country;
            modelById.Address = hospitalInfo.Address;
           
            _unitOfWork.GenericRepository<HospitalInfo>().Update(modelById);
            _unitOfWork.Save();
        }

        private List<HospitalInfoViewModel> ConvertModelToViewModelList(List<HospitalInfo> modelList)
        {
            return modelList.Select(x => new HospitalInfoViewModel(x)).ToList();
        }
    }
}
