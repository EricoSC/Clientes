using Clientes.AplicationCore.Entity;
using Infrastructure.Data;
using System.Linq;

namespace Clientes.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initializer(ClientesContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano",
                    CPF ="42647865841"
                },
                new Cliente
                {
                    Nome = "Ciclano",
                    CPF ="11111111111"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome ="Contato 1",
                    Telefone ="992868254",
                    Email="ericoscamargo@gmail.com",
                    Cliente = clientes[0]
                },
                 new Contato
                {
                    Nome ="Contato 2",
                    Telefone ="26390921",
                    Email="ericotuning@hotmail.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
