using WebApplication1_FK_From_AnotherDB.EFCore.Configurator;
using WebApplication1_FK_From_AnotherDB.EFCore.SCADA;

namespace WebApplication1_FK_From_AnotherDB.Exstentions
{
    internal static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder SeedDB(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;

            var signalsGuids = new List<Guid>();
            for (int i = 0; i < 10; i++) signalsGuids.Add(Guid.NewGuid());

            var confContext = services.GetRequiredService<ConfDBContext>();
            ConfDBSeeder.Seed(confContext, signalsGuids);

            var scadaContext = services.GetRequiredService<ScadaDBContext>();
            ScadaDBSeeder.Seed(scadaContext, signalsGuids);

            return app;
        }
    }
}
