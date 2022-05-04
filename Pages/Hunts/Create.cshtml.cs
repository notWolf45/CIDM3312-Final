using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM3312_Final.Models;

namespace CIDM3312_Final.Pages.Hunts
{
    public class CreateModel : PageModel
    {
        private readonly CIDM3312_Final.Models.Context _context;

        public CreateModel(CIDM3312_Final.Models.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hunt Hunt { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            foreach (var h in _context.Hunters.ToList()){
                if(h.Name == Hunt.H1Name){
                    h.TDmg += Hunt.H1Dmg;
                } else if(h.Name == Hunt.H2Name){
                    h.TDmg += Hunt.H2Dmg;
                } else if(h.Name == Hunt.H3Name){
                    h.TDmg += Hunt.H3Dmg;
                } else if(h.Name == Hunt.H4Name){
                    h.TDmg += Hunt.H4Dmg;
                }
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hunts.Add(Hunt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
