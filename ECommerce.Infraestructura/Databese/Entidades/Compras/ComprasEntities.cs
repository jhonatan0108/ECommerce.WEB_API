using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Infraestructura.Databese.Entidades.Compras
{
    [Table("Compra")]
    public class ComprasEntities
    {
        [Key]
        public int id_compra { get; set; }
        public DateTime fecha { get; set; }
        public double valortotal { get; set; }
        public string direccionentrega { get; set; } = string.Empty;
        public int id_cliente { get; set; }
        public int id_estado { get; set; }
    }
}
