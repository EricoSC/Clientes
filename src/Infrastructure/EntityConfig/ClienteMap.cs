using Clientes.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.HasKey(c => c.ClienteId);

            builder.HasMany(c => c.Contatos)
                        .WithOne(c => c.Cliente)
                        .HasForeignKey(c => c.ClienteId)
                        .HasPrincipalKey(c => c.ClienteId)
                        .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Endereco).WithOne(c => c.Cliente).HasForeignKey<Endereco>(c => c.ClienteId);

            builder.Property(e => e.Nome)
                        .HasColumnType("varchar(200)")
                        .IsRequired();

            builder.Property(e => e.CPF)
                        .HasColumnType("varchar(11)")
                        .IsRequired();
        }
    }
}
