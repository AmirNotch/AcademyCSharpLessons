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

        public DbSet<Store> Stores { get; set; }
    }
}
