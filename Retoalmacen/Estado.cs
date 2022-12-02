using System.ComponentModel.DataAnnotations;

namespace Retoalmacen
{
    public class Estado
    {
        public int Id { get; set; }

        [StringLength(20)]

        public string EstadoOpcion { get; set; } = string.Empty;    
    }
}
