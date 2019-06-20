using Clientes.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Interfaces.Services
{
    public interface IContatoServices
    {
        Contato Adicionar(Contato entity);
        void Atulizar(Contato entity);
        IEnumerable<Contato> ObterTodos();
        Contato ObterPorId(int id);
        IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicate);
        void Remover(Contato entity);
    }
}
