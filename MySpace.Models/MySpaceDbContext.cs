using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MySpace.Models
{
    public partial class MySpaceDbContext : DbContext
    {
        public MySpaceDbContext()
        {
        }

        public MySpaceDbContext(DbContextOptions<MySpaceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PrsnlSpace> PrsnlSpaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SHIV004\\SQLEXPRESS;Initial Catalog=MySpaceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<PrsnlSpace>(entity =>
            {
                entity.ToTable("PrsnlSpace");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Msg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("msg");

                entity.Property(e => e.Spacedesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("spacedesc");

                entity.Property(e => e.Spacename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("spacename");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
