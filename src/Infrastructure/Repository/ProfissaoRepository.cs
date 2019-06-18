using Clientes.AplicationCore.Entity;
using Clientes.AplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Data;
using System.Linq;

namespace Clientes.Infrastructure.Repository
{
    public class ProfissaoRepository : EFRepository<Profissao>, IProfissaoRepository
    {
        public ProfissaoRepository (ClientesContext context) :base (context)
        {

        }
    }
}
