using Clientes.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class ClientesContext : DbContext
    {

        public ClientesContext(DbContextOptions<ClientesContext> options) : base (options)
        {

        }

        DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
