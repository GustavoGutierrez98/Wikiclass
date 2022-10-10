using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wikiclass.Data;
using Wikiclass.Models;

namespace Wikiclass.Pages.Categorias
{
    public class DetailsModel : PageModel
    {
        private readonly Wikiclass.Data.ApplicationDbContext _context;

        public DetailsModel(Wikiclass.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Categoria Categoria { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.categoria == null)
            {
                return NotFound();
            }

            var categoria = await _context.categoria.FirstOrDefaultAsync(m => m.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            else 
            {
                Categoria = categoria;
            }
            return Page();
        }
    }
}
