using Clientes.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class ClientesContext : DbContext
    {

        public ClientesContext(DbContextOptions<ClientesContext> options)
            : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            #region Config Clientes
            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                        .HasColumnType("varchar(200)")
                        .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                        .HasColumnType("varchar(11)")
                        .IsRequired();

            #endregion
            #region Config Contatos
            modelBuilder.Entity<Contato>().Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
           .HasColumnType("varchar(100)")
           .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
           .HasColumnType("varchar(15)");

            #endregion
        }
    }
}
