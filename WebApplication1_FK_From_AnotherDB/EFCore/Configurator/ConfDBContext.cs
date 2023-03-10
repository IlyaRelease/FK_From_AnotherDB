using Microsoft.EntityFrameworkCore;
using WebApplication1_FK_From_AnotherDB.EFCore.Configurator.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.Configurator
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
