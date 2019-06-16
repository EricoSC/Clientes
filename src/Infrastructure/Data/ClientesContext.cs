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
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }
        public DbSet<ProfissaoCliente> ProfissoesClientes{ get; set; }
        public DbSet<Menu> Menus { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");
            modelBuilder.Entity<Menu>().ToTable("Menu");

            #region Config Clientes
            modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
                        .HasMany(c => c.Contatos)
                        .WithOne(c => c.Cliente)
                        .HasForeignKey(c => c.ClienteId)
                        .HasPrincipalKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                        .HasColumnType("varchar(200)")
                        .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                        .HasColumnType("varchar(11)")
                        .IsRequired();

            #endregion
            #region Config Contatos

            modelBuilder.Entity<Contato>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
           .HasColumnType("varchar(100)")
           .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
           .HasColumnType("varchar(15)");

            #endregion
            #region Config Profissao
            modelBuilder.Entity<Profissao>().Property(e => e.Nome)
                        .HasColumnType("varchar(400)")
                        .IsRequired();
            modelBuilder.Entity<Profissao>().Property(e => e.CBO)
            .HasColumnType("varchar(10)")
            .IsRequired();
            modelBuilder.Entity<Profissao>().Property(e => e.Descricao)
            .HasColumnType("varchar(1000)")
            .IsRequired();
            #endregion
            #region Config Endereco
            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
            .HasColumnType("varchar(200)")
            .IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
            .HasColumnType("int")
            .IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
            .HasColumnType("varchar(200)")
            .IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.Referencia)
            .HasColumnType("varchar(400)");
            #endregion
            #region Config Profissoes Clientes
            modelBuilder.Entity<ProfissaoCliente>().HasKey(c => c.Id);

            modelBuilder.Entity<ProfissaoCliente>().HasOne(c => c.Cliente)
                .WithMany(c => c.ProfissoesClientes)
                .HasForeignKey(c => c.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>().HasOne(c => c.Profissao)
               .WithMany(c => c.ProfissoesClientes)
               .HasForeignKey(c => c.ProfissaoId);
            #endregion
            #region Config Menu

            modelBuilder.Entity<Menu>().Property(c => c.Titulo)
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Menu>().HasMany(c => c.SubMenu)
                .WithOne()
                .HasForeignKey(c => c.MenuId);

            #endregion

        }
    }
}
