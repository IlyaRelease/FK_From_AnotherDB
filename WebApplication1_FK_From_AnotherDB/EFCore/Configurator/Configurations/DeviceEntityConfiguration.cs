using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FKFromAnotherDB.EFCore.Configurator.Models;

namespace FKFromAnotherDB.EFCore.Configurator.Configurations
{
    public class DeviceEntityConfiguration : IEntityTypeConfiguration<DeviceEntity>
    {
        public void Configure(EntityTypeBuilder<DeviceEntity> builder)
        {
            builder
                .ToTable("Devices");
            builder
                .HasKey(d => d.Id);
            builder
                .Property(d => d.Name)
                .IsRequired();
            builder
                .Property(d => d.Protocol)
                .IsRequired();

            builder
                .HasIndex(d => d.Name);
        }
    }
}
