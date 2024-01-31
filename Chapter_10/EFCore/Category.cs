using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
	public class Category
	{
		//Свойства которые находятся в бд
		public int CategoryId { get; set; }
		public string? CategoryName { get; set; }

		[Column(TypeName = "ntext")]
		public string? Description { get; set; }

		public virtual ICollection<Product> Products { get; set; }

		public Category()
		{
			Products = new HashSet<Product>();
		}

	}
}