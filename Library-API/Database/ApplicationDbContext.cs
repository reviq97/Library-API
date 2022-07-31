using Library_API.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library_API.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        DbSet<Customer> Customers { get; set; }
        DbSet<Book> Book { get; set; }
        DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(12);

            modelBuilder.Entity<Book>()
                .Property(x => x.Title)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(x => x.Street)
                .IsRequired();
        }

    }
}
