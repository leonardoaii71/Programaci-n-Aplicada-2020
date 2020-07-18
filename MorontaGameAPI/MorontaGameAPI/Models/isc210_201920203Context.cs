using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MorontaGameAPI.Models
{
    public partial class isc210_201920203Context : DbContext
    {
        public isc210_201920203Context()
        {
        }

        public isc210_201920203Context(DbContextOptions<isc210_201920203Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Nivel1> Nivel1 { get; set; }
        public virtual DbSet<Nivel2> Nivel2 { get; set; }
        public virtual DbSet<S3scoreController> S3scoreController { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.77.18;Initial Catalog=isc210_201920203;Persist Security Info=True;User ID=isc210_201920203;Password=ProgramacionAplicada!123;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nivel1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nivel2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<S3scoreController>(entity =>
            {
                entity.Property(e => e.CreacionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlayerName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
