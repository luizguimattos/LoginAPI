using LoginAPI.Data.Contexts;
using LoginAPI.Domain.Clientes;

namespace LoginAPI.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext context;

        public ClienteRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public void InserirCliente(Cliente cliente)
        {
            context.Add(cliente);
            context.SaveChangesAsync();
        }
    }
}
