using LoginAPI.Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Application.Services
{
    public class ClienteService : IClienteAppService
    {
        private readonly IClienteRepository repository;

        public ClienteService(IClienteRepository _repository)
        {
            this.repository = _repository;
        }

        public Cliente RegistrarCliente(Cliente cliente)
        {
            repository.InserirCliente(cliente);

            return cliente;
        }
    }
}
