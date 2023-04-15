using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FKFromAnotherDB.EFCore.SCADA.Models;

namespace FKFromAnotherDB.EFCore.SCADA.Configurations
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<TagEntity>
    {
        public void Configure(EntityTypeBuilder<TagEntity> builder)
        {
            builder
                .ToTable("Tags");
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .IsRequired();
            builder
                .Property(x => x.Property)
                .IsRequired();
        }
    }
}