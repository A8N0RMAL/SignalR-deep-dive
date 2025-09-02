using Microsoft.AspNetCore.Mvc;

namespace SignalREmployees.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Display()
        {
            return View();
        }
    }
}
