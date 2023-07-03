using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMe.Data.Mappings
{
    internal class ClienteLeveMvMap : IEntityTypeConfiguration<ClienteLeveMv>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClienteLeveMv> builder)
        {
            builder.ToTable("ClienteleveMv");

            builder.HasKey(cm => new { cm.ClienteId, cm.LeveMvId });
        }
    }
}
