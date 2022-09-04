using Library_API.Entities;
using Library_API.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library_API.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Book { get; set; } 
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(12);

            modelBuilder.Entity<Book>()
                .Property(x => x.Title)
                .IsRequired();

        }

    }
}
