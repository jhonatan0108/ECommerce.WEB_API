using ECommerce.Infraestructura.Databese.Entidades.Clientes;
using ECommerce.Infraestructura.ECommerce.Repositorios;

namespace ECommerce.Dominio.Services.ECommerce.Clientes
{
    public class ClientesService
    {
        private readonly ICrudRepository<ClienteEntities> _crudRepository;

        public ClientesService(ICrudRepository<ClienteEntities> crudRepository)
        {
            _crudRepository = crudRepository;
        }
    }
}
