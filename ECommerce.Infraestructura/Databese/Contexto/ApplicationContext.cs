using ECommerce.Infraestructura.Databese.Entidades.Clientes;
using ECommerce.Infraestructura.Databese.Entidades.Compras;
using ECommerce.Infraestructura.Databese.Entidades.Productos;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infraestructura.Databese.Contexto
{
    public class ApplicationContext : DbContext
    {

        #region DBSets
        public virtual DbSet<ClienteEntities> Clientes { get; set;}
        public virtual DbSet<ProductosEntities> Productos { get; set; }
        public virtual DbSet<StockEntities> Stocks { get; set; }
        public virtual DbSet<ComprasEntities> Compras { get; set; }
        public virtual DbSet<DetalleComprasEntities> DetalleCompras { get; set; }
        #endregion

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
