using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wikiclass.Data;
using Wikiclass.Models;

namespace Wikiclass.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly Wikiclass.Data.ApplicationDbContext _context;

        public CreateModel(Wikiclass.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["categoriaId"] = new SelectList(_context.categoria, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
