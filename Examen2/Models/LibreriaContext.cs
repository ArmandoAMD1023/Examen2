using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Examen2.Models;

public partial class LibreriaContext : DbContext
{
    public LibreriaContext()
    {
    }

    public LibreriaContext(DbContextOptions<LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autores> Autores { get; set; }

    public virtual DbSet<Libros> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Autores__3214EC0710E1FAC5");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<Libros>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Libros__3214EC07F3F4A716");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Titulo).HasMaxLength(255);

            entity.HasOne(d => d.Autor).WithMany(p => p.obLibros)
                .HasForeignKey(d => d.AutorId)
                .HasConstraintName("FK__Libros__AutorId__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
