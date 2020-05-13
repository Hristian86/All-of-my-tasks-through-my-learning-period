using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestSQL.Data.TestSQL.Data.Models
{
    public partial class SoftUniContext : DbContext
    {
        public SoftUniContext()
        {
        }

        public SoftUniContext(DbContextOptions<SoftUniContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bananas> Bananas { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Minions> Minions { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SoftUni;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CurrentAddress).HasMaxLength(30);
            });

            modelBuilder.Entity<Minions>(entity =>
            {
                entity.ToTable("MINIONS");

                entity.Property(e => e.Sname)
                    .HasColumnName("SName")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastNames).HasMaxLength(30);

                entity.Property(e => e.MidleName).HasMaxLength(30);

                entity.Property(e => e.Minionsid).HasColumnName("MINIONSID");

                entity.HasOne(d => d.Banana)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.BananaId)
                    .HasConstraintName("FK__Students__Banana__4AB81AF0");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Students__CityId__3A81B327");

                entity.HasOne(d => d.Minions)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Minionsid)
                    .HasConstraintName("FK__Students__MINION__47DBAE45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
