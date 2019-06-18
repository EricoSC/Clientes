using Clientes.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes.AplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteId);
    }
}
