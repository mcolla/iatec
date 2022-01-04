using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iatec_v2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                 .Property(p => p.Name)
                     .HasMaxLength(80);

            modelBuilder.Entity<Product>()
                 .Property(p => p.Price)
                     .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product { id = 1, Name = "Pneu aro 15", Price = 256.50M, Stock = 10 },
                    new Product { id = 2, Name = "Limpador de parabrisas universal", Price = 45.99M, Stock = 30 },
                    new Product { id = 3, Name = "Kit de carpet emborrachado", Price = 110.60M, Stock = 10 });

            modelBuilder.Entity<Vehicle>()
                 .Property(p => p.Model)
                     .HasMaxLength(100);

            modelBuilder.Entity<Vehicle>()
                .HasData(
                    new Vehicle { id = 1, Model = "Gol", Brand = "Volkswagen", Doors = 4, Cambium = "m", Year = 2015, Fuel = "f" },
                    new Vehicle { id = 2, Model = "Fiesta", Brand = "Ford", Doors = 2, Cambium = "m", Year = 2017, Fuel = "g" },
                    new Vehicle { id = 3, Model = "Duster", Brand = "Renault", Doors = 4, Cambium = "a", Year = 2019, Fuel = "a" });

        }

    }
}
