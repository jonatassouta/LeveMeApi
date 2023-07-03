using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeveMv.Data.Mappings
{
    public class LeMvMap : IEntityTypeConfiguration<Domain.Models.Levemv>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Levemv> builder)
        {
            builder.ToTable("LeveMv");

            builder.HasKey( p => p.ID);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
