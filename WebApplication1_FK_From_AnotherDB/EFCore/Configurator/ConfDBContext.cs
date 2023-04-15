using Microsoft.EntityFrameworkCore;
using FKFromAnotherDB.EFCore.Configurator.Models;

namespace FKFromAnotherDB.EFCore.Configurator
{
    public class ConfDBContext : DbContext
    {
        public ConfDBContext(DbContextOptions<ConfDBContext> options)
        : base(options)
        {
        }

        public DbSet<SignalEntity> Signals { get; set; }
        public DbSet<DeviceEntity> Devices { get; set; }
    }
}
