using System;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data
{
    public partial class TestEFContext : DbContext
    {
        public TestEFContext()
        {
        }

        public TestEFContext(DbContextOptions<TestEFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentClass> StudentClass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Group");
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {
                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentClass_Class");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentClass_Student");
            });

            modelBuilder.Query<StudentGroupClass>().ToView("getstudentsfromclass");
        }
    }
}
