using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laslo_Antonio_Lab8.Data;
using Laslo_Antonio_Lab8.Models;

namespace Laslo_Antonio_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Laslo_Antonio_Lab8.Data.Laslo_Antonio_Lab8Context _context;

        public IndexModel(Laslo_Antonio_Lab8.Data.Laslo_Antonio_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
