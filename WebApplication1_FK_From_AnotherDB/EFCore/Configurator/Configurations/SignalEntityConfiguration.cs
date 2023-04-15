using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FKFromAnotherDB.EFCore.Configurator.Models;

namespace FKFromAnotherDB.EFCore.Configurator.Configurations
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
            builder
                .HasOne(x => x.Device)
                .WithMany(s => s.Signals)
                .HasForeignKey(s => s.DeviceId);
        }
    }
}