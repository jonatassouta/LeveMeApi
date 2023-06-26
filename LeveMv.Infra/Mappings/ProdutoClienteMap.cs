using LeveMe.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMe.Data.Mappings
{
    internal class ProdutoClienteMap : IEntityTypeConfiguration<ProdutoCliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProdutoCliente> builder)
        {
            builder.ToTable("ProdutoCliente");

            builder.HasKey(cm => new { cm.ClienteId, cm.ProdutoId });
        }
    }
}
