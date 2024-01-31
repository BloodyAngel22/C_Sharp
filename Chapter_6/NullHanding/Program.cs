class Program
{
	public delegate void Action();
	public static void Main(string[] args)
	{
		// int thisCannotBeNull = 0;
		// System.Console.WriteLine(thisCannotBeNull);
		// int? thisCouldBeNull = null;
		// System.Console.WriteLine(thisCouldBeNull);
		// System.Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

		// Address address = new()
		// {
		// 	Building = null,
		// 	Street = null,
		// 	City = "London",
		// 	Region = null
		// };

		// if (thisCouldBeNull is not null)
		// {
		// 	System.Console.WriteLine("Not null");
		// }
		// else
		// {
		// 	System.Console.WriteLine("Null");
		// }

		// string authorName = null;

		// int? x = authorName?.Length ?? 1;
		// System.Console.WriteLine(x);

		Action act;
		act = Foo;
		act += Foo_2;
		act += Foo_3;
		act();
	}
	class Address
	{
		public string? Building;
		public string Street = string.Empty;
		public string City = string.Empty;
		public string Region = string.Empty;
	}

	public static void Foo()
	{
		int? x = 5;
		x *= 2;
		System.Console.WriteLine(x);
	}
	public static void Foo_2()
	{
		int? x = 5;
		x *= 3;
		System.Console.WriteLine(x);
	}
	public static void Foo_3()
	{
		int? x = 5;
		x *= 4;
		System.Console.WriteLine(x);
	}
}