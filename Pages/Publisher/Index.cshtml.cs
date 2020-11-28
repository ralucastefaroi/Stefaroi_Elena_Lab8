using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stefaroi_Elena_Lab8.Data;
using Stefaroi_Elena_Lab8.Models;

namespace Stefaroi_Elena_Lab8.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Stefaroi_Elena_Lab8.Data.Stefaroi_Elena_Lab8Context _context;

        public IndexModel(Stefaroi_Elena_Lab8.Data.Stefaroi_Elena_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            List<Models.Publisher> lists = await _context.Publisher.ToListAsync();
            Publisher = (IList<Publisher>)lists;
        }
    }
}
