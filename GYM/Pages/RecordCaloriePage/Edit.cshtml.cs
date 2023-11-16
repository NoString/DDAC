using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GYM.Models;

namespace GYM.Pages.RecordCaloriePage
{
    public class EditModel : PageModel
    {
        private readonly GYM.Models.ddacContext _context;

        public EditModel(GYM.Models.ddacContext context)
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

            var recordcalorie =  await _context.RecordCalorie.FirstOrDefaultAsync(m => m.Id == id);
            if (recordcalorie == null)
            {
                return NotFound();
            }
            RecordCalorie = recordcalorie;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RecordCalorie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordCalorieExists(RecordCalorie.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecordCalorieExists(int id)
        {
          return (_context.RecordCalorie?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
