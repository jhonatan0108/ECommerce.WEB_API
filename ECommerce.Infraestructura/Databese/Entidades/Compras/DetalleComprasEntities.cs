using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Infraestructura.Databese.Entidades.Compras
{
    [Table("DetalleCompra")]
    public class DetalleComprasEntities
    {
        [Key]
        public int id_detallecompra { get; set; }
        public int cantidad { get; set; }
        public double valorunitario { get; set; }
        public int id_compra { get; set; }
        public int id_producto { get; set; }
    }
}
