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
    public class IndexModel : PageModel
    {
        private readonly GYM.Models.ddacContext _context;

        public IndexModel(GYM.Models.ddacContext context)
        {
            _context = context;
        }

        public IList<RecordCalorie> RecordCalorie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RecordCalorie != null)
            {
                RecordCalorie = await _context.RecordCalorie.ToListAsync();
            }
        }
    }
}
