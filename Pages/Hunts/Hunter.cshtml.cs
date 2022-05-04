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
    public class HunterModel : PageModel
    {
        private readonly CIDM3312_Final.Models.Context _context;

        public HunterModel(CIDM3312_Final.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public string HunterName {get; set;}
        public Hunter Hunter {get; set;}

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (HunterName == null)
            {
                return NotFound();
            }
            Hunter = _context.Hunters.Where(h => h.Name.ToLower() == HunterName.ToLower()).FirstOrDefault();
            //return RedirectToPage("./Index");
            return Page();
        }
    }
}