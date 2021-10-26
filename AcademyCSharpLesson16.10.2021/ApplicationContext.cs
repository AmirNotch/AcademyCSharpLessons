using Microsoft.EntityFrameworkCore;
using System;

namespace AcademyCSharpLesson16._10._2021
{
    class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NP2IPR8\\DEV; Initial Catalog = AcademySummer; integrated security = True;");
        }
    }
}