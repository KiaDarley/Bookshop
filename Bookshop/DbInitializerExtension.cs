using Bookshop.Models;

namespace Bookshop
{
    internal static class DbInitialiserExtension
    {
        public static IApplicationBuilder UseItToSeedSqlServer(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<BookshopContext>();
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
