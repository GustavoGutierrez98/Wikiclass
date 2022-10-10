using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wikiclass.Data;
using Wikiclass.Models;

namespace Wikiclass.Pages.Posts
{
    public class DetailsModel : PageModel
    {
        private readonly Wikiclass.Data.ApplicationDbContext _context;

        public DetailsModel(Wikiclass.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Post Post { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            else 
            {
                Post = post;
            }
            return Page();
        }
    }
}
