class Program
{
	public static void Main(string[] args)
	{
		string[] names = new[]
		{
			"Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed"
		};

		var query1 = names.Where(name => name.StartsWith('M'));
		var query2 = from name in names where name.EndsWith('m') select name;

		string[] results1 = query1.ToArray();
		List<string> results2 = query2.ToList();

		// System.Console.WriteLine("Results 1");
		// foreach (var item in results1)
		// {
		// 	System.Console.WriteLine(" {0}", item);	
		// }

		// System.Console.WriteLine("Results 2");
		// foreach (var item in results2)
		// {
		// 	System.Console.WriteLine(" {0}", item);	
		// }

		// var query = names.Where(new Func<string, bool>(NameLongerThanFour));

		// var query = names.Where(NameLongerThanFour);
		// var query = names.Where(name => name.Length > 4);
		// var query = names
		// .Where(name => name.Length > 4)
		// .OrderBy(name => name.Length)
		// .ThenBy(name => name);

		// foreach (var item in query)
		// {
		// 	System.Console.Write("{0} length: {1}", item, item.Length);	
		// 	System.Console.WriteLine();
		// }

		System.Console.WriteLine("Filtering by type");
		List<Exception> exceptions =
		[
			new ArgumentException(),
			new SystemException(),
			new IndexOutOfRangeException(),
			new InvalidOperationException(),
			new NullReferenceException(),
			new InvalidCastException(),
			new OverflowException(),
			new DivideByZeroException(),
			new ApplicationException()
		];
		IEnumerable<ArithmeticException> arithmeticExceptions = exceptions.OfType<ArithmeticException>();

		foreach (var item in arithmeticExceptions)
		{
			System.Console.WriteLine(item);	
		}
	}
	public static bool NameLongerThanFour(string name)
	{
		return name.Length > 4;
	}
}