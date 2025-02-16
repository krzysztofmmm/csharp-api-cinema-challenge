using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using api_cinema_challenge.Data;

namespace api_cinema_challenge.Data
{
    public static class MigrationRunner
    {
        public static void ApplyProjectMigrations(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();
                db.Database.Migrate();
            }
        }
    }
}
