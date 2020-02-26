using ContentInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace ContentInsurance.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "Electronics" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, Name = "Clothing" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, Name = "Kitchen" });

            // seed contents
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 1,
                Name = "TV",
                Value = 2000,
                CategoryId = 1
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 2,
                Name = "Playstation",
                Value = 400,
                CategoryId = 1
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 3,
                Name = "Stereo",
                Value = 1600,
                CategoryId = 1
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 4,
                Name = "Shirts",
                Value = 1100,
                CategoryId = 2
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 5,
                Name = "Jeans",
                Value = 1100,
                CategoryId = 2
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 6,
                Name = "Pots and Pans",
                Value = 3000,
                CategoryId = 3
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 7,
                Name = "Flatware",
                Value = 500,
                CategoryId = 3
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 8,
                Name = "Knife Set",
                Value = 500,
                CategoryId = 3
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 9,
                Name = "Misc",
                Value = 1000,
                CategoryId = 3
            });
        }
    }
}