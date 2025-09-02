using Microsoft.EntityFrameworkCore;
using SignalREmployees.Models;

namespace SignalREmployees.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet for Employee entity
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Employee entity
            modelBuilder.Entity<Employee>(entity =>
            {
                // Set table name
                entity.ToTable("Employees");

                // Configure primary key with auto-increment
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd(); // Auto-increment

                // Configure Message property
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                // Configure UserName property
                entity.Property(e => e.Address)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(e => e.Age)
                       .IsRequired();
            });
        }
    }
}
