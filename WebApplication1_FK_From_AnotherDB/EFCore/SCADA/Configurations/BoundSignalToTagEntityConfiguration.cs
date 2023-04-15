using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FKFromAnotherDB.EFCore.SCADA.Models;

namespace FKFromAnotherDB.EFCore.SCADA.Configurations
{
    public class BoundSignalToTagEntityConfiguration : IEntityTypeConfiguration<BondSignalToTagEntity>
    {
        public void Configure(EntityTypeBuilder<BondSignalToTagEntity> builder)
        {
            builder
                .ToTable("BondSignalToTag");
            builder
                .Property(x => x.TagId)
                .IsRequired();
            builder
                .HasIndex(x => x.SignalId);
            builder
                .Property(x => x.SignalId)
                .IsRequired();
        }
    }
}
