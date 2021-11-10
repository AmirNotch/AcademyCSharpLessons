using Microsoft.EntityFrameworkCore;
using ProductStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreMVC.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StoreCompany>().HasData
                (
                    new StoreCompany { Id = 1, Name = "Овощи"},
                    new StoreCompany { Id = 2, Name = "Фрукты"},
                    new StoreCompany { Id = 3, Name = "Хлеб"},
                    new StoreCompany { Id = 4, Name = "Молочные продукты"}
                ); 
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreCompany> StoreCompanies { get; set; }
    }
}
