using FitAI.Models;
using Microsoft.EntityFrameworkCore;


namespace FitAI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<OutfitHistory> OutfitHistories { get; set; }
    }
}