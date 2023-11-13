using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Data;
using Data.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

   
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Libro> Libros { get; set; }
}
