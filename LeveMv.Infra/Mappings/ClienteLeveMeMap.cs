using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMe.Data.Mappings
{
    internal class ClienteLeveMeMap : IEntityTypeConfiguration<ClienteLeveMe>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClienteLeveMe> builder)
        {
            builder.ToTable("ClientesleveMe");

            builder.HasKey(cm => new { cm.ClienteId, cm.LeveMeId });
        }
    }
}
