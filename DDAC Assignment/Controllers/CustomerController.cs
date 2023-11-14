using Microsoft.AspNetCore.Mvc;

namespace DDAC_Assignment.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CalculateMealCalories()
        {
            return View();
        }
    }
}
