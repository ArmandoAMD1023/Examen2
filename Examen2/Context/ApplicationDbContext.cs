using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Examen2.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

   
    public DbSet<Autores> Autores { get; set; }
    public DbSet<Libros> Libros { get; set; }
}
