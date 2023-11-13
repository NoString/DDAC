using Microsoft.AspNetCore.Mvc;

namespace DDAC_Assignment.Controllers
{
    public class CustomersPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cust()
        {
            return View();
        }
    }
}
