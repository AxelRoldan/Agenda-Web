using aplicacionDeAxel.Datos;
using aplicacionDeAxel.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aplicacionDeAxel.Pages.Categorias
{
    public class BorrarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }

        public async Task OnGet(int Id)
        {
            Categoria = await _contexto.Categoria.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CategoriaDb = await _contexto.Categoria.FindAsync(Categoria.Id);

                if (CategoriaDb == null)
                {
                    return NotFound();
                }
                _contexto.Categoria.Remove(CategoriaDb);
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

