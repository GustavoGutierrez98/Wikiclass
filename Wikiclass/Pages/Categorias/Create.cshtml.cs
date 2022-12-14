using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wikiclass.Data;
using Wikiclass.Models;

namespace Wikiclass.Pages.Categorias
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
            return Page();
        }

        [BindProperty]
        public Categoria Categoria { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.categoria.Add(Categoria);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
