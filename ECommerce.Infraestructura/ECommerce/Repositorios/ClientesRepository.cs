using ECommerce.Infraestructura.Databese.Contexto;
using ECommerce.Infraestructura.Databese.Entidades.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infraestructura.ECommerce.Repositorios
{
    public class ClientesRepository : ICrudRepository<ClienteEntities>
    {
        private readonly ApplicationContext _context;

        public ClientesRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<ClienteEntities> Create(ClienteEntities entity)
        {
            _context.Clientes.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteById(int id)
        {
            _context.Remove(id);
            return await _context.SaveChangesAsync() > 0 ? true : false;
        }

        public async Task<List<ClienteEntities>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<ClienteEntities> GetById(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<ClienteEntities> Update(ClienteEntities entity)
        {
            _context.Clientes.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

    }
}
