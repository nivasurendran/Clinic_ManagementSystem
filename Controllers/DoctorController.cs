using Microsoft.AspNetCore.Mvc;

namespace Clinic_ManagementSystem.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
