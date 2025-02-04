using Microsoft.EntityFrameworkCore;

namespace WebFormContact.Models
{
    public class ApplicationDbContext: DbContext
    {
       
                public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options) { }

                public DbSet<ContactMessage> ContactMessages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ContactMessage>().HasKey(r => r.Id);
        }


    }
}
