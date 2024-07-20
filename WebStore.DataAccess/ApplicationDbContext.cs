using Microsoft.EntityFrameworkCore;

namespace WebStore.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


}
