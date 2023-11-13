using Microsoft.AspNetCore.Mvc;

namespace DDAC_Assignment.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustCreate()
        {
            return View();
        }
    }
}
