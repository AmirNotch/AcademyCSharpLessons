using AcademyCSharpLesson02._11._2021.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademyCSharpLesson02._11._2021.Context
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options): base(options)
        {
            /*Database.EnsureCreated();*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuotesCategory>().HasData
                (
                    new QuotesCategory { Id = 1, Name = "Бизнес" },
                    new QuotesCategory { Id = 2, Name = "Продуктивность" },
                    new QuotesCategory { Id = 3, Name = "Шуточные" },
                    new QuotesCategory { Id = 4, Name = "Жизненные" },
                    new QuotesCategory { Id = 5, Name = "Рабочие" }
                );
        }

        public DbSet<QuotesModel> QuotesModels { get; set; }

        public DbSet<QuotesCategory> QuotesCategories { get; set; }
    }
}
