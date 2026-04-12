using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class AppDbContext : DbContext
	{
		//public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		//{

		//}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=EFCore01;Trusted_Connection=True;TrustServerCertificate = true");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Product > Products { get; set; }
	}
}
