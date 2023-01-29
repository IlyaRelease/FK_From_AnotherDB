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
        public DbSet<BondSignalToTagEntity> BondSignalToTag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BondSignalToTagEntity>()
                // One tag can be used only with one signal
                .HasKey(x => x.TagId);

            modelBuilder.Entity<TagEntity>()
                .HasOne(t => t.BondSignalToTagEntity)
                .WithOne(b => b.TagEntity)
                .HasForeignKey<BondSignalToTagEntity>(b => b.TagId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(true);
        }
    }
}