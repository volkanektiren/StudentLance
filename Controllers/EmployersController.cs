using Microsoft.AspNetCore.Mvc;

namespace StudentLance.Controllers
{
    public class EmployersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
