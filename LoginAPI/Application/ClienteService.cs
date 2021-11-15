using LoginAPI.Application.Interfaces;
using LoginAPI.Data;
using LoginAPI.Models.Entities;

namespace LoginAPI.Application
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteContext _context;

        public ClienteService(ClienteContext context)
        {
            _context = context;
        }

        public void CriarCriente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);

            _context.SaveChangesAsync();
        }
    }
}
