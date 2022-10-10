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
    public class DeleteModel : PageModel
    {
        private readonly Wikiclass.Data.ApplicationDbContext _context;

        public DeleteModel(Wikiclass.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Tag Tag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.tags == null)
            {
                return NotFound();
            }

            var tag = await _context.tags.FirstOrDefaultAsync(m => m.Id == id);

            if (tag == null)
            {
                return NotFound();
            }
            else 
            {
                Tag = tag;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.tags == null)
            {
                return NotFound();
            }
            var tag = await _context.tags.FindAsync(id);

            if (tag != null)
            {
                Tag = tag;
                _context.tags.Remove(Tag);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
