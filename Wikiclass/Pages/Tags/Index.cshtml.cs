using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wikiclass.Data;
using Wikiclass.Models;

namespace Wikiclass.Pages.Tags
{
    public class IndexModel : PageModel
    {
        private readonly Wikiclass.Data.ApplicationDbContext _context;

        public IndexModel(Wikiclass.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Tag> Tag { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.tags != null)
            {
                Tag = await _context.tags.ToListAsync();
            }
        }
    }
}
