using aplicacionDeAxel.Datos;
using aplicacionDeAxel.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aplicacionDeAxel.Pages.Categorias
{
    public class DetalleModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public DetalleModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }

        public async Task OnGet(int Id)
        {
            Categoria = await _contexto.Categoria.FindAsync(Id);
        }
    }
}
