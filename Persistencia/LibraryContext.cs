
using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        
    }
       public DbSet<Book> ?Books { get; set; }
       public DbSet<Marca> ?Marcas { get; set; }
       public DbSet<Pais> ?Paises { get; set; }
       public DbSet<Persona> ?Personas { get; set; }
       public DbSet<PersonaBook> ?PersonaBooks { get; set; }
       public DbSet<Provincia> ?Provincias { get; set; }
       public DbSet<Region> ?Regions { get; set; }
       public DbSet<TypePerson> ?TypePersons { get; set; }
 

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          


          
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
     
     }