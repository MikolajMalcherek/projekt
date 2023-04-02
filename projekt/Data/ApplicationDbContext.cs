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
            // tutaj ustawiamy które kolumny są kolumanmi wymaganyi w bazie danych

            modelBuilder.Entity<Zawodnik>()
                .Property(r => r.imie_zawodnika)
                .IsRequired();
            modelBuilder.Entity<Zawodnik>()
                .Property(r => r.nazwisko_zawodnika)
                .IsRequired();

            modelBuilder.Entity<Miejscowosci>()
                .Property(r => r.nazwa_miejscowosci)
                .IsRequired();

            modelBuilder.Entity<Miejscowosci>()
                .Property(r => r.kraj_miejscowosci)
                .IsRequired();
        }

        
        // w tej metodzie mamy dostęp do zmiennej optionsBuilder, na której możemy określić na jakiej bazie danych będziemy działać oraz 
        // jak powinno wyglądać połączenie do tej bazy danych
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL("server=127.0.0.1;port=3306;user=root;password=;database=zawody")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
