using System;
using System.Collections.Generic;
using BonsaiStore.Models;
using Microsoft.EntityFrameworkCore;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
namespace BonsaiStore.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<ItemModel> Items { get; set; }
	}
}
