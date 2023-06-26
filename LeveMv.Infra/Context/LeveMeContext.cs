using LeveMv.Data.Mappings;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMv.Data.Context
{
    public class LeveMeContext : DbContext
    {
        public LeveMeContext(DbContextOptions<LeveMeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdutoMap).Assembly);
            InitializeData(modelBuilder);

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-VC8DKBE\\SQLEXPRESS;Database=LeveMvDB;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;");
        //}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Leveme> LeveMes { get; set; }
        public DbSet<ClienteLeveMe> ClientesLMEs { get; set; }

        protected void InitializeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ID = new Guid("6714d050-cbad-4951-b819-3641e4647f1c") , Nome = "Jonatas", Telefone = "16999998888", Endereço = "Av. Teste", Cidade = "Araraquaa", UF = "SP", DataCadastro = DateTime.Parse("16/05/2025"), Ativo = true });

            modelBuilder.Entity<Leveme>().HasData(
                new Leveme { ID = new Guid("fa974954-c32d-4e62-9154-c77d14445525"), Nome = "Leve Me Tipo 1"});

            modelBuilder.Entity<ClienteLeveMe>().HasData(
                new ClienteLeveMe { ClienteId = new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), LeveMeId = new Guid("fa974954-c32d-4e62-9154-c77d14445525")});
        }
    }
}