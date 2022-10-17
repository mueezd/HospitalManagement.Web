using HospitalManagement.Services;
using HospitalManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HospitalsController : Controller
    {
        
        private IHospitalInfo _hospitalInfo;

        public HospitalsController(IHospitalInfo hospitalInfo)
        {
            _hospitalInfo = hospitalInfo;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_hospitalInfo.GetAll(pageNumber,pageSize));
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var viewModel = _hospitalInfo.GetHospitalById(Id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(HospitalInfoViewModel vm)
        {
            _hospitalInfo.UpdateHospitalInfo(vm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HospitalInfoViewModel vm)
        {
            _hospitalInfo.InsertHospitalInfo(vm);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            _hospitalInfo.DeleteHospitalInfo(Id);
            return RedirectToAction("Index");
        }

    }
}
