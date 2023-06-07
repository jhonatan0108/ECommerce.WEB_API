using ECommerce.Infraestructura.Databese.Entidades.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infraestructura.Databese.Contexto
{
    public class ApplicationContext : DbContext
    {

        #region DBSets
        public virtual DbSet<ClienteEntities> Clientes { get; set;}

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
