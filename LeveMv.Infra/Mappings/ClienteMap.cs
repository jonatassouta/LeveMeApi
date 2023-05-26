using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            builder.Property(p => p.Endereço)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Telefone)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(p => p.UF)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.Property(p => p.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(p => p.LeveMv)
                .WithMany()
                .HasForeignKey(p => p.LeveMvID);
        }
    }
}
