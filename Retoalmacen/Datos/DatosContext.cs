using Microsoft.EntityFrameworkCore;

namespace Retoalmacen.Datos
{
    public class DatosContext : DbContext
    {
       public DatosContext(DbContextOptions<DatosContext> options) : base (options) { }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<ProductoType> ProductoTypes { get; set; }

        public DbSet<Estado> Estado { get; set; }   
    }
}
