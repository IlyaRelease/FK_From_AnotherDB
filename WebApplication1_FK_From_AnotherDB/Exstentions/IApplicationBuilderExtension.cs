using FKFromAnotherDB.EFCore.Configurator;
using FKFromAnotherDB.EFCore.SCADA;

namespace FKFromAnotherDB.Exstentions
{
    internal static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder SeedDB(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;

            var scadaDB = services.GetRequiredService<ScadaDBContext>();
            var confDB = services.GetRequiredService<ConfDBContext>();

            if (scadaDB.Tags.Any() || scadaDB.BondSignalToTag.Any()
                || confDB.Signals.Any()) return app;

            var sharedInitialData = new List<Guid>();
            for (int i = 0; i < 10; i++) sharedInitialData.Add(Guid.NewGuid());

            ConfDBSeeder.Seed(confDB, sharedInitialData);
            ScadaDBSeeder.Seed(scadaDB, sharedInitialData);

            return app;
        }
    }
}
