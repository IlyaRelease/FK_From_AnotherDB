using WebApplication1_FK_From_AnotherDB.EFCore.Configurator;
using WebApplication1_FK_From_AnotherDB.EFCore.Configurator.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.Seeders
{
    public class ConfDBInitializer
    {
        internal static void Initialize(ConfDBContext dbContext, IEnumerable<Guid> links)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Signals.Any()) return;
            
            var rand = new Random();

            foreach (var link in links)
                dbContext.Signals.Add(new SignalEntity() { Id = link, Property = "some options" });

            dbContext.SaveChanges();
        }
    }
}
