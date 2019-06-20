using Clientes.AplicationCore.Entity;
using Clientes.AplicationCore.Interfaces.Repository;
using Clientes.AplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clientes.AplicationCore.Services
{
    public class ProfissaoService :  IProfissaoServices
    {
        private readonly IProfissaoRepository _profissaoRepository;

        public ProfissaoService(IProfissaoRepository profissaoRepository)
        {
            _profissaoRepository = profissaoRepository;
        }
        public Profissao Adicionar(Profissao entity)
        {
            return _profissaoRepository.Adicionar(entity);
        }

        public void Atulizar(Profissao entity)
        {
            _profissaoRepository.Atulizar(entity);
        }

        public IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> predicate)
        {
            return _profissaoRepository.Buscar(predicate);
        }

        public Profissao ObterPorId(int id)
        {
            return _profissaoRepository.ObterPorId(id);
        }

        public IEnumerable<Profissao> ObterTodos()
        {
            return _profissaoRepository.ObterTodos();
        }

        public void Remover(Profissao entity)
        {
            _profissaoRepository.Remover(entity);
        }
    }
}
