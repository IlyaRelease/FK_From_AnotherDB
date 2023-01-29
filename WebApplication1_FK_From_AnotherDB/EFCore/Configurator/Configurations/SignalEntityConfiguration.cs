using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1_FK_From_AnotherDB.EFCore.Configurator.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.Configurator.Configurations
{
    public class SignalEntityConfiguration : IEntityTypeConfiguration<SignalEntity>
    {
        public void Configure(EntityTypeBuilder<SignalEntity> builder)
        {
            builder
                .ToTable("Signals");
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