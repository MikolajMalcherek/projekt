using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Migrations.Operations;
using System.Linq;
using System.Collections.Generic;
using projekt.Models;

// Aby na podstawie tej klasy utworzyć bazę danych musimy utworzyć migrację, która wskaże EntityFramework wszystkie kroki, które są niezbędne
// aby odwzorować tą klasę w bazie danych (Tools -> NuGet Package Manager -> Pakcage Manager Console i wpisujemy add-migration nazwa_migracji)

namespace projekt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Zawodnik> Zawodnicy { get; set; }
        public virtual DbSet<Miejscowosci> Miejscowosci { get; set; }
        public virtual DbSet<Wyniki> Wyniki { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zawodnik>().ToTable("zawodnicy");
            modelBuilder.Entity<Wyniki>().ToTable("wyniki");
            modelBuilder.Entity<Miejscowosci>().ToTable("miejscowosci");
        }

        
        // w tej metodzie mamy dostęp do zmiennej optionsBuilder, na której możemy określić na jakiej bazie danych będziemy działać oraz 
        // jak powinno wyglądać połączenie do tej bazy danych
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL("server=127.0.0.1;port=3306;user=root;password=;database=projekt_bazy_danych")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
