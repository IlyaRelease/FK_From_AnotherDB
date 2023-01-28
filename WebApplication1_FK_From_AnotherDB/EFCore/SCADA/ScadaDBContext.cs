using Microsoft.EntityFrameworkCore;
using WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models;

namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA
{
    public class ScadaDBContext : DbContext
    {
        public ScadaDBContext(DbContextOptions<ScadaDBContext> options)
        : base(options)
            {
            }

        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<BondSignalToTagEntity> BountSignalToTag { get; set; }
    }
}
