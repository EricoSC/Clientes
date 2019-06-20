using Clientes.AplicationCore.Entity;
using Clientes.AplicationCore.Interfaces.Repository;
using Clientes.AplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Services
{
    public class ClienteService : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Cliente Adicionar(Cliente entity)
        {
            //TODO: Adicionar regra de negocio
            return _clienteRepository.Adicionar(entity);
        }

        public void Atulizar(Cliente entity)
        {
            _clienteRepository.Atulizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate)
        {
            return _clienteRepository.Buscar(predicate);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}
