using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using EsVideo.Model;

namespace EsVideo.Database
{
    public class ApllicatinDbContext : DbContext
    {
        public ApllicatinDbContext(DbContextOptions<ApllicatinDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin1234567",
                Name = "Tino",
                Surname = "Lebonwski"
            });
            for (int i = 2; i < 10; i++)
            {
                modelBuilder.Entity<User>().HasData(new User
                {
                    Id = i,
                    Username = $"user{i}",
                    Password = $"password{i}",
                    Name = $"Name{i}",
                    Surname = $"Surname{i}"
                });
            }
            
        }
    }
}
