using Clientes.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Interfaces.Services
{
    public interface IClienteServices
    {
        Cliente Adicionar(Cliente entity);
        void Atulizar(Cliente entity);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate);
        void Remover(Cliente entity);
    }
}
