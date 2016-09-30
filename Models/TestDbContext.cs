using Microsoft.EntityFrameworkCore;

namespace TestWebApp.Models
{
    public class TestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
                .UseMySql(@"Server=localhost;database=TestWebApp;uid=root;pwd=;");
    }
}