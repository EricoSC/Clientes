using Clientes.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(c => c.Titulo)
                .HasColumnType("varchar(200)");
            builder.HasMany(c => c.SubMenu)
                .WithOne()
                .HasForeignKey(c => c.MenuId);
        }
    }
}
