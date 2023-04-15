using WebApplication1_FK_From_AnotherDB.EFCore.Configurator.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.Configurator
{
    public class ConfDBSeeder
    {
        internal static void Seed(ConfDBContext dbContext, IEnumerable<Guid> links)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Signals.Any()) return;

            var rand = new Random();

            int deviceId = rand.Next();
            dbContext.Devices.Add(new DeviceEntity() { Id = deviceId, Name = "SimpleController", Protocol = "Native" });

            foreach (var link in links)
                dbContext.Signals.Add(new SignalEntity() { Id = link, DeviceId = deviceId, Property = "some options" });

            dbContext.SaveChanges();
        }
    }
}
