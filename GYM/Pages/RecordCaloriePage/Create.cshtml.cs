using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GYM.Models;

namespace GYM.Pages.RecordCaloriePage
{
    public class CreateModel : PageModel
    {
        private readonly GYM.Models.ddacContext _context;

        public CreateModel(GYM.Models.ddacContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RecordCalorie RecordCalorie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.RecordCalorie == null || RecordCalorie == null)
            {
                return Page();
            }

            _context.RecordCalorie.Add(RecordCalorie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
