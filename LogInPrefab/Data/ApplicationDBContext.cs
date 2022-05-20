using LogInPrefab.Models;
using Microsoft.EntityFrameworkCore;

namespace LogInPrefab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
