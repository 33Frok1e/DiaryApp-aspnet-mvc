using Microsoft.EntityFrameworkCore;
using DiaryApp.Models;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        // Four Steps To Add A Table

        // 1. Create a Model Class
        // 2. Add DbSet
        // 3. Add Migration addDiaryEntryTable
        // 4. Update Database

        public DbSet<DairyEntry> DiaryEntries {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DairyEntry>().HasData(
                    new DairyEntry
                    {
                        Id = 1,
                        Title = "Swimming",
                        Content = "Went Swimming With Elina",
                        Created = DateTime.Now
                    },
                    new DairyEntry
                    {
                        Id = 2,
                        Title = "Gaming",
                        Content = "Playing PUBG With Yuna",
                        Created = DateTime.Now
                    }
                );
        }
    }
}
