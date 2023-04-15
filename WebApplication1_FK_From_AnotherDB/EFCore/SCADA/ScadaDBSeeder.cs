using WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA
{
    public class ScadaDBSeeder
    {
        internal static void Seed(ScadaDBContext dbContext, IEnumerable<Guid> links)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Tags.Any() || dbContext.BondSignalToTag.Any()) return;

            var rand = new Random();
            foreach (var link in links)
            {
                var tagUuid = Guid.NewGuid();

                dbContext.Tags.Add(new TagEntity() { Id = tagUuid, Property = "some options" });

                dbContext.BondSignalToTag.Add(new BondSignalToTagEntity()
                {
                    SignalId = link,
                    TagId = tagUuid
                });
            }

            dbContext.SaveChanges();
        }
    }
}
