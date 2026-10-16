using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebCarApp.Infrastructure.Data.Domain;

namespace WebCarApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
    }
}
