using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Infraestructura.Databese.Entidades.Productos
{
    [Table("Producto")]
    public class ProductosEntities
    {
        [Key]
        public int id_producto { get; set; }
        public string descripcion { get; set; } = string.Empty;
        public double valor { get; set; }
        public string? imagen { get; set; } = string.Empty;
        public int id_estado { get; set; }
    }
}
