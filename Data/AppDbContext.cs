using Microsoft.EntityFrameworkCore;
using bai_test_1.Models;

namespace bai_test_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Device> Devices { get; set; }
    }
}
