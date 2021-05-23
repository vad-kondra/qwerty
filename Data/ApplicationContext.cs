using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    
    //dotnet ef migrations add <MigrationName> -p Data -s WEB -c ApplicationContext
    
    //dotnet ef database update -p Data -s WEB -c ApplicationContext
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
    }
}