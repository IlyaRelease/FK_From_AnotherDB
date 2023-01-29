using WebApplication1_FK_From_AnotherDB.EFCore.Configurator;
using WebApplication1_FK_From_AnotherDB.EFCore.SCADA;
using WebApplication1_FK_From_AnotherDB.EFCore.Seeders;

namespace WebApplication1_FK_From_AnotherDB.Exstentions
{
    internal static class DBInitializerExtension
    {
        public static IApplicationBuilder SeedDB(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;

            var signalsGuids = new List<Guid>();
            for (int i = 0; i < 10; i++) signalsGuids.Add(Guid.NewGuid());

            var confContext = services.GetRequiredService<ConfDBContext>();
            ConfDBInitializer.Initialize(confContext, signalsGuids);

            var scadaContext = services.GetRequiredService<ScadaDBContext>();
            ScadaDBInitializer.Initialize(scadaContext, signalsGuids);

            return app;
        }
    }
}
