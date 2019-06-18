using Clientes.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {

            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Cliente)
                .WithMany(c => c.ProfissoesClientes)
                .HasForeignKey(c => c.ClienteId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Profissao)
               .WithMany(c => c.ProfissoesClientes)
               .HasForeignKey(c => c.ProfissaoId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
