using Microsoft.EntityFrameworkCore;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {
            
    }
}
