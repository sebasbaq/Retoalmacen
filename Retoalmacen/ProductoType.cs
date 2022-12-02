using System.ComponentModel.DataAnnotations;

namespace Retoalmacen
{
    public class ProductoType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; } = string.Empty;
    }
}
