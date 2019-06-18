using Clientes.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {

            builder.Property(e => e.Bairro)
            .HasColumnType("varchar(200)")
            .IsRequired();
            builder.Property(e => e.CEP)
            .HasColumnType("int")
            .IsRequired();
            builder.Property(e => e.Logradouro)
            .HasColumnType("varchar(200)")
            .IsRequired();
            builder.Property(e => e.Referencia)
            .HasColumnType("varchar(400)");
            
        }
    }
}
