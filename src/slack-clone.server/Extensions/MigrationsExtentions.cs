using Microsoft.EntityFrameworkCore;
using slack_clone.server.Infrastructure;

namespace slack_clone.server.Extensions;

public static class MigrationsExtentions
{ 
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();
        using ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        dbContext.Database.Migrate();
    }
}

