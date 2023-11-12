using Microsoft.AspNetCore.Mvc;

namespace DDAC_Assignment.Controllers
{
    public class Customer : Controller
    {
        public IActionResult CalculateMealCalories()
        {
            return View();
        }
    }
}
