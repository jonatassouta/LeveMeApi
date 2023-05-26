﻿using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeveMv.Data.Mappings
{
    public class LeMvMap : IEntityTypeConfiguration<LeMv>
    {
        public void Configure(EntityTypeBuilder<LeMv> builder)
        {
            builder.ToTable("LeveMvs");

            builder.HasKey( p => p.ID);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
