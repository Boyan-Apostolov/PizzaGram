using Microsoft.EntityFrameworkCore;
using PizzaGram.Data;

namespace PizzaGram.Infrastructure
{
    public static class IApplicationBuilderExtensions
    {
        public static void MigrateDatabase(this IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

            var services = serviceScope.ServiceProvider;

            var data = services.GetRequiredService<PizzaGramDbContext>();

            data.Database.Migrate();
        }
    }
}
