using System;
using System.Collections.Generic;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using BonsaiStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BonsaiStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ItemModel> Items { get; set; }
        public DbSet<OrderModel> Orders { get; set; }

        public DbSet<CategoryModel> Categories { get; set; }
    }
}
