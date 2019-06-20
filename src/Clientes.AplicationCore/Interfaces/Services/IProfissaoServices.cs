using Clientes.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Interfaces.Services
{
    public interface IProfissaoServices
    {
        Profissao Adicionar(Profissao entity);
        void Atulizar(Profissao entity);
        IEnumerable<Profissao> ObterTodos();
        Profissao ObterPorId(int id);
        IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> predicate);
        void Remover(Profissao entity);
    }
}
