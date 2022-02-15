using aplicacionDeAxel.Datos;
using aplicacionDeAxel.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace aplicacionDeAxel.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Categoria> Categorias { get; set; }

        public async Task OnGet()
        {
            Categorias = await _contexto.Categoria.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            else
            {
                return Page();
            }
        }
    }
}
