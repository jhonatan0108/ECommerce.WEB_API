using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Infraestructura.Databese.Entidades.Productos
{
    [Table("Stock")]
    public class StockEntities
    {
        [Key]
        public int id_stock { get; set; }
        public int cantidad { get; set; }
        public int id_producto { get; set; }
    }
}
