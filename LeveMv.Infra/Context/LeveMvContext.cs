using LeveMv.Data.Mappings;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LeveMv.Data.Context
{
    public class LeveMvContext : DbContext
    {
        public LeveMvContext(DbContextOptions<LeveMvContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdutoMap).Assembly);

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-VC8DKBE\\SQLEXPRESS;Database=LeveMvDB;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;");
        //}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<LeveMe> LeveMvs { get; set; }
    }
}