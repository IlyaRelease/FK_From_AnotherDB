using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Configurations
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