using Microsoft.EntityFrameworkCore;
namespace CreateCar.Models
{
    public partial class DbCarContext : DbContext
    {
        public DbCarContext()
        {
        }
        public DbCarContext(DbContextOptions<DbCarContext> options) : base(options)
        {
        }
        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("pk_car");

                entity.ToTable("cars");

                entity.Property(e => e.Id).HasColumnName("id");              
                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .HasColumnName("Brand");
                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("Model");
                entity.Property(e => e.Year).HasColumnName("Year");
                entity.Property(e => e.Color)
                   .HasMaxLength(50)
                   .HasColumnName("Color");
                entity.Property(e => e.Price).HasColumnName("Price");

            });
        }
    }
}
