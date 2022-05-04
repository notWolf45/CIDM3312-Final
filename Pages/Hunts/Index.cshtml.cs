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
    public class IndexModel : PageModel
    {
        private readonly CIDM3312_Final.Models.Context _context;

        public IndexModel(CIDM3312_Final.Models.Context context)
        {
            _context = context;
        }

        public IList<Hunt> Hunt { get;set; }

        public async Task OnGetAsync()
        {
            Hunt = await _context.Hunts.ToListAsync();
        }
    }
}
