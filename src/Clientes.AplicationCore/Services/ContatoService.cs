using Clientes.AplicationCore.Entity;
using Clientes.AplicationCore.Interfaces.Repository;
using Clientes.AplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Services
{
    public class ContatoService : IContatoServices
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public Contato Adicionar(Contato entity)
        {
            return _contatoRepository.Adicionar(entity);
        }

        public void Atulizar(Contato entity)
        {
            _contatoRepository.Atulizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicate)
        {
            return _contatoRepository.Buscar(predicate);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepository.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoRepository.Remover(entity);
        }
    }
}
