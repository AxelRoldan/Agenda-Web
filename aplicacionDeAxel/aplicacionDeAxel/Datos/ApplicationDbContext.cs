using aplicacionDeAxel.Modelos;
using Microsoft.EntityFrameworkCore;

namespace aplicacionDeAxel.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
