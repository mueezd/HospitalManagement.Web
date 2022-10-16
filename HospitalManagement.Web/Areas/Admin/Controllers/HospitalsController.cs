using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Web.Areas.Admin.Controllers
{
    public class HospitalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
