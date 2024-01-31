class Program
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("I can run everywhere");

		if (OperatingSystem.IsMacOS())
		{
			System.Console.WriteLine("Hello Mac OS");
		}
		else if (OperatingSystem.IsWindows())
		{
			System.Console.WriteLine("Hello Windows");
		}
		else if (OperatingSystem.IsLinux())
		{
			System.Console.WriteLine("Hello Linux");
		}
		else
		{
			System.Console.WriteLine("Hello another system");
		}
	}
}