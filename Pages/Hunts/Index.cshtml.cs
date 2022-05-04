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
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Hunts.Select(p => p);

            switch (CurrentSort)
            {
                case "MonsterAsc":
                    query = query.OrderBy(p => p.Monster);
                    break;
                case "MonsterDes":
                    query = query.OrderByDescending(p => p.Monster);
                    break;
            }

            Hunt = await _context.Hunts.ToListAsync();
            Hunt = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
