using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeveMv.Data.Mappings
{
    public class LeMeMap : IEntityTypeConfiguration<Leveme>
    {
        public void Configure(EntityTypeBuilder<Leveme> builder)
        {
            builder.ToTable("LeveMe");

            builder.HasKey( p => p.ID);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
