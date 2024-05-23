using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
        public class autContext: DbContext
        {
            public autContext(DbContextOptions<autContext> options)
                : base(options)
            {
            }

    
            public DbSet<User> Users { get; set; }
            

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=SupermarketEF;Trusted_Connection=True;");
            }
        }
    
}
