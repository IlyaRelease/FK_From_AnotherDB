using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Configurations
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
