using Microsoft.AspNetCore.Mvc.RazorPages;

public class SuppliersModel : PageModel
{
	public IEnumerable<string?> Suppliers { get; set; }

	public void OnGet()
	{
		ViewData["Title"] = "Northwind B2B - Suppliers";

		Suppliers = new[]
		{
			"Alpha Co", "Beta Limited", "Gamma Corp"
		};
	}
}