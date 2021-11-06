using System;
using Microsoft.EntityFrameworkCore;
using MVCproj.Models;

namespace MVCproj.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Products> Phones { get; set; }
    }
}
