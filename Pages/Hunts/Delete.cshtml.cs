using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_Final.Models;

namespace CIDM3312_Final.Pages.Hunts
{
    public class DeleteModel : PageModel
    {
        private readonly CIDM3312_Final.Models.Context _context;

        public DeleteModel(CIDM3312_Final.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Hunt Hunt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hunt = await _context.Hunts.FirstOrDefaultAsync(m => m.HuntID == id);

            if (Hunt == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hunt = await _context.Hunts.FindAsync(id);

            if (Hunt != null)
            {
                _context.Hunts.Remove(Hunt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
