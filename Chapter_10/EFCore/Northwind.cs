using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
	public class Northwind : DbContext
	{
		public DbSet<Category>? Categories { get; set; }
		public DbSet<Product>? Products { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (ProjectConstants.DatabaseProvider == "SQLite")
			{
				string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");

				System.Console.WriteLine(format: "Using {0} database file", path);
				optionsBuilder.UseSqlite($"Filename={path}");
			}
			else if (ProjectConstants.DatabaseProvider == "SQLServer")
			{
				string connection = "Data Source=.;" + "Initial Catalog=Northwind;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;";

				optionsBuilder.UseSqlServer(connection);
			}
			else
			{
				System.Console.WriteLine("DB doesn't find");
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
			.Property(category => category.CategoryName)
			.IsRequired()
			.HasMaxLength(15);

			if (ProjectConstants.DatabaseProvider == "SQLite")
			{
				modelBuilder.Entity<Product>()
				.Property(product => product.Cost)
				.HasConversion<double>();
			}
		}
	}
}