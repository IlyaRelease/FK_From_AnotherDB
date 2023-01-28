using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Configuration
{
    public class BoundSignalToTagEntityConfiguration : IEntityTypeConfiguration<BondSignalToTagEntity>
    {
        public void Configure(EntityTypeBuilder<BondSignalToTagEntity> builder)
        {
            builder
                .ToTable("BondSignalToTag");
            builder
                .HasKey(x => x.Id); 
            builder
                .HasIndex(x => x.TagId);
            builder
                .Property(x => x.Id)
                .IsRequired();
            builder
                .Property(x => x.SignalId)
                .IsRequired();
            builder
                .Property(x => x.TagId)
                .IsRequired();
        }
    }
}
