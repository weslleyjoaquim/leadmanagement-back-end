using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Infrastructure.Data;

public class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        context.Database.Migrate();
        DbSeeder.Seed(context);
    }
}