using FKFromAnotherDB.EFCore.SCADA.Models;

namespace FKFromAnotherDB.EFCore.SCADA
{
    public class ScadaDBSeeder
    {
        internal static void Seed(ScadaDBContext dbContext, IEnumerable<Guid> links)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();

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
