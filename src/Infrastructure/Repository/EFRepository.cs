using Clientes.AplicationCore.Interfaces.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ClientesContext _context;
        private ClienteRepository context;

        public EFRepository(ClientesContext context)
        {
            _context = context;
        }

        public virtual TEntity Adicionar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual void Atulizar(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsEnumerable();
            
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
