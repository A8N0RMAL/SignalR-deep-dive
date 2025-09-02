using Microsoft.EntityFrameworkCore;
using SignalR.Models;

namespace SignalR.Data
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
        {
        }

        // DbSet for ChatMessage entity
        public DbSet<ChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure ChatMessage entity
            modelBuilder.Entity<ChatMessage>(entity =>
            {
                // Set table name
                entity.ToTable("ChatMessages");

                // Configure primary key with auto-increment
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd(); // Auto-increment

                // Configure Message property
                entity.Property(e => e.Message)
                      .IsRequired()
                      .HasMaxLength(1000); // Optional: set max length

                // Configure UserName property
                entity.Property(e => e.UserName)
                      .IsRequired()
                      .HasMaxLength(100); // Optional: set max length

                entity.Property(e => e.Timestamp)
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("GETUTCDATE()");
            });
        }
    }
}
