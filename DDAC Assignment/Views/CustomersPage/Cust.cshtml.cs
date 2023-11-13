using DDAC_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DDAC_Assignment.Views.CustomersPage
{
    public class CustModel : PageModel
    {
        [BindProperty]
        public Customers customers {  get; set; }

        public void OnGet()
        {
        }
    }
}
