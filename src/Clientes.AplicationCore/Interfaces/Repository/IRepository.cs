using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atulizar(TEntity entity);
        IEnumerable <TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        void Remover(TEntity entity);

    }
}
