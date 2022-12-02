using System.ComponentModel.DataAnnotations;

namespace Retoalmacen
{
    public class Producto
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Estatus{ get; set; }= string.Empty;

        [StringLength(200)]

        public string Comentarios { get; set; } = string.Empty;

        public int ProductoTypeId { get; set; }

        public ProductoType?  ProductoType { get; set; }
    }
}
