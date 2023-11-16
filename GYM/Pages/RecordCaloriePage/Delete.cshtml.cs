using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GYM.Models;

namespace GYM.Pages.RecordCaloriePage
{
    public class DeleteModel : PageModel
    {
        private readonly GYM.Models.ddacContext _context;

        public DeleteModel(GYM.Models.ddacContext context)
        {
            _context = context;
        }

        [BindProperty]
      public RecordCalorie RecordCalorie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RecordCalorie == null)
            {
                return NotFound();
            }

            var recordcalorie = await _context.RecordCalorie.FirstOrDefaultAsync(m => m.Id == id);

            if (recordcalorie == null)
            {
                return NotFound();
            }
            else 
            {
                RecordCalorie = recordcalorie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.RecordCalorie == null)
            {
                return NotFound();
            }
            var recordcalorie = await _context.RecordCalorie.FindAsync(id);

            if (recordcalorie != null)
            {
                RecordCalorie = recordcalorie;
                _context.RecordCalorie.Remove(RecordCalorie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
