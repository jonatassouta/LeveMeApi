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
        public DbSet<Levemv> LeveMvs { get; set; }
        public DbSet<ClienteLeveMv> ClientesLMvs { get; set; }

        protected void InitializeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ID = new Guid("6714d050-cbad-4951-b819-3641e4647f1c") , Nome = "Jonatas", CNPJ = 11122233345678, Telefone = "16999998888", Endereco = "Av. Teste", Bairro = "Vila Xavier", Cidade = "Araraquara", UF = "SP", DataCadastro = DateTime.Parse("16/05/2025"), Ativo = true });

            modelBuilder.Entity<Levemv>().HasData(
                new Levemv { ID = new Guid("fa974954-c32d-4e62-9154-c77d14445525"), Nome = "Leve Me Tipo 1"});

            modelBuilder.Entity<ClienteLeveMv>().HasData(
                new ClienteLeveMv {LeveMvId = new Guid("fa974954-c32d-4e62-9154-c77d14445525"), ClienteId = new Guid("6714d050-cbad-4951-b819-3641e4647f1c")});

            modelBuilder.Entity<Produto>().HasData(
                new Produto { ID = new Guid("afc849df-735d-48ec-8e20-61aa2e434cff"), Nome = "Cabo Tipo C", Preco = 22.5M, ClienteId = new Guid("6714d050-cbad-4951-b819-3641e4647f1c")});
        }
    }
}