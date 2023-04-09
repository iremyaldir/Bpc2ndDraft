using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BPC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Buy> Buys { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}