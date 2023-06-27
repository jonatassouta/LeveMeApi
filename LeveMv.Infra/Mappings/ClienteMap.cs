using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeveMv.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(p => p.ID);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.CNPJ)
                .HasColumnType("numeric(14,0)")
                .IsRequired();

            builder.Property(p => p.Endereço)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Bairro)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(p => p.Telefone)
                .HasColumnType("varchar(12)")
                .IsRequired();

            builder.Property(p => p.UF)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("varchar(40)");          

            builder.Property(p => p.Ativo)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(p => p.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
