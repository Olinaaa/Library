using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Library
{
    public partial class Книжная_библиотекаContext : DbContext
    {
        public Книжная_библиотекаContext()
        {
        }

        public Книжная_библиотекаContext(DbContextOptions<Книжная_библиотекаContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Авторы> Авторыs { get; set; }
        public virtual DbSet<Жанр> Жанрs { get; set; }
        public virtual DbSet<ЖанрКниги> ЖанрКнигиs { get; set; }
        public virtual DbSet<Книги> Книгиs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-3RD2A2G4\\SQLEXPRESS;Database=Книжная_библиотека;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Авторы>(entity =>
            {
                entity.HasKey(e => e.ФиоАвтора)
                    .HasName("автор");

                entity.ToTable("Авторы");

                entity.Property(e => e.ФиоАвтора)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ФИО_автора");

                entity.Property(e => e.ДеньРождения)
                    .HasColumnType("date")
                    .HasColumnName("день_рождения");

                entity.Property(e => e.КодАвтора).HasColumnName("код_автора");

                entity.Property(e => e.Страна)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("страна");
            });

            modelBuilder.Entity<Жанр>(entity =>
            {
                entity.HasKey(e => e.КодЖанра)
                    .HasName("код_ж");

                entity.ToTable("Жанр");

                entity.Property(e => e.КодЖанра)
                    .ValueGeneratedNever()
                    .HasColumnName("код_жанра");

                entity.Property(e => e.НазваниеЖанра)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("название_жанра");
            });

            modelBuilder.Entity<ЖанрКниги>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Жанр_книги");

                entity.Property(e => e.КодЖанра).HasColumnName("код_жанра");

                entity.Property(e => e.НазваниеКниги)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("название_книги");

                entity.HasOne(d => d.КодЖанраNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодЖанра)
                    .HasConstraintName("код_ж_миг");

                entity.HasOne(d => d.НазваниеКнигиNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.НазваниеКниги)
                    .HasConstraintName("назв_книги_миг");
            });

            modelBuilder.Entity<Книги>(entity =>
            {
                entity.HasKey(e => e.НазваниеКниги)
                    .HasName("книга");

                entity.ToTable("Книги");

                entity.Property(e => e.НазваниеКниги)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("название_книги");

                entity.Property(e => e.Год)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("год");

                entity.Property(e => e.КодКниги).HasColumnName("код_книги");

                entity.Property(e => e.ФиоАвтора)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ФИО_автора");

                entity.HasOne(d => d.ФиоАвтораNavigation)
                    .WithMany(p => p.Книгиs)
                    .HasForeignKey(d => d.ФиоАвтора)
                    .HasConstraintName("автор_миг");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
