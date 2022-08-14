using Bookshop.Components.Contexts;

namespace Bookshop.Components.DbInit
{
    /// <summary>
    /// Connects the DbContext of the given ApplicationBuilder to the DbInitialiser, so that the initial set of data may be seeded in the app DbContext
    /// </summary>
    internal static class DbInitialiserExtension
    {
        public static IApplicationBuilder UseItToSeedSqlServer(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using IServiceScope scope = app.ApplicationServices.CreateScope();
            IServiceProvider services = scope.ServiceProvider;

            try
            {
                BookshopContext context = services.GetRequiredService<BookshopContext>();

                //Calls the method to populate the DbSet with the initial data
                DbInitialiser.Initialise(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return app;
        }
    }
}
