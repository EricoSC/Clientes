using Clientes.AplicationCore.Entity;
using Clientes.AplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Data;
using System.Linq;

namespace Clientes.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository (ClientesContext context) :base (context)
        {

        }
        public Cliente ObterPorProfissao(int clienteId)
        {
            return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clienteId))
            .FirstOrDefault();
        }
    }
}
