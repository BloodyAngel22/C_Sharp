using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using static System.Console;

class Program
{
	public static void FilterAndSort()
	{
		using (Northwind db = new())
		{
			DbSet<Product> allProducts = db.Products;

			IQueryable<Product> filteredProducts = allProducts.Where(product => product.UnitPrice < 10M);

			IOrderedQueryable<Product> sortedAndFilteredProducts = filteredProducts.OrderByDescending(product => product.UnitPrice);

			var projectedProducts = sortedAndFilteredProducts
				.Select(product => new
				{
					product.ProductId,
					product.ProductName,
					product.UnitPrice
				});

			System.Console.WriteLine("Product that cost less than 10M");
			foreach (var item in projectedProducts)
			{
				System.Console.WriteLine("{0}: {1} costs {2:$#,##0.00}", item.ProductId, item.ProductName, item.UnitPrice);
			}
			System.Console.WriteLine();
		}
	}
	public static void JoinCategoriesAndProducts()
	{
		using (Northwind db = new())
		{
			var queryJoin = db.Categories.Join(
				inner: db.Products,
				outerKeySelector: category => category.CategoryId,
				innerKeySelector: product => product.CategoryId,
				resultSelector: (c, p) => new
				{
					c.CategoryName,
					p.ProductName,
					p.ProductId
				}
			)
				.OrderBy(c => c.CategoryName);

			foreach (var item in queryJoin)
			{
				System.Console.WriteLine("{0}: {1} is in {2}", item.ProductId, item.ProductName, item.CategoryName);
			}
		}
	}
	public static void GroupJoinCategoriesAndProducts()
	{
		using (Northwind db = new())
		{
			var queryGroup = db.Categories.AsEnumerable().GroupJoin(
				inner: db.Products,
				outerKeySelector: category => category.CategoryId,
				innerKeySelector: product => product.CategoryId,
				resultSelector: (c, matchingProduct) => new
				{
					c.CategoryName,
					Products = matchingProduct.OrderBy(p => p.ProductName)
				}
			);

			foreach (var category in queryGroup)
			{
				System.Console.WriteLine("{0} has {1} products", category.CategoryName, category.Products.Count());

				foreach (var product in category.Products)
				{
					System.Console.WriteLine("	{0}", product.ProductName);
				}
				System.Console.WriteLine();
			}
		}
	}
	public static void AggregateProducts()
	{
		using (Northwind db = new())
		{
			WriteLine("{0,-25} {1,10}",
			arg0: "Product count:",
			arg1: db.Products.Count());
			WriteLine("{0,-25} {1,10:$#,##0.00}",
			arg0: "Highest product price:",
			arg1: db.Products.Max(p => p.UnitPrice));
			WriteLine("{0,-25} {1,10:N0}",
			arg0: "Sum of units in stock:",
			arg1: db.Products.Sum(p => p.UnitsInStock));
			WriteLine("{0,-25} {1,10:N0}",
			arg0: "Sum of units on order:",
			arg1: db.Products.Sum(p => p.UnitsOnOrder));
			WriteLine("{0,-25} {1,10:$#,##0.00}",
			arg0: "Average unit price:",
			arg1: db.Products.Average(p => p.UnitPrice));
			WriteLine("{0,-25} {1,10:$#,##0.00}",
			arg0: "Value of units in stock:",
			arg1: db.Products
			.Sum(p => p.UnitPrice * p.UnitsInStock));
		}
	}
	public static void UnderstandableLINQQuerySyntax()
	{
		string[] names = new[]
		{
			"Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed"
		};

		// var query = from name in names
		// 						where name.Length > 4
		// 						orderby name.Length, name
		// 						select name;

		var query = (from name in names
								 orderby name.Length, name
								 select name)
								.Where(name => name.Length > 4);


		foreach (var item in query)
		{
			System.Console.WriteLine(item);	
		}
	}
	public static void Main(string[] args)
	{
		// FilterAndSort();
		// JoinCategoriesAndProducts();
		// GroupJoinCategoriesAndProducts();
		// AggregateProducts();
		UnderstandableLINQQuerySyntax();
	}
}